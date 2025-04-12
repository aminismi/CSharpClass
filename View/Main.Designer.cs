namespace View
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPerson = new Button();
            btnProduct = new Button();
            SuspendLayout();
            // 
            // btnPerson
            // 
            btnPerson.Location = new Point(513, 39);
            btnPerson.Margin = new Padding(2, 2, 2, 2);
            btnPerson.Name = "btnPerson";
            btnPerson.Size = new Size(371, 88);
            btnPerson.TabIndex = 0;
            btnPerson.TabStop = false;
            btnPerson.Text = "person";
            btnPerson.UseVisualStyleBackColor = true;
            btnPerson.Click += btnPerson_Click;
            // 
            // btnProduct
            // 
            btnProduct.Location = new Point(42, 39);
            btnProduct.Margin = new Padding(2, 2, 2, 2);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(392, 88);
            btnProduct.TabIndex = 1;
            btnProduct.TabStop = false;
            btnProduct.Text = "product";
            btnProduct.UseVisualStyleBackColor = true;
            btnProduct.Click += button2_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 213);
            Controls.Add(btnProduct);
            Controls.Add(btnPerson);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmMain";
            Text = "MainForm";
            Load += frmMain_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnPerson;
        private Button btnProduct;
    }
}