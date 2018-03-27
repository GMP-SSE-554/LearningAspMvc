
using System;
using System.Collections.Generic;

namespace LearningAspMvc.Models
{
    public class EventAndMenuContext
    {
        /// <summary>
        /// The events
        /// </summary>
        IEnumerable<Display> events = null;
        public IEnumerable<Display> Events
        {
            get
            {
                return events ?? (events = new List<Display>()
                {
                    new Display
                    {
                        Id = 1,
                        Text = "Hiking trip.",
                        Date = new DateTime(2018, 3, 15)
                    },
                    new Display
                    {
                        Id = 2,
                        Text = "Music show.",
                        Date = new DateTime(2018, 6, 24)
                    }
                });
            }
        }
    }
}
