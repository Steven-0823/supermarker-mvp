using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermarket_mvp1.Views
{
    public partial class ProductView : Form, IProductView
    {
        public ProductView()
        {

            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchP.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearchP.KeyDown += (s, e) =>
                 {
                     if (e.KeyCode == Keys.Enter)
                     {
                         SearchEvent?.Invoke(this, EventArgs.Empty);
                     }
                 };
        }

        public string ProductModeId

        {

            get { return TxtProductId.Text; }
            set { TxtProductId.Text = value; }

        }

        public string ProductModeName
        {
            get { return TxtProductName.Text; }
            set { TxtProductName.Text = value; }

        }


        public int ProductModePrecio
        {
            get { return int.Parse(TxtProductPrice.Text); }
            set { TxtProductPrice.Text = value.ToString(); }
        }


        public string ProductModecategority
        {
            get { return TxtProducCategory.Text; }
            set { TxtProducCategory.Text = value; }
        }


        public int ProductModestock
        {
            get { return int.Parse(TxtProductStock.Text); }
            set { TxtProductStock.Text = value.ToString(); }
        }


        public string SearchValue
        {
            get { return TxtSearchP.Text; }
            set { TxtSearchP.Text = value; }
        }
        public bool IsEdit
        {
            get { return IsEdit; }
            set { IsEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return IsSuccessful; }
            set { IsSuccessful = value; }
        }
        public string Message
        {
            get { return Message; }
            set { Message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeletEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void SetProductListBildingSource(BindingSource productModeList)
        {
            DgProduct.DataSource = productModeList;
        }

        private static ProductView instance;

        public static ProductView GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
            }
            else
            {
                if (instance.IsMdiContainer)
                {
                    foreach (Form child in instance.MdiChildren)
                    {
                        child.WindowState = FormWindowState.Normal;
                        child.BringToFront();
                    }
                }
                else
                {
                    instance.WindowState = FormWindowState.Normal;
                    instance.BringToFront();
                }
            }
            return instance;
        }



    }
}
