using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp1.Views;
using Supermarket_mvp1.Models;



namespace Supermarket_mvp1.Presenters
{
    internal class CategoryPresenter
    {
        private ICategoryView view;
        private ICategoryRepository repository;
        private BindingSource categoryBindingSource;
        private IEnumerable<CategoryModel> categorytList;

        public CategoryPresenter(ICategoryView view, ICategoryRepository repository)
        {
            this.categoryBindingSource = new BindingSource();


            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchCategory;
            this.view.AddNewEvent += AddNewCategoryt;
            this.view.EditEvent += LoadSelectCategoryToEdit;
            this.view.DeleteEvent += DeleteSelectedCategory;
            this.view.SaveEvent += SavePCategory;
            this.view.CancelEvent += CancelAction;

            this.view.SetCategoryListBildingSource(categoryBindingSource);

            loadAllCategoryList();

            this.view.Show();

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void SavePCategory(object? sender, EventArgs e)
        {
            var categoryMode = new CategoryModel();
            categoryMode.Id = Convert.ToInt32(view.CategoryId);

            categoryMode.observation = view.CategoryObservation;

            try
            {
                new Supermarket_mvp.Presenters.Common.ModelDataValidation().Validate(categoryMode);
                if (view.IsEdit)
                {
                    repository.Edit(categoryMode);
                    view.Message = "Category edited successfuly";
                }
                else
                {
                    repository.Add(categoryMode);
                    view.Message = "Category added successfuly";
                }
                view.IsSuccesful = true;
                loadAllCategoryList();
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
            view.CategoryId = "0";
            view.CategoryObservation = "";
        }

        private void DeleteSelectedCategory(object? sender, EventArgs e)
        {
            try
            {
                var categoryMode = (CategoryModel)categoryBindingSource.Current;

                repository.Delete(categoryMode.Id);
                view.IsSuccesful = true;
                view.Message = "Category deleted successfully";
                loadAllCategoryList();
            }
            catch (Exception ex)
            {
                view.IsSuccesful = false;
                view.Message = "An error ocurred, could ot delete category mode";
            }
        }

        private void LoadSelectCategoryToEdit(object? sender, EventArgs e)
        {
            var categoryMode = (CategoryModel)categoryBindingSource.Current;

            view.CategoryId = categoryMode.Id.ToString();
            view.CategoryObservation = categoryMode.observation;

            view.IsEdit = true;
        }

        private void AddNewCategoryt(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void loadAllCategoryList()
        {
            categorytList = repository.GetAll();
            categoryBindingSource.DataSource = categorytList;
        }

        
        private void SearchCategory(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                categorytList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                categorytList = repository.GetAll();

            }
            categoryBindingSource.DataSource = categorytList;
        }
    }
}
