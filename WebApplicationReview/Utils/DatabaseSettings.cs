namespace WebApplicationReview.Utils
{
    public class DatabaseSettings:IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CachorroCollectionName { get; set; }
    }
}
