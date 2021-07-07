namespace ConfigurationHelper
{
    /// <summary>
    /// Container for parts for a SQL-Server connection string
    /// </summary>
    public class ApplicationSettings
    {
        public string DatabaseServer { get; set; }
        public string Catalog { get; set; }
        public bool IntegratedSecurity { get; set; }
        /// <summary>
        /// Indicates to using Entity Framework logging
        /// </summary>
        public bool UsingLogging { get; set; }
    }

}
