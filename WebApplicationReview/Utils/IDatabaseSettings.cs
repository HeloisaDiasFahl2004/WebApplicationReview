namespace WebApplicationReview.Utils
{
    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string CachorroCollectionName { get; set; }
    }
}
