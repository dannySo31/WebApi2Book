using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace WebApi2Book.Web.Common.Security
{
    public class UserSession:IWebUserSession
    {

        public string AppVersionInUse
        {
            get {
                const int versionIndex = 2;
                if (HttpContext.Current.Request.Url.Segments.Count() < versionIndex + 1)
                {
                    return string.Empty;
                }
                var apiVersionInUse = HttpContext.Current.Request.Url.Segments[versionIndex].Replace("/", string.Empty);

                return apiVersionInUse;

            }
        }

        public Uri RequestUri
        {
            get { return HttpContext.Current.Request.Url; }
        }

        public string HttpRequestMethod
        {
            get { return HttpContext.Current.Request.HttpMethod; }
        }

        public string FirstName
        {
            get {
                return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.GivenName).Value;
            }
        }

        public string LastName
        {
            get { return ((ClaimsPrincipal)HttpContext.Current.User).FindFirst(ClaimTypes.Surname).Value; }
        }

        public string UserName
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsInRole(string roleName)
        {
             return ((ClaimsPrincipal)HttpContext.Current.User).IsInRole(roleName); 
        }
    }
}
