using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fridgynator.Models
{
    [Serializable]
    public class ProductsModel
    {
        public string ImageSource { get; set; }
        public string Title { get; set; }
        public int Quantity { get; set; }

        public ProductsModel() { }

    }
}
