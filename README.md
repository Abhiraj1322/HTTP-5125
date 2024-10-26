# Files from HTTP 5125

## Back-End Web Development 1

**Course Code**: HTTP 5125  
**Academic Year**: 2025-2026

In this course, students are introduced to server-side web development with the C# programming language. Students will implement techniques for creating data-driven websites drawing from various external data sources. The course emphasizes best practices in backend development, including API integration and database management.

## Course Objectives
- Understand the fundamentals of server-side programming using C#.
- Learn to create and manage data-driven websites.
- Explore techniques for integrating external data sources into web applications.

## Links

For more information on C# and server-side development, visit [Microsoft C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/).

## Images

![C# Back-End Development](./csharp_backend_development.jpg)

***Important Notice:*** This repository contains assignments and projects related to back-end web development. Mastering C# and data integration is crucial for building efficient web applications.

## Example Code

Here’s a simple example of a C# controller action for retrieving data:

```csharp
using Microsoft.AspNetCore.Mvc;

public class ProductsController : Controller
{
    public IActionResult Index()
    {
        var products = GetProductsFromDatabase();
        return View(products);
    }

    private List<Product> GetProductsFromDatabase()
    {
        // Logic to retrieve products from a database
    }
}
