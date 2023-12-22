using SQLite;

namespace Fridgynator.Models
{
    public class ProductsModel
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string ImageSource { get; set; }
        public int Quantity { get; set; }
    }
}