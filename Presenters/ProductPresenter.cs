using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp1.Views;
using Supermarket_mvp1.Models;


namespace Supermarket_mvp1.Presenters
{
    internal class ProductPresenter
    {
        private IProductView view;
        private IProductRepository repository;
        private BindingSource productBindingSource;
        private IEnumerable<ProductModel> productList;

        public ProductPresenter(IProductView view, IProductRepository repository)
        {
            this.productBindingSource = new BindingSource();

            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchProduct;
            this.view.AddNewEvent += AddNewProduct;
            this.view.EditEvent +=  LoadSelectProductToEdit;
            this.view.DeletEvent += DeleteSelectedProduct;
            this.view.SaveEvent += SaveProduct;
            this.view.CancelEvent += CancelAction;


            this.view.SetProductListBildingSource(productBindingSource);

            loadAllProductList();

            this.view.Show();
        }

        private void loadAllProductList()
        {
            productList = repository.GetAll();
            productBindingSource.DataSource = productList;
        }

        private void SaveProduct(object? sender, EventArgs e)
        {
            var product = new ProductModel();
            product.id = Convert.ToInt32(view.ProductModeId);
            product.name = view.ProductModeName;
            product.categority = view.ProductModecategority;
            product.id = int.Parse(view.ProductModeId);
            try
            {
                new Supermarket_mvp.Presenters.Common.ModelDataValidation().Validate(product);
                if (view.IsEdit)
                {
                    repository.Edit(product);
                    view.Message = "Product edited successfuly";
                }
                else
                {
                    repository.add(product);
                    view.Message = "Product added successfuly";
                }
                view.IsSuccessful = true;
                loadAllProductList();
                CleanViewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.ProductModeId = "0";
            view.ProductModeName = "";
            view.ProductModecategority = "";
           

        }

        private void CancelAction(object? sender, EventArgs e)
        {
            CleanViewFields();
        }

        private void DeleteSelectedProduct(object? sender, EventArgs e)
        {
            try
            {
                
                view.IsSuccessful = true;
                view.Message = "Product deleted successfully";
                loadAllProductList();
            }
            catch
            (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pay mode";
            }
        }

        private void LoadSelectProductToEdit(object? sender, EventArgs e)
        {
            var Product = (ProductModel)productBindingSource.Current;


            view.ProductModeId = Product.id.ToString();
            view.ProductModeName = Product.name;
            view.ProductModecategority = Product.categority;
            view.ProductModePrecio = Product.precio;
            view.ProductModestock = Product.stock;


            view.IsEdit = true;
        }

        private void AddNewProduct(object? sender, EventArgs e)
        {
            view.IsEdit = false;
        }

        private void SearchProduct(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                productList = repository.GetByValue(this.view.SearchValue);
            }
            else
            {
                productList = repository.GetAll();

            }
            productBindingSource.DataSource = productList;
        }
    }
    }

