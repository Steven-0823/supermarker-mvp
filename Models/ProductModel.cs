using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;


namespace Supermarket_mvp1.Models
{
    internal class ProductModel
    {

        [DisplayName("Product Id")]
        public int id { get; set; }


        [DisplayName("Product Name")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 0, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string name { get; set; }

        

        [DisplayName("Product category")]
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public string categority { get; set; }



        [DisplayName("Price")]
        [Required(ErrorMessage = "Product requires a price")]
        public int precio { get; set; }

        [DisplayName("Stock")]
         public int stock { get; set; }
        
        
        

    }
}
