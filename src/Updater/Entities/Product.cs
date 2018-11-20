using System;

namespace Updater.Entities
{
    public class Product
    {
        public int Number { get; set; }

        public int ProductId { get; set; }

        public int ProductNumber { get; set; }

        public string Name { get; set; }

        public string Name2 { get; set; }

        public decimal Price { get; set; }

        public decimal Size { get; set; }

        public decimal PricePerLitre { get; set; }

        public DateTime StartOfSale { get; set; }

        public bool Discontinued { get; set; }

        public string ProductGroup { get; set; }

        public string Type { get; set; }

        public string Style { get; set; }

        public string Packaging { get; set; }

        public string Seal { get; set; }

        public string Origin { get; set; }

        public string CountryOfOrigin { get; set; }

        public string Producer { get; set; }

        public string Supplier { get; set; }

        public int Year { get; set; }

        public int YearTested { get; set; }

        public string Alcohol { get; set; }

        public string Assortment { get; set; }

        public string AssortmentText { get; set; }

        public bool Ecological { get; set; }

        public bool Ethically { get; set; }

        public bool Koscher { get; set; }
        
        public string RawMaterialDescription { get; set; }
    }
}