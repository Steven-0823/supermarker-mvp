using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Supermarket_mvp.Views;
using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;

namespace Supermarket_mvp1.Presenters
{
    internal class ProvidersPresenter
    {
        private IProvidersView view;
        private IProvidersRepository repository;
        private BindingSource providersBindingSource;
        private IEnumerable<ProvidersModel> providersList;

        public ProvidersPresenter(IProvidersView view, IProvidersRepository repository)
        {
            this.providersBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProviders;
            this.view.AddNewEvent += AddNewProviders;
            this.view.EditEvent += LoadSelectProvidersToEdit;
            this.view.DeleteEvent += DeleteSelectedProviders;
            this.view.SaveEvent += SaveProviders;
            this.view.CancelEvent += CancelAction;

            this.view.SetProvidersListBildingSource(providersBindingSource);

            LoadAllProvidersList();

            this.view.Show();


        }

        private void LoadAllProvidersList()
        {
            providersList = repository.GetAll();
            providersBindingSource.DataSource = providersList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {

            CleanViewFields();
        }

        private void SaveProviders(object? sender, EventArgs e)
        {
            var providersMode = new ProvidersModel();
            providersMode.Id = Convert.ToInt32(view.ProvidersId);
            providersMode.Name = view.ProvidersName;
            providersMode.Observation = view.ProvidersObservation;

            try
            {
                new Supermarket_mvp.Presenters.Common.ModelDataValidation().Validate(providersMode);
                if (view.IsEdit)
                {
                    repository.Edit(providersMode);
                    view.Message = "Providers edited successfuly";
                }
                else
                {
                    repository.Add(providersMode);
                    view.Message = "Providers added successfuly";
                }
                view.IsSuccesful = true;
                LoadAllProvidersList();
                CleanViewFields();

            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProvidersId = "0";
            view.ProvidersName = "";
            view.ProvidersObservation = "";
        }

        private void DeleteSelectedProviders(object? sender, EventArgs e)
        {
            try
            {
                var providersMode = (ProvidersModel)providersBindingSource.Current;

                repository.Delete(providersMode.Id);
                view.IsSuccesful = true;
                view.Message = "Providers deleted successfully";
                LoadAllProvidersList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could ot delete category mode";
            }
        }

        private void LoadSelectProvidersToEdit(object? sender, EventArgs e)
        {
            var providersMode = (ProvidersModel)providersBindingSource.Current;

            view.ProvidersId = providersMode.Id.ToString();
            view.ProvidersName = providersMode.Name;
            view.ProvidersObservation = providersMode.Observation;

            view.IsEdit = true;
        }

        private void AddNewProviders(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProviders(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                providersList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                providersList = repository.GetAll();
            }
            providersBindingSource.DataSource = providersList;
        }
    }
}
