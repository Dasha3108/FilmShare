using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Attributes
{
    public class CheckAdminFilter : ActionFilterAttribute
    {
        private readonly IStorage _storage;
        private readonly IHttpContextAccessor _contextAccessor;

        public CheckAdminFilter(IStorage storage, IHttpContextAccessor contextAccessor)
        {
            _storage = storage;
            _contextAccessor = contextAccessor;
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);

            var authenticatedUser = _contextAccessor.HttpContext.User.Identity.Name;

            if (!_storage.IsUserAdmin(authenticatedUser))
            {
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new
                {
                    controller = "Home",
                    action = "Index"
                }));
            }
        }
    }
}
