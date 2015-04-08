﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Routing;

namespace WebApi2Book.Web.Common.Routing
{
    public class ApiVersionConstraint: IHttpRouteConstraint
    {
        public ApiVersionConstraint(string allowedVersion)
        {
            AllowedVersion = allowedVersion.ToLowerInvariant();
        }
        public bool Match(System.Net.Http.HttpRequestMessage request, 
            IHttpRoute route, string parameterName, 
            IDictionary<string, object> values, 
            HttpRouteDirection routeDirection)
        {
            object value;
            if (values.TryGetValue(parameterName, out value) && value != null)
            {
                return AllowedVersion.Equals(value.ToString().ToLowerInvariant());
            }
            return false;
        }

        public string AllowedVersion { get; private set; }
    }
}
