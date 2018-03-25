
using System;
using System.Collections.Generic;

namespace TadLearningAspMvc.Models
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

        /// <summary>
        /// The menus
        /// </summary>
        IEnumerable<Display> menus = null;
        public IEnumerable<Display> Menus
        {
            get
            {
                return menus ?? (menus = new List<Display>()
                {
                    new Display
                    {
                        Id = 1,
                        Text = "Corn",
                    },
                    new Display
                    {
                        Id = 2,
                        Text = "Steak"
                    }
                });
            }
        }
    }
}
