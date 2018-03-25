using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TadLearningAspMvc.Models;

namespace TadLearningAspMvc.ViewComponents
{
    public class EventListViewComponent : ViewComponent
    {
        readonly EventAndMenuContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventListViewComponent"/> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public EventListViewComponent(EventAndMenuContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Gets the event by date range.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        IEnumerable<Display> EventsByDateRange(DateTime from, DateTime to)
        {
            return _context.Events.Where(e => from <= e.Date && e.Date <= to);
        }

        /// <summary>
        /// Invokes the task asyncronously.
        /// </summary>
        /// <param name="from">From.</param>
        /// <param name="to">To.</param>
        /// <returns></returns>
        public Task<IViewComponentResult> InvokeAsync(DateTime from, DateTime to)
        {
            return Task.FromResult<IViewComponentResult>(
                View(EventsByDateRange(from, to)));
        }
    }
}
