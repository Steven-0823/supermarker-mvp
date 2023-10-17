using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Supermarket_mvp1.Models
{
    internal class PayModeModel
    {
        [DisplayName("Pay Mode Id")]
        public int id { get; set; }


        [DisplayName("Pay Mode Name")]
        [Required(ErrorMessage ="Pay mode name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage = "Pay mode name must be between 3 and 50 characters")]
        public String name { get; set; }


        [DisplayName("Observation")]
        [Required(ErrorMessage = "Pay mode observation is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Pay mode obtervation must be between 3 and 50 characters")]
        public string observation { get; set; }
    }
}
