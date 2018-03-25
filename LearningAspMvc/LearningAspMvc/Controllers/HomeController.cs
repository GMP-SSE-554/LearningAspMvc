using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace TadLearningAspMvc.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index() => View();

        /// <summary>
        /// Gets the default greeting.
        /// </summary>
        /// <returns></returns>
        public string Greeting() => "Welcome to this site\n" +
            "\t-Home Controller";

        /// <summary>
        /// Gets the greeting.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public string GreetName(string name) =>
            HtmlEncoder.Default.Encode($"Welcome to this site, {name}" +
                $" -Home Controller");

        /// <summary>
        /// Adds the specified x and y.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        /// <returns></returns>
        public string Add(int x, int y) => $"{x} + {y} = {x + y}";
    }
}
