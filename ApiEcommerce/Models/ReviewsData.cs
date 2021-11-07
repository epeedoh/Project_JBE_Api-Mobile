using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiEcommerce.Models
{
    public class ReviewsData
    {
        public ReviewData[] List { get; set; }
        public int Count { get; set; }

        public class ReviewData
        {
            public string Title { get; set; }
            public string Reviewer { get; set; }
            public double RatingValue { get; set; }
            public double RatingMax { get; set; }
            public string Date { get; set; }
            public string Comment { get; set; }
        }
    }
}
