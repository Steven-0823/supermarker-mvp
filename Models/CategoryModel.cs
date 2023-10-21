using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp1.Models
{
    internal class CategoryModel
    {
        [DisplayName("  Category  Id")]
        public int Id { get; set; }


        [DisplayName("Observation")]
        [Required(ErrorMessage = "Category observation is required")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Category observation must" +
                  " be between 3 and 200 characters")]
        public string observation { get; set; }
    }
}
