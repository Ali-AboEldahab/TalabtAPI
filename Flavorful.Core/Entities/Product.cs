﻿namespace Flavorful.Core.Entities
{
    public class Product : BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public string? PictureUrl { get; set; }

        public int? BrandId { get; set; } //FK
        public ProductBrand? Brand { get; set; } //Nav Prob [One]
        public int? CategoryId { get; set; } //FK
        public ProductCategory? Category { get; set; } //Nav Prob [One]
    }
}
