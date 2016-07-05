namespace VersionLibrary
{
    using System;
    using System.Configuration;
    using System.Web.Mvc;

    /// <summary>
    /// ASP.NET MVC HTML Helper that gives current assembly version.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Returns the version of the current assembly.
        /// </summary>
        /// <param name="html">Html helper with the context to get the version from</param>
        /// <returns>Assembly's version</returns>
        public static string Version(this HtmlHelper html)
        {
            if (html == null)
                throw new ArgumentNullException("html");

            // getting configured values
            var section = ConfigurationManager.GetSection("Version") as Configuration;
            var config = section == null ? default(string) : section.VersionToShow;
            var safe = section == null ? default(bool) : section.Safe;

            // getting assembly version
            var assembly = html.ViewContext.HttpContext.ApplicationInstance.GetType()
                .BaseType.Assembly.GetName().Version.ToString();

            // checking for emptiness
            var emptyAssembly = assembly == "0.0.0.0";
            var emptyConfig = string.IsNullOrEmpty(config);

            // if no version was configured
            if (emptyAssembly && emptyConfig)
            {
                // if it's not safe an exception is thrown
                if (!safe)
                    throw new ConfigurationErrorsException("No version was configured.");

                return string.Empty;
            }

            // if both versions were configured
            if (!emptyAssembly && !emptyConfig)
            {
                // if it's not safe an exception is thrown
                if (!safe)
                    throw new ConfigurationErrorsException(
                        "The version was configured both on assembly and on .config file.");

                return config;
            }

            // returns the found version, either the configured one or the assembly one
            return emptyAssembly ? config : "v" + assembly;
        }
    }
}
