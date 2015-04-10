using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi2Book.Common.Security;

namespace WebApi2Book.Web.Common.Security
{
    public interface IWebUserSession:IUserSession
    {
        string AppVersionInUse { get; }
        Uri RequestUri { get; }
        string HttpRequestMethod { get; }
    }
}
