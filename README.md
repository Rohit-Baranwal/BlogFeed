# Blogging Platform – ASP.NET Core MVC (.NET 9)

![.NET 9](https://img.shields.io/badge/.NET-9.0-5C2D91.svg?style=for-the-badge&logo=.net)
![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-MVC-blueviolet?style=for-the-badge&logo=.net)
![SQL Server](https://img.shields.io/badge/SQL_Server-CC2927.svg?style=for-the-badge&logo=microsoft-sql-server)
![Bootstrap 5](https://img.shields.io/badge/Bootstrap-5-8628FB.svg?style=for-the-badge&logo=bootstrap)

A modern, fully functional **database-driven blogging platform** built from scratch using **ASP.NET Core 9 MVC**, demonstrating end-to-end full-stack development skills with clean architecture, role-based authorization, and seamless user experience.

## 🚀 Features

### Content Management (Admin Only)
- Full CRUD for blog posts & categories
- Rich text editor for post content
- Featured image upload with server-side storage
- Category association & publish date management

### User Interaction
- Responsive homepage with Bootstrap 5 cards
- Category-based filtering (via navigation)
- "Read more" collapsible post previews
- Detailed post view with metadata

### AJAX-Powered Comment System
- Add comments without page refresh
- Client + server-side validation
- Real-time success/error messages
- Comments restricted to authenticated users

### Authentication & Role-Based Authorization
- Complete user registration/login/logout (Microsoft Identity)
- Two roles: **User** & **Admin**
  
| Role       | Permissions                                                                 |
|------------|-------------------------------------------------------------------------------|
| User       | View posts • Filter by category • Read full posts • Add comments (post-login) |
| Admin      | Everything User can + Create/Edit/Delete posts & categories • Manage content |

### Tech Highlights
- Entity Framework Core Migrations (Code-First)
- One-to-many relationships (Post → Category, Post → Comments)
- Asynchronous AJAX with jQuery
- Responsive design (mobile-first)
- Clean MVC architecture with Areas (optional – easy to extend)

## 🛠️ Technology Stack

| Layer              | Technology                                  |
|--------------------|----------------------------------------------|
| Backend            | ASP.NET Core MVC (.NET 9)                   |
| ORM                | Entity Framework Core                       |
| Database           | Microsoft SQL Server (LocalDB / Full)       |
| Authentication     | ASP.NET Core Identity + Role-based Auth     |
| Frontend           | Bootstrap 5, jQuery AJAX, Vanilla JS        |
| Rich Text Editor   | Summernote / TinyMCE / Quill (your choice)  |
| Styling            | Bootstrap 5 + Custom CSS                    |

## 📂 Project Structure (Key Parts)
BlogPlatform/
├── Areas/
│   └── Admin/                # Admin controllers & views
├── Controllers/
├── Models/                   # EF Core entities
├── Views/
├── wwwroot/
│   ├── uploads/              # Post featured images
│   └── lib/                  # Bootstrap, jQuery, RichText
├── Data/                     # DbContext + Migrations
└── Services/                 # (Optional) Business logic                

## 🛠️ Setup & Running Locally

### Prerequisites
- .NET 9 SDK
- SQL Server / LocalDB
- Visual Studio 2022 / VS Code 

### Steps
1. Clone the repository
   ```bash
   git clone https://github.com/Rohit-Baranwal/BlogFeed.git

2. Navigate to project folder
   ```bash
   cd BlogFeed

3.  Configure the Database Connection

4.  Open `appsettings.json` and set your SQL Server connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=your-server-name;Database=your-database-name;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
   
5.  Apply migrations
   ```bash
    dotnet ef database update
```

or in Package Manager Console:
```powershell
    Update-Database
```

6.  Run the app in Visual studio 
```bash
  dotnet run
```
