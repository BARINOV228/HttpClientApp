using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpCRUD
{
    public class ProductForCreationDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public long? CategoryId { get; set; }

        //public IFormFile? File { get; set; }
    }
}
