using FilmShare.Models.Storage;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace FilmShare.Constraints
{
    public class DynamicProfileConstraint : IRouteConstraint
    {
        public bool Match(HttpContext httpContext, IRouter route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            if (httpContext == null)
                throw new ArgumentNullException(nameof(httpContext));

            if (route == null)
                throw new ArgumentNullException(nameof(route));

            if (routeKey == null)
                throw new ArgumentNullException(nameof(routeKey));

            if (values == null)
                throw new ArgumentNullException(nameof(values));

            if (values.TryGetValue(routeKey, out object routeValue))
            {
                if (int.TryParse(Convert.ToString(routeValue, CultureInfo.InvariantCulture), out int profileId))
                {
                    var storage = (IStorage)httpContext.RequestServices.GetService(typeof(IStorage));
                    var profile = storage.GetProfileModelById(profileId);
                    return profile != null;
                }
                return false;
            }

            return false;
        }
        
    }
}
