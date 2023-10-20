namespace Supermarket_mvp1.Views
{
    partial class ProductView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            LblTitulo = new Label();
            tabControl1 = new TabControl();
            tabPageProductList = new TabPage();
            BtnClose = new Button();
            BtnDelete = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProduct = new DataGridView();
            BtnSearchP = new Button();
            TxtSearchP = new TextBox();
            label1 = new Label();
            tabPageProductDetail = new TabPage();
            TxtProductStock = new TextBox();
            label6 = new Label();
            TxtProductPrice = new TextBox();
            label5 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            TxtProducCategory = new TextBox();
            label4 = new Label();
            TxtProductName = new TextBox();
            label3 = new Label();
            TxtProductId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).BeginInit();
            tabPageProductDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(LblTitulo);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.products;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 94);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.Location = new Point(119, 9);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(121, 27);
            LblTitulo.TabIndex = 0;
            LblTitulo.Text = "Products";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProductList);
            tabControl1.Controls.Add(tabPageProductDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProductList
            // 
            tabPageProductList.Controls.Add(BtnClose);
            tabPageProductList.Controls.Add(BtnDelete);
            tabPageProductList.Controls.Add(BtnEdit);
            tabPageProductList.Controls.Add(BtnNew);
            tabPageProductList.Controls.Add(DgProduct);
            tabPageProductList.Controls.Add(BtnSearchP);
            tabPageProductList.Controls.Add(TxtSearchP);
            tabPageProductList.Controls.Add(label1);
            tabPageProductList.Location = new Point(4, 24);
            tabPageProductList.Name = "tabPageProductList";
            tabPageProductList.Padding = new Padding(3);
            tabPageProductList.Size = new Size(792, 322);
            tabPageProductList.TabIndex = 0;
            tabPageProductList.Text = "Product List";
            tabPageProductList.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(629, 260);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(155, 54);
            BtnClose.TabIndex = 7;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(629, 184);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(155, 54);
            BtnDelete.TabIndex = 6;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(629, 100);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(155, 54);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(629, 21);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(155, 54);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProduct
            // 
            DgProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProduct.Location = new Point(8, 76);
            DgProduct.Name = "DgProduct";
            DgProduct.RowTemplate.Height = 25;
            DgProduct.Size = new Size(592, 238);
            DgProduct.TabIndex = 3;
            // 
            // BtnSearchP
            // 
            BtnSearchP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnSearchP.Image = Properties.Resources.search_small;
            BtnSearchP.ImageAlign = ContentAlignment.TopCenter;
            BtnSearchP.Location = new Point(538, 21);
            BtnSearchP.Name = "BtnSearchP";
            BtnSearchP.Size = new Size(62, 41);
            BtnSearchP.TabIndex = 2;
            BtnSearchP.UseVisualStyleBackColor = true;
            // 
            // TxtSearchP
            // 
            TxtSearchP.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TxtSearchP.Location = new Point(8, 31);
            TxtSearchP.Name = "TxtSearchP";
            TxtSearchP.PlaceholderText = "Data To Search";
            TxtSearchP.Size = new Size(524, 23);
            TxtSearchP.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 13);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Product";
            // 
            // tabPageProductDetail
            // 
            tabPageProductDetail.Controls.Add(TxtProductStock);
            tabPageProductDetail.Controls.Add(label6);
            tabPageProductDetail.Controls.Add(TxtProductPrice);
            tabPageProductDetail.Controls.Add(label5);
            tabPageProductDetail.Controls.Add(BtnCancel);
            tabPageProductDetail.Controls.Add(BtnSave);
            tabPageProductDetail.Controls.Add(TxtProducCategory);
            tabPageProductDetail.Controls.Add(label4);
            tabPageProductDetail.Controls.Add(TxtProductName);
            tabPageProductDetail.Controls.Add(label3);
            tabPageProductDetail.Controls.Add(TxtProductId);
            tabPageProductDetail.Controls.Add(label2);
            tabPageProductDetail.Location = new Point(4, 24);
            tabPageProductDetail.Name = "tabPageProductDetail";
            tabPageProductDetail.Padding = new Padding(3);
            tabPageProductDetail.Size = new Size(792, 322);
            tabPageProductDetail.TabIndex = 1;
            tabPageProductDetail.Text = "Product Detail";
            tabPageProductDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProductStock
            // 
            TxtProductStock.Location = new Point(405, 110);
            TxtProductStock.Name = "TxtProductStock";
            TxtProductStock.Size = new Size(269, 23);
            TxtProductStock.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(405, 80);
            label6.Name = "label6";
            label6.Size = new Size(81, 15);
            label6.TabIndex = 10;
            label6.Text = "Stock Product";
            // 
            // TxtProductPrice
            // 
            TxtProductPrice.Location = new Point(405, 40);
            TxtProductPrice.Name = "TxtProductPrice";
            TxtProductPrice.Size = new Size(267, 23);
            TxtProductPrice.TabIndex = 9;
            TxtProductPrice.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(405, 12);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 8;
            label5.Text = "Price Product";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(562, 206);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(110, 57);
            BtnCancel.TabIndex = 7;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(405, 206);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(110, 57);
            BtnSave.TabIndex = 6;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // TxtProducCategory
            // 
            TxtProducCategory.Location = new Point(8, 182);
            TxtProducCategory.Multiline = true;
            TxtProducCategory.Name = "TxtProducCategory";
            TxtProducCategory.PlaceholderText = "Product Category";
            TxtProducCategory.Size = new Size(267, 121);
            TxtProducCategory.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(8, 153);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 4;
            label4.Text = "Product Category";
            // 
            // TxtProductName
            // 
            TxtProductName.Location = new Point(8, 110);
            TxtProductName.Name = "TxtProductName";
            TxtProductName.Size = new Size(267, 23);
            TxtProductName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 80);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 2;
            label3.Text = "Product Name";
            // 
            // TxtProductId
            // 
            TxtProductId.Location = new Point(8, 40);
            TxtProductId.Name = "TxtProductId";
            TxtProductId.Size = new Size(267, 23);
            TxtProductId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 12);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "Product ID";
            // 
            // ProductView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProductView";
            Text = "Product Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProductList.ResumeLayout(false);
            tabPageProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProduct).EndInit();
            tabPageProductDetail.ResumeLayout(false);
            tabPageProductDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label LblTitulo;
        private TabControl tabControl1;
        private TabPage tabPageProductList;
        private TabPage tabPageProductDetail;
        private Button BtnSearchP;
        private TextBox TxtSearchP;
        private Label label1;
        private Button BtnClose;
        private Button BtnDelete;
        private Button BtnEdit;
        private Button BtnNew;
        private DataGridView DgProduct;
        private Label label3;
        private TextBox TxtProductId;
        private Label label2;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProducCategory;
        private Label label4;
        private TextBox TxtProductName;
        private TextBox TxtProductPrice;
        private Label label5;
        private TextBox TxtProductStock;
        private Label label6;
    }
}