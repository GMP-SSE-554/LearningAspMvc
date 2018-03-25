using Microsoft.AspNetCore.Mvc;
using LearningAspMvc.Models;

namespace LearningAspMvc.Controllers
{
    public class SubmitDataController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index() => View();

        /// <summary>
        /// Creates the menu.
        /// </summary>
        /// <returns></returns>
        public IActionResult CreateUser() => View();

        /// <summary>
        /// Goes to photo.
        /// </summary>
        /// <returns></returns>
        public IActionResult ChoosePhoto() => View();

        /// <summary>
        /// Adds the user.
        /// </summary>
        /// <param name="u">The u.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddUser(User u)
        {
            ViewBag.Info = $"User added: {u.UserName} ({u.LastName}, {u.FirstName})," +
                $" Password: ******. From - {u.State}, {u.ZipCode}";
            return View("Index");
        }

        /// <summary>
        /// Goes to selected photo.
        /// </summary>
        /// <param name="photoName">Name of the photo.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult GoToSelectedPhoto(string photoName)
        {
            photoName = photoName.ToLower();
            if (photoName != "statue" && photoName != "cardinal" && photoName != "ladybug")
            {
                return View("ChoosePhoto");
            }
            return View(photoName);
        }
    }
}
