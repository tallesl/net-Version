namespace VersionLibrary
{
    using System.Web.Mvc;

    /// <summary>
    /// ASP.NET MVC HTML Helper that gives current assembly version.
    /// </summary>
    public static class VersionHtmlHelper
    {
        /// <summary>
        /// Returns the version of the current assembly.
        /// </summary>
        /// <param name="html">Html helper with the context to get the version from</param>
        /// <returns>Assembly's version</returns>
        public static string Version(this HtmlHelper html)
        {
            return html.ViewContext.HttpContext
                .ApplicationInstance.GetType().BaseType
                .Assembly.GetName().Version.ToString();
        }
    }
}
