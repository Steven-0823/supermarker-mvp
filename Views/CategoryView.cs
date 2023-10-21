﻿using System;
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
    public partial class CategoryView : Form, ICategoryView
    {
        private bool isEdit;
        private bool isSuccessful;
        private string message;
        public CategoryView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();

            tabControl1.TabPages.Remove(tabPageCategoryDetail);
            BtnClose.Click += delegate { this.Close(); };
        }

        private void AssociateAndRaiseViewEvents()
        {
            BtnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };

            TxtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    SearchEvent?.Invoke(this, EventArgs.Empty);
                }
            };
            BtnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Add Pay Mode";


            };

            BtnNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabPageCategoryList);
                tabControl1.TabPages.Add(tabPageCategoryDetail);
                tabPageCategoryDetail.Text = "Add Category Mode";


            };



            BtnDelete.Click += delegate
            {
                DeleteEvent?.Invoke(this, EventArgs.Empty);

                var result = MessageBox.Show("Are you sure you want to delete the selected Pay Mode", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }


            };
            BtnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);

                if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabPageCategoryDetail);
                    tabControl1.TabPages.Add(tabPageCategoryList);

                }
                MessageBox.Show(Message);

            };
            BtnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);

                CancelEvent?.Invoke(this, EventArgs.Empty);

                tabControl1.TabPages.Remove(tabPageCategoryDetail);
                tabControl1.TabPages.Add(tabPageCategoryList);
            };

        }

        public string CategoryId
        {
            get { return TxtCategoryId.Text; }

            set { TxtCategoryId.Text = value; }
        }
        public string CategoryObservation
        {
            get { return TxtCategoryObservation.Text; }

            set { TxtCategoryObservation.Text = value; }
        }
        public string SearchValue
        {
            get { return TxtSearch.Text; }
            set { TxtSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccesful
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
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetCategoryListBildingSource(BindingSource categoryList)
        {
            DgCategory.DataSource = categoryList;
        }

        private static CategoryView instance;

        public static CategoryView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new CategoryView();

                instance.MdiParent = parentContainer;

                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }

            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal;
                }
                instance.BringToFront();
            }
            return instance;
        }
    }
}
