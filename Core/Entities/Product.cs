namespace Core.Entities
{
    public class Product : BaseEntity
    {
        // // public readonly object Id;

        // public string Name { get; set; }

        // public int Description { get; set; }

        // public decimal Price { get; set; }

        // public string PictureUrl { get; set; }

        // // EF knows that this is a navigation property and will create a foreign key in the database
        // public ProductType ProductType { get; set; }

        // // EF will create a column in the database called ProductTypeId relation to the ProductType table
        // public int ProductTypeId { get; set; }

        // // EF will create a column in the database called ProductBrandId relation to the ProductBrand table
        // public ProductBrand ProductBrand { get; set; }

        // // EF will create a column in the database called ProductBrandId relation to the ProductBrand table
        // public int ProductBrandId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string PictureUrl { get; set; }
        public ProductType ProductType { get; set; }
        public int ProductTypeId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public int ProductBrandId { get; set; }

    }
}