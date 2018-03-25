using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace LearningAspMvc.Controllers
{
    public class PocoController
    {
        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        public string Index() => "this is POCO";
    
        [ActionContext]
        public ActionContext ActionContext { get; set; }
        public HttpContext Context => ActionContext.HttpContext;
        public ModelStateDictionary ModelState => ActionContext.ModelState;

        /// <summary>
        /// Gets the user-agent information.
        /// </summary>
        /// <returns></returns>
        public string UserAgentInfo()
        {
            if (Context.Request.Headers.ContainsKey("User-Agent"))
            {
                return Context.Request.Headers["User-Agent"];
            }
            return "No user-agent information";
        }
    }
}
