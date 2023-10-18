using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;

namespace Supermarket_mvp1.Presenters
{
    internal class PayModePresenter
    {
        private IPayModeView view;
        private IPayModeRepository repository;
        private BindingSource payModeBindingSource;
        private IEnumerable<PayModeModel> payModeList;

        public PayModePresenter(IPayModeView view, IPayModeRepository repository)
        {
            this.payModeBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchPayMode;
            this.view.AddNewEvent += AddNewPayMode;

            this.view.EditEvent += LoadSelectedPayModeToEdit;
            this.view.DeletEvent += DelectSelectedPayMode;
            this.view.SaveEvent += SavePayMode;
            this.view.CancelEvent += CancelAction;

            this.view.SetPayModeListBildingSource(payModeBindingSource);

            loadAllPayModeList();

            this.view.Show();
        }

        private void loadAllPayModeList()
        {

            payModeList = repository.GetAll();
            payModeBindingSource.DataSource = payModeList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePayMode(object? sender, EventArgs e)
        {
            var payMode = new PayModeModel();
            payMode.id = Convert.ToInt32(payMode.id);
            payMode.name = view.PayModeName;
            payMode.observation = view.PayModeObservation;

            try
            {
                new Common.ModelDataValidation().validate(payMode);
                if (view.IsEdit)
                {
                    repository.edit(payMode);
                    view.Message = "Pay Mode edited successfuly";
                }
                else
                {

                    repository.edit(payMode);
                    view.Message = "Pay Mode added successfuly";
                }
                view.IsSuccessful = true;
                loadAllPayModeList();
                CleanViewFields();
            }
            catch(Exception ex) 
            {
            view.IsSuccessful = false;
                view.Message = ex.Message;
            }


        }

        private void CleanViewFields()
        {
            view.PayModeId = "0";
            view.PayModeName = "";
            view.PayModeObservation = "";
        }

        private void DelectSelectedPayMode(object? sender, EventArgs e)
        {
            try
            {
                // Se recupera el objeto de la fila seleccionada del dataviewgrid var payMode = (PayModeModel) payModeBindingSource.Current;
                // se invoca el método Delete del repositorio pasandole el ID del Pay Mode repository.Delete(payMode.Id);
                view.IsSuccessful = true;
                view.Message = "Pay Mode deleted successfully";
                loadAllPayModeList(); 
            }
            catch 
            (Exception ex)
            { 
            view.IsSuccessful = false;
            view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectedPayModeToEdit(object? sender, EventArgs e)
        {
            var payMode = (PayModeModel)payModeBindingSource.Current;


            view.PayModeId=payMode.id.ToString();
            view.PayModeName=payMode.name;
            view.PayModeObservation=payMode.observation;


            view.IsEdit = true;
        }

        private void AddNewPayMode(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchPayMode(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false) { 
                payModeList = repository.GetByValue(this.view.SearchValue);
        }
            else
        {
                payModeList = repository.GetAll();
            
        }
            payModeBindingSource.DataSource = payModeList;
        }
    }
}
