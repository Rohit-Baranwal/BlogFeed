using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogFeed.Models.ViewModels
{
     //Data Tranfer Object (dto)
    public class PostViewModel
    {
        public Post Post { get; set; }

        [ValidateNever]
        public IEnumerable<SelectListItem> Categories { get; set; }

        public IFormFile? FeatureImage { get; set; }

    }
}
