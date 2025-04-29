using System.Web;
using System.Web.Mvc;

namespace CustomHelper
{
    public static class CustomHelpers
    {
        public static MvcHtmlString Image(string src, string alt)
        {
            return new MvcHtmlString(string.Format("<img src='{0}' alt = '{1}'></img>", src, alt));
        }
    }
}
