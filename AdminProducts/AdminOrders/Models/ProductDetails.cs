using System.Buffers.Text;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace AdminOrders.Models
{
    public class ProductDetails
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string ProductImageUrl { get; set; }
        public int ProductInStock { get; set; }
    }
}
