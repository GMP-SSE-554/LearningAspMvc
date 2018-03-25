using Microsoft.AspNetCore.Mvc;
using System;
using LearningAspMvc.Models;

namespace LearningAspMvc.Controllers
{
    public class ResultController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index() => View();

        /// <summary>
        /// Gets the default text result.
        /// </summary>
        /// <returns></returns>
        public IActionResult Text() => Content("Plain text", "text/plain");

        /// <summary>
        /// Gets the default JSON result.
        /// </summary>
        /// <returns></returns>
        public IActionResult Json() => Json(
            new Display
            {
                Id = 0,
                Text = "Json data",
                Date = DateTime.Now,
            });

        /// <summary>
        /// Goes to default greeting.
        /// </summary>
        /// <returns></returns>
        public IActionResult GoToRoute() => RedirectToRoute(new { controller = "Home", action = "Greeting" });

        /// <summary>
        /// Pulls up the cardinal image.
        /// </summary>
        /// <returns></returns>
        public IActionResult Cardinal() => File("~Images/DSC_0050.jpg", "image/jpeg");
    }
}
