using Model;
using Model.DomainModels;
using Service;

namespace View
{
    public partial class frmProduct : Form
    {
        private readonly ProductService _productService;
        private int selectedProductId = -1;
        private int selectedRowIndex = -1;

        public frmProduct(ProductService productService)
        {
            InitializeComponent();
            _productService = productService;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
        }






        private void btnDelete_Click(object sender, EventArgs e)
        {

            using (var db = new FinalProjectDbContext())
            {
                List<Product> productsToDelete = new List<Product>();

                foreach (DataGridViewRow row in dataGridViewProduct.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value))
                    {
                        string title = row.Cells[1].Value?.ToString();
                        var product = db.Product.FirstOrDefault(p => p.Title == title);
                        if (product != null)
                        {
                            productsToDelete.Add(product);
                        }
                    }
                }

                if (productsToDelete.Count > 0)
                {
                    db.Product.RemoveRange(productsToDelete);
                    db.SaveChanges();
                    LoadData();
                }
                ClearFields();
                UpdateTextBoxes();
                UpdateButtonStates();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            using (var db = new FinalProjectDbContext())
            {
                Product newProduct = new Product
                {
                    Title = txtTitle.Text
                };

                bool isValid = true;

                if (string.IsNullOrWhiteSpace(txtTitle.Text))
                {
                    MessageBox.Show("Please enter a valid title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    newProduct.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter only numbers in unit price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }

                try
                {
                    newProduct.Quantity = Convert.ToInt32(txtQuantity.Text);
                }
                catch
                {
                    MessageBox.Show("Please enter only numbers in quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isValid = false;
                }

                if (isValid)
                {
                    db.Product.Add(newProduct);
                    db.SaveChanges();
                    LoadData();
                }
                ClearFields();
                UpdateTextBoxes();
                UpdateButtonStates();
            }
        }
        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.RowIndex < 0) return;

            DataGridViewRow dgvProduct = dataGridViewProduct.Rows[e.RowIndex];

            txtTitle.Text = dgvProduct.Cells[1].Value?.ToString();
            txtUnitPrice.Text = dgvProduct.Cells[2].Value?.ToString();
            txtQuantity.Text = dgvProduct.Cells[3].Value?.ToString();

            selectedRowIndex = e.RowIndex;

            if (e.ColumnIndex == 0)
            {
                DataGridViewCheckBoxCell checkBoxCell = (DataGridViewCheckBoxCell)dgvProduct.Cells[0];
                checkBoxCell.Value = !(checkBoxCell.Value != null && (bool)checkBoxCell.Value);
                dataGridViewProduct.EndEdit();
                UpdateButtonStates();
                UpdateTextBoxes();
            }
        }
        private void UpdateTextBoxes()
        {
            int selectedCount = 0;
            DataGridViewRow selectedRow = null;

            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                DataGridViewCheckBoxCell checkBox = row.Cells[0] as DataGridViewCheckBoxCell;
                if (checkBox != null && checkBox.Value != null && (bool)checkBox.Value)
                {
                    selectedCount++;
                    if (selectedCount == 1)
                    {
                        selectedRow = row;
                    }
                }
            }

            if (selectedCount == 1)
            {
                txtTitle.Text = selectedRow.Cells[1].Value?.ToString() ?? "";
                txtUnitPrice.Text = selectedRow.Cells[2].Value?.ToString() ?? "";
                txtQuantity.Text = selectedRow.Cells[3].Value?.ToString() ?? "";
            }
            else
            {
                txtTitle.Clear();
                txtUnitPrice.Clear();
                txtQuantity.Clear();
            }
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void LoadData()
        {
            using (var db = new FinalProjectDbContext())
            {
                var products = db.Product.ToList();

                dataGridViewProduct.Rows.Clear();
                foreach (var product in products)
                {
                    dataGridViewProduct.Rows.Add(false, product.Title, product.UnitPrice, product.Quantity);
                }
            }
        }

        private void UpdateButtonStates()
        {
            int checkedCount = 0;


            foreach (DataGridViewRow row in dataGridViewProduct.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value))
                {
                    checkedCount++;
                }
            }


            if (checkedCount == 1)
            {
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
            }
            else if (checkedCount > 1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = true;
            }
            else
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void ClearFields()
        {
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            selectedProductId = -1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (selectedRowIndex == -1 || selectedRowIndex >= dataGridViewProduct.Rows.Count) return;

            using (var db = new FinalProjectDbContext())
            {
                DataGridViewRow row = dataGridViewProduct.Rows[selectedRowIndex];
                string title = row.Cells[1].Value?.ToString();

                var product = db.Product.FirstOrDefault(p => p.Title == title);
                if (product != null)
                {
                    product.Title = txtTitle.Text;

                    if (string.IsNullOrWhiteSpace(txtTitle.Text))
                    {
                        MessageBox.Show("Please enter a valid title", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        product.UnitPrice = Convert.ToInt32(txtUnitPrice.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please enter only numbers in unit price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    try
                    {
                        product.Quantity = Convert.ToInt32(txtQuantity.Text);
                    }
                    catch
                    {
                        MessageBox.Show("Please enter only numbers in quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    db.SaveChanges();
                    LoadData();

                }
                ClearFields();
                UpdateTextBoxes();
                UpdateButtonStates();

            }
        }

    }
}