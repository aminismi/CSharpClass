namespace View
{
    partial class frmPerson
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
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBack = new Button();
            dataGridViewPerson = new DataGridView();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            CheckBox = new DataGridViewCheckBoxColumn();
            personFirstName = new DataGridViewTextBoxColumn();
            personLastName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerson).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(773, 20);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(188, 52);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(773, 183);
            btnEdit.Margin = new Padding(2);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(188, 52);
            btnEdit.TabIndex = 2;
            btnEdit.Text = "edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(773, 99);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(188, 52);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(773, 257);
            btnRefresh.Margin = new Padding(2);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(188, 52);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(773, 338);
            btnBack.Margin = new Padding(2);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(188, 52);
            btnBack.TabIndex = 5;
            btnBack.Text = "close page";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // dataGridViewPerson
            // 
            dataGridViewPerson.AllowDrop = true;
            dataGridViewPerson.AllowUserToAddRows = false;
            dataGridViewPerson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPerson.Columns.AddRange(new DataGridViewColumn[] { CheckBox, personFirstName, personLastName });
            dataGridViewPerson.Location = new Point(19, 99);
            dataGridViewPerson.Margin = new Padding(2);
            dataGridViewPerson.Name = "dataGridViewPerson";
            dataGridViewPerson.RowHeadersVisible = false;
            dataGridViewPerson.RowHeadersWidth = 82;
            dataGridViewPerson.Size = new Size(686, 291);
            dataGridViewPerson.TabIndex = 6;
            dataGridViewPerson.CellContentClick += dataGridViewPerson_CellContentClick;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(19, 23);
            lblFirstName.Margin = new Padding(2, 0, 2, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(101, 25);
            lblFirstName.TabIndex = 7;
            lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(384, 26);
            lblLastName.Margin = new Padding(2, 0, 2, 0);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(99, 25);
            lblLastName.TabIndex = 8;
            lblLastName.Text = "Last Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(137, 20);
            txtFirstName.Margin = new Padding(2);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(155, 31);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(550, 23);
            txtLastName.Margin = new Padding(2);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 31);
            txtLastName.TabIndex = 1;
            // 
            // CheckBox
            // 
            CheckBox.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CheckBox.FillWeight = 73.71795F;
            CheckBox.HeaderText = "";
            CheckBox.MinimumWidth = 10;
            CheckBox.Name = "CheckBox";
            CheckBox.Width = 50;
            // 
            // personFirstName
            // 
            personFirstName.FillWeight = 106.570511F;
            personFirstName.HeaderText = "First Name";
            personFirstName.MinimumWidth = 10;
            personFirstName.Name = "personFirstName";
            // 
            // personLastName
            // 
            personLastName.FillWeight = 106.570511F;
            personLastName.HeaderText = "Last Name";
            personLastName.MinimumWidth = 10;
            personLastName.Name = "personLastName";
            // 
            // frmPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1111, 446);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(dataGridViewPerson);
            Controls.Add(btnBack);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Margin = new Padding(2);
            Name = "frmPerson";
            Text = "PersonForm";
            Load += frmPerson_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnBack;
        private DataGridView dataGridViewPerson;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridViewCheckBoxColumn CheckBox;
        private DataGridViewTextBoxColumn personFirstName;
        private DataGridViewTextBoxColumn personLastName;
    }
}