using System;
using System.Collections.Generic;
using WebCurrencyConverter.Models;

namespace WebCurrencyConverter.Services
{
    public class CurrencyService
    {
        public CurrencyService()
        {
            
        }

        public IEnumerable<Currency> List()
        {
            try
            {
                var currencies = new[]
                {
                    new Currency
                    {
                        Id = 1,
                        Name = "American Dollar",
                        Code = "USD",
                        Value = 1
                    }
                };

                return currencies;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}