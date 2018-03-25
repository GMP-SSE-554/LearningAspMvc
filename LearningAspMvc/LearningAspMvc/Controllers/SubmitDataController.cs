using Microsoft.AspNetCore.Mvc;
using TadLearningAspMvc.Models;

namespace TadLearningAspMvc.Controllers
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

        [HttpPost]
        public IActionResult AddUser(User u)
        {
            ViewBag.Info = $"User added: {u.UserName} ({u.LastName}, {u.FirstName})," +
                $" Password: ******. From - {u.State}, {u.ZipCode}";
            return View("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> AddUser()
        //{
        //    var u = new User();
        //    bool updated = await TryUpdateModelAsync<User>(u);
        //    if (updated)
        //    {
        //        ViewBag.Info = $"User added: {u.UserName} ({u.LastName}, {u.FirstName})," +
        //            $" Password: ******. From - {u.State}, {u.ZipCode}";
        //        return View("Index");
        //    }
        //    else
        //    {
        //        return View("Error");
        //    }
        //}
    }
}
