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
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public ProductView()
        {

            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl1.TabPages.Remove(tabPageProductDetail);

            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearchP.Click += delegate
            {
                SearchEvent?.Invoke(this, EventArgs.Empty);
                TxtSearchP.KeyDown += (s, e) =>
                {
                    if (e.KeyCode == Keys.Enter)
                    {
                        SearchEvent?.Invoke(this, EventArgs.Empty);
                    }
                };
            };



            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                AddNewEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add New Pay Mode";

            };



            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductList);
                tabControl1.TabPages.Add(tabPageProductDetail);
                tabPageProductDetail.Text = "Add Product";
            };



            BtnDelete.Click += delegate
            {
                DeletEvent?.Invoke(this, EventArgs.Empty);

                DeletEvent?.Invoke(this, EventArgs.Empty);
                var result = MessageBox.Show("Are you sure you want to delete the selected Pay Mode", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeletEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }


            };



            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageProductDetail);
                    tabControl1.TabPages.Add(tabPageProductList);

                }
                MessageBox.Show(Message);
            };




            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageProductDetail);
                tabControl1.TabPages.Add(tabPageProductList);

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
            get { return isEdit; }
            set { isEdit = value; }
        }

        public bool IsSuccessful
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }

        public string Message
        {
            get { return message; }
            set { message = value; }

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

        public static ProductView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ProductView();
                instance.MdiParent = parentContainer;


                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
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
