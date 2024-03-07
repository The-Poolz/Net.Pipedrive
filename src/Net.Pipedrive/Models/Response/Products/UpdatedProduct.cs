using System.Collections.Generic;

namespace Net.Pipedrive
{
    public class UpdatedProduct : AbstractProduct
    {
        public List<ProductPrice> Prices { get; set; }
    }
}
