namespace Supermarket_mvp1.Views
{
    partial class ProvidersView
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
            label1 = new Label();
            tabControl1 = new TabControl();
            tabPageProvidersList = new TabPage();
            BtnDelete = new Button();
            BtnClose = new Button();
            BtnEdit = new Button();
            BtnNew = new Button();
            DgProviders = new DataGridView();
            BtnSearch = new Button();
            TxtSearch = new TextBox();
            label2 = new Label();
            tabPageProvidersDetail = new TabPage();
            TxtProvidersObservation = new TextBox();
            TxtProvidersName = new TextBox();
            TxtProvidersId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnCancel = new Button();
            BtnSave = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabPageProvidersList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).BeginInit();
            tabPageProvidersDetail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.providers;
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(149, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(147, 25);
            label1.Name = "label1";
            label1.Size = new Size(128, 27);
            label1.TabIndex = 0;
            label1.Text = "Providers";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageProvidersList);
            tabControl1.Controls.Add(tabPageProvidersDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 100);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 350);
            tabControl1.TabIndex = 1;
            // 
            // tabPageProvidersList
            // 
            tabPageProvidersList.Controls.Add(BtnDelete);
            tabPageProvidersList.Controls.Add(BtnClose);
            tabPageProvidersList.Controls.Add(BtnEdit);
            tabPageProvidersList.Controls.Add(BtnNew);
            tabPageProvidersList.Controls.Add(DgProviders);
            tabPageProvidersList.Controls.Add(BtnSearch);
            tabPageProvidersList.Controls.Add(TxtSearch);
            tabPageProvidersList.Controls.Add(label2);
            tabPageProvidersList.Location = new Point(4, 24);
            tabPageProvidersList.Name = "tabPageProvidersList";
            tabPageProvidersList.Padding = new Padding(3);
            tabPageProvidersList.Size = new Size(792, 322);
            tabPageProvidersList.TabIndex = 0;
            tabPageProvidersList.Text = "Providers List";
            tabPageProvidersList.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            BtnDelete.Image = Properties.Resources.delete;
            BtnDelete.Location = new Point(601, 168);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(183, 64);
            BtnDelete.TabIndex = 7;
            BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnClose
            // 
            BtnClose.Image = Properties.Resources.cerrar;
            BtnClose.Location = new Point(601, 238);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(183, 64);
            BtnClose.TabIndex = 6;
            BtnClose.UseVisualStyleBackColor = true;
            // 
            // BtnEdit
            // 
            BtnEdit.Image = Properties.Resources.edit;
            BtnEdit.Location = new Point(601, 87);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(183, 64);
            BtnEdit.TabIndex = 5;
            BtnEdit.UseVisualStyleBackColor = true;
            // 
            // BtnNew
            // 
            BtnNew.Image = Properties.Resources._new;
            BtnNew.Location = new Point(601, 6);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(183, 64);
            BtnNew.TabIndex = 4;
            BtnNew.UseVisualStyleBackColor = true;
            // 
            // DgProviders
            // 
            DgProviders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DgProviders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DgProviders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgProviders.Location = new Point(8, 68);
            DgProviders.Name = "DgProviders";
            DgProviders.RowTemplate.Height = 25;
            DgProviders.Size = new Size(562, 246);
            DgProviders.TabIndex = 3;
            // 
            // BtnSearch
            // 
            BtnSearch.Image = Properties.Resources.search_small;
            BtnSearch.Location = new Point(495, 6);
            BtnSearch.Name = "BtnSearch";
            BtnSearch.Size = new Size(75, 56);
            BtnSearch.TabIndex = 2;
            BtnSearch.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            TxtSearch.Location = new Point(17, 21);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.PlaceholderText = "Data to Search";
            TxtSearch.Size = new Size(463, 23);
            TxtSearch.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 3);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 0;
            label2.Text = "Search Providers";
            // 
            // tabPageProvidersDetail
            // 
            tabPageProvidersDetail.Controls.Add(TxtProvidersObservation);
            tabPageProvidersDetail.Controls.Add(TxtProvidersName);
            tabPageProvidersDetail.Controls.Add(TxtProvidersId);
            tabPageProvidersDetail.Controls.Add(label5);
            tabPageProvidersDetail.Controls.Add(label4);
            tabPageProvidersDetail.Controls.Add(label3);
            tabPageProvidersDetail.Controls.Add(BtnCancel);
            tabPageProvidersDetail.Controls.Add(BtnSave);
            tabPageProvidersDetail.Location = new Point(4, 24);
            tabPageProvidersDetail.Name = "tabPageProvidersDetail";
            tabPageProvidersDetail.Padding = new Padding(3);
            tabPageProvidersDetail.Size = new Size(792, 322);
            tabPageProvidersDetail.TabIndex = 1;
            tabPageProvidersDetail.Text = "Providers Detail";
            tabPageProvidersDetail.UseVisualStyleBackColor = true;
            // 
            // TxtProvidersObservation
            // 
            TxtProvidersObservation.Location = new Point(22, 162);
            TxtProvidersObservation.Multiline = true;
            TxtProvidersObservation.Name = "TxtProvidersObservation";
            TxtProvidersObservation.PlaceholderText = "Providers Observation ";
            TxtProvidersObservation.Size = new Size(266, 97);
            TxtProvidersObservation.TabIndex = 7;
            // 
            // TxtProvidersName
            // 
            TxtProvidersName.Location = new Point(22, 95);
            TxtProvidersName.Name = "TxtProvidersName";
            TxtProvidersName.PlaceholderText = "Providers Name";
            TxtProvidersName.Size = new Size(266, 23);
            TxtProvidersName.TabIndex = 6;
            // 
            // TxtProvidersId
            // 
            TxtProvidersId.Location = new Point(22, 31);
            TxtProvidersId.Name = "TxtProvidersId";
            TxtProvidersId.Size = new Size(266, 23);
            TxtProvidersId.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 131);
            label5.Name = "label5";
            label5.Size = new Size(123, 15);
            label5.TabIndex = 4;
            label5.Text = "Providers Observation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 67);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 3;
            label4.Text = "Providers Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 13);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 2;
            label3.Text = "Providers ID";
            // 
            // BtnCancel
            // 
            BtnCancel.Image = Properties.Resources.cancel;
            BtnCancel.Location = new Point(549, 95);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(169, 51);
            BtnCancel.TabIndex = 1;
            BtnCancel.UseVisualStyleBackColor = true;
            // 
            // BtnSave
            // 
            BtnSave.Image = Properties.Resources.save;
            BtnSave.Location = new Point(549, 31);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(169, 51);
            BtnSave.TabIndex = 0;
            BtnSave.UseVisualStyleBackColor = true;
            // 
            // ProvidersView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "ProvidersView";
            Text = "Providers Management";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabPageProvidersList.ResumeLayout(false);
            tabPageProvidersList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DgProviders).EndInit();
            tabPageProvidersDetail.ResumeLayout(false);
            tabPageProvidersDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPageProvidersList;
        private TabPage tabPageProvidersDetail;
        private DataGridView DgProviders;
        private Button BtnSearch;
        private TextBox TxtSearch;
        private Label label2;
        private Button BtnDelete;
        private Button BtnClose;
        private Button BtnEdit;
        private Button BtnNew;
        private Label label3;
        private Button BtnCancel;
        private Button BtnSave;
        private TextBox TxtProvidersObservation;
        private TextBox TxtProvidersName;
        private TextBox TxtProvidersId;
        private Label label5;
        private Label label4;
    }
}