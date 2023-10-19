using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Views
{
    internal interface IProductView
    {
        string ProductModeId { get; set; }
        string ProductModeName { get; set; }
        int ProductModePrecio { get; set; }
        string ProductModecategority { get; set; }
        int ProductModestock { get; set; }


        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeletEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProductListBildingSource(BindingSource productModeList);
        void Show();
    }
}
