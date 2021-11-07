using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcommerce.Models
{
    public class FlowProductData
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public bool IsFavorite { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Rating { get; set; }
        public int[] Quantities { get; set; } = new int[] { 1, 2, 3, 4, 5 };
        public int SelectedQuantity { get; set; } = 1;
        public FlowProductData[] RelatedProducts { get; set; }
        public ColorsData[] AvailableColors { get; set; }
        public ReviewsData Reviews { get; set; }
    }
}
