using Newtonsoft.Json;

namespace OrderManagement.Contracts.Common
{
    public class Product
    {
        public int Stockcode { get; }
        public string ProductImageUrl { get; }
        public decimal VolumetricWeight { get; }

        [JsonConstructor]
        private Product(int stockcode, string productImageUrl, decimal volumetricWeight)
        {
            Stockcode = stockcode;
            ProductImageUrl = productImageUrl;
            VolumetricWeight = volumetricWeight;
        }

        public static Product Create(int stockcode, string productImageUrl, decimal volumetricWeight)
        {
            return new Product(stockcode, productImageUrl, volumetricWeight);
        }
    }
}
