namespace WebCurrencyConverter.Models
{
    public class Currency
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Code { get; set; }
        
        public decimal Value { get; set; }
    }
}