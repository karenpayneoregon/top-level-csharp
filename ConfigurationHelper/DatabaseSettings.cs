namespace ConfigurationHelper
{
    /// <summary>
    /// Properties for setting up a SQL-Server connection string
    /// </summary>
    public class DatabaseSettings
    {
        public string DatabaseServer { get; set; }
        public string Catalog { get; set; }
        public bool IntegratedSecurity { get; set; }
        public bool UsingLogging { get; set; }
        public string ConnectionString => $"Data Source={DatabaseServer};" +
                                          $"Initial Catalog={Catalog};" +
                                          $"Integrated Security={IntegratedSecurity}";

    }

}
