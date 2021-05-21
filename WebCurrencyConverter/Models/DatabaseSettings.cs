namespace WebCurrencyConverter.Models
{
    public interface IDatabaseSettings
    {
        string SimpleCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        
    }
    
    public class DatabaseSettings : IDatabaseSettings
    {
        public string SimpleCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}