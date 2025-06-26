using Microsoft.AspNetCore.Mvc;
using System.IO;
using ZombicideGallery.Models;

namespace ZombicideGallery.Controllers
{
    public class GalleryController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public GalleryController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            var characters = CharacterData.InitialCharacters;

            return View(characters);
        }
    }
}
