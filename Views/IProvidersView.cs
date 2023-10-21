using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Views
{
    internal interface IProvidersView

    {
        string ProvidersId { get; set; }
        string ProvidersName { get; set; }
        string ProvidersObservation { get; set; }
        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccesful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;

        void SetProvidersListBildingSource(BindingSource providersList);
        void Show();
    }
}
