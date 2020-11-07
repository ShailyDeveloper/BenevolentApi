using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BenProductsApi.Dto
{
    public class ProductReadDto
    {
        
            public int ID { get; set; }
            public string ProductName { get; set; }
            public int ProductCost { get; set; }
    }
}
