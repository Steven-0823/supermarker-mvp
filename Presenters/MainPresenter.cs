
using Supermarket_mvp._Repositories;
using Supermarket_mvp.Models;
using Supermarket_mvp.Presenters;
using Supermarket_mvp.Views;
using Supermarket_mvp1._Repositories;
using Supermarket_mvp1.Models;
using Supermarket_mvp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket_mvp1.Presenters
{
    internal class MainPresenter
    {
        private readonly IMainView mainView;
        private readonly string sqlConnectionString;
        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.sqlConnectionString = sqlConnectionString;

            this.mainView.ShowPayModeView += ShowPayModeView;
            this.mainView.ShowProductView += ShowProductView;

            this.mainView.ShowCategoryView += ShowCategoryView;
            this.mainView.ShowCategoryView += ShowProvidersView;




        }

        private void ShowProvidersView(object? sender, EventArgs e)
        {
            IProvidersView view = new ProvidersView();

            IProvidersRepository repository = new ProvidersRepository(sqlConnectionString);
            new ProvidersPresenter(view, repository);
        }

        private void ShowCategoryView(object? sender, EventArgs e)
        {


            ICategoryView view = CategoryView.GetInstance((MainView)mainView);

            ICategoryRepository repository = new CategoryRepository(sqlConnectionString);
            new CategoryPresenter(view, repository);

        }

        private void ShowProductView(object? sender, EventArgs e)
        {

            IProductView view = ProductView.GetInstance((MainView)mainView);

            IProductRepository repository = new ProductRepository(sqlConnectionString);
            new ProductPresenter(view, repository);
           
        }

        private void ShowPayModeView(object? sender, EventArgs e)
        {
            IPayModeView view = PayModeView.GetInstance((MainView)mainView);
            IPayModeRepository repository = new PayModeRepository(sqlConnectionString);
            new PayModePresenter(view, repository);

        }
    }
    
}
