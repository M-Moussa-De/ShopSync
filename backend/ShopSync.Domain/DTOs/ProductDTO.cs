namespace ShopSync.Domain.DTOs
{
    public class ProductDTO : BaseEntityDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string BriefDescription { get; set; }
        public long Price { get; set; }
        public string Image { get; set; }
        public string Brand { get; set; }
        public int Quantity { get; set; }
    }
}