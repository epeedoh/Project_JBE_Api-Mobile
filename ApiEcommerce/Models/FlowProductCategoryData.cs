using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcommerce.Models
{
    public class FlowProductCategoryData
    {
        public string Name { get; set; }
        public FlowProductData[] Content { get; set; }
    }
}
