namespace View
{
    partial class frmProduct
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
            btnBack = new Button();
            btnRefresh = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnAdd = new Button();
            dataGridViewProduct = new DataGridView();
            CheckBox = new DataGridViewCheckBoxColumn();
            productTitle = new DataGridViewTextBoxColumn();
            productUnitPrice = new DataGridViewTextBoxColumn();
            productQuantity = new DataGridViewTextBoxColumn();
            lblTitle = new Label();
            lblUnitPrice = new Label();
            lblQuantity = new Label();
            txtTitle = new TextBox();
            txtUnitPrice = new TextBox();
            txtQuantity = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(635, 376);
            btnBack.Margin = new Padding(2, 2, 2, 2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(262, 52);
            btnBack.TabIndex = 9;
            btnBack.Text = "close page";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(635, 304);
            btnRefresh.Margin = new Padding(2, 2, 2, 2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(262, 52);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(635, 173);
            btnDelete.Margin = new Padding(2, 2, 2, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(262, 52);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(635, 238);
            btnEdit.Margin = new Padding(2, 2, 2, 2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(262, 52);
            btnEdit.TabIndex = 6;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(635, 109);
            btnAdd.Margin = new Padding(2, 2, 2, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(262, 52);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AllowDrop = true;
            dataGridViewProduct.AllowUserToAddRows = false;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { CheckBox, productTitle, productUnitPrice, productQuantity });
            dataGridViewProduct.Location = new Point(26, 109);
            dataGridViewProduct.Margin = new Padding(2, 2, 2, 2);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.RowHeadersVisible = false;
            dataGridViewProduct.RowHeadersWidth = 82;
            dataGridViewProduct.Size = new Size(547, 319);
            dataGridViewProduct.TabIndex = 10;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            // 
            // CheckBox
            // 
            CheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CheckBox.HeaderText = "";
            CheckBox.MinimumWidth = 10;
            CheckBox.Name = "CheckBox";
            CheckBox.ReadOnly = true;
            CheckBox.Width = 50;
            // 
            // productTitle
            // 
            productTitle.HeaderText = "Title";
            productTitle.MinimumWidth = 10;
            productTitle.Name = "productTitle";
            productTitle.ReadOnly = true;
            // 
            // productUnitPrice
            // 
            productUnitPrice.HeaderText = "UnitPrice";
            productUnitPrice.MinimumWidth = 10;
            productUnitPrice.Name = "productUnitPrice";
            productUnitPrice.ReadOnly = true;
            // 
            // productQuantity
            // 
            productQuantity.HeaderText = "Quantity";
            productQuantity.MinimumWidth = 10;
            productQuantity.Name = "productQuantity";
            productQuantity.ReadOnly = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(26, 35);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(49, 25);
            lblTitle.TabIndex = 12;
            lblTitle.Text = "TItle:";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Location = new Point(313, 35);
            lblUnitPrice.Margin = new Padding(2, 0, 2, 0);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(90, 25);
            lblUnitPrice.TabIndex = 13;
            lblUnitPrice.Text = "Unit Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(635, 38);
            lblQuantity.Margin = new Padding(2, 0, 2, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(84, 25);
            lblQuantity.TabIndex = 14;
            lblQuantity.Text = "Quantity:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(107, 29);
            txtTitle.Margin = new Padding(2, 2, 2, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(155, 31);
            txtTitle.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(429, 32);
            txtUnitPrice.Margin = new Padding(2, 2, 2, 2);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(155, 31);
            txtUnitPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(742, 29);
            txtQuantity.Margin = new Padding(2, 2, 2, 2);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(155, 31);
            txtQuantity.TabIndex = 3;
            // 
            // frmProduct
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 487);
            Controls.Add(txtQuantity);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtTitle);
            Controls.Add(lblQuantity);
            Controls.Add(lblUnitPrice);
            Controls.Add(lblTitle);
            Controls.Add(dataGridViewProduct);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmProduct";
            Text = "ProductForm";
            Load += frmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Button btnRefresh;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnAdd;
        private DataGridView dataGridViewProduct;
        private Label lblTitle;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private TextBox txtTitle;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private DataGridViewCheckBoxColumn CheckBox;
        private DataGridViewTextBoxColumn productTitle;
        private DataGridViewTextBoxColumn productUnitPrice;
        private DataGridViewTextBoxColumn productQuantity;
    }
}