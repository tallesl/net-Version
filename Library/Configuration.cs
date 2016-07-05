namespace VersionLibrary
{
    using System.Configuration;

    internal class Configuration : ConfigurationSection
    {
        [ConfigurationProperty("VersionToShow")]
        internal string VersionToShow
        {
            get { return (string)this["VersionToShow"]; }
        }

        [ConfigurationProperty("Safe")]
        internal bool Safe
        {
            get { return (bool)this["Safe"]; }
        }
    }
}
