using BlogFeed.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogFeed.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public AuthController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModal model)
        {
            if(ModelState.IsValid)
            {
                //Create Identity User Object
                var user = new IdentityUser 
                            { UserName = model.Email, 
                              Email = model.Email 
                            };

                var result = await _userManager.CreateAsync(user, model.Password);
                
                if (result.Succeeded)
                {
                    //if the User role exist in database
                    if(!await _roleManager.RoleExistsAsync("User"))
                    {
                        await _roleManager.CreateAsync(new IdentityRole("User"));    
                    }

                    await _userManager.AddToRoleAsync(user, "User");
                    await _signInManager.SignInAsync(user, true);

                    return RedirectToAction("Index", "Post");
                }

            }

            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user == null)
                {
                    ModelState.AddModelError("", "Email or Password is Incorrect!!");
                    return View(model);
                }
                
                var signInResult = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
                if (!signInResult.Succeeded)
                {
                    ModelState.AddModelError("", "Email or Password is Incorrect!!");
                    return View(model);
                }

                return RedirectToAction("Index", "Post");
            }

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        { 
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Post");
        }

        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
