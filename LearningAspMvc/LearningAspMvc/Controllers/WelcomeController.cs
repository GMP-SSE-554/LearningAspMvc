using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using TadLearningAspMvc.Models;

namespace TadLearningAspMvc.Controllers
{
    public class WelcomeController : Controller
    {
        EventAndMenuContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="WelcomeController"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public WelcomeController(EventAndMenuContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public IActionResult Index() => View();

        /// <summary>
        /// Uses the partial view.
        /// </summary>
        /// <returns></returns>
        public IActionResult UsePartialView() => View(_context);

        /// <summary>
        /// Uses the other partial view.
        /// </summary>
        /// <returns></returns>
        public IActionResult UseOtherPartialView() => View();

        /// <summary>
        /// Shows the events.
        /// </summary>
        /// <returns></returns>
        public IActionResult ShowEvents()
        {
            ViewBag.EventsTitle = "Live Events";
            return PartialView(_context.Events);
        }

        /// <summary>
        /// Passes the data.
        /// </summary>
        /// <returns></returns>
        public IActionResult PassData()
        {
            ViewBag.MyData = "Welcome! -WelcomeController";
            return View();
        }

        /// <summary>
        /// Passes the model.
        /// </summary>
        /// <returns></returns>
        public IActionResult PassModel()
        {
            var menu = new List<Display>
            {
                new Display
                {
                    Id = 1,
                    Text = "List item #1",
                    Date = DateTime.Now
                },
                new Display
                {
                    Id = 2,
                    Text = "List item #2",
                    Date = DateTime.Now
                }
            };
            return View(menu);
        }

        /// <summary>
        /// Gets a simple layout.
        /// </summary>
        /// <returns></returns>
        public IActionResult SimpleLayout() => View();

        /// <summary>
        /// Gets a sectioned layout.
        /// </summary>
        /// <returns></returns>
        public IActionResult SectionLayout() => View();

        /// <summary>
        /// Uses the view component.
        /// </summary>
        /// <returns></returns>
        public IActionResult UseViewComponent() => View();

        /// <summary>
        /// Uses the photo view component.
        /// </summary>
        /// <returns></returns>
        public IActionResult Photo() => View();
    }
}