using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AnventureWorks2014Sample
{
    public partial class MainDashboard : Form
    {
        private DataTable _showedProducts;

        private DataTable ShowedProducts
        {
            get => _showedProducts;
            set
            {
                _showedProducts = value;

                SetDGVSource(_showedProducts);
            }
        }

        private DataTable SourceProducts { get; set; }
        private DataTable SourceLocations { get; set; }
        private DataTable SourceCategories { get; set; }
        private DataTable SourceSubCategories { get; set; }

        public MainDashboard()
        {
            InitializeComponent();
        }

        private void SetDGVSource(DataTable dataTable)
        {
            gbDGV.Text = $"Count: {dataTable?.Rows.Count ?? 0}";

            DGV.DataSource = dataTable;
        }

        private void InitializeLocations()
        {
            SourceLocations = DataAccess.Location.GetLocations();

            cbLocations.ValueMember = "LocationID";
            cbLocations.DisplayMember = "Name";
            cbLocations.SetComboBoxDataSource(SourceLocations);
        }

        private void InitializeCategories()
        {
            SourceCategories = DataAccess.Category.GetCategories();

            cbCategories.ValueMember = "ProductCategoryID";
            cbCategories.DisplayMember = "Name";
            cbCategories.SetComboBoxDataSource(SourceCategories);
        }

        private void InitializeSubCategories()
        {
            SourceSubCategories = DataAccess.SubCategory.GetSubCategories();

            cbSubCategories.ValueMember = "ProductSubcategoryID";
            cbSubCategories.DisplayMember = "Name";
            cbSubCategories.SetComboBoxDataSource(SourceCategories);
        }

        private void GetProducts(string filter = "", SqlParameter[] sqlParameters = null)
        {
            SourceProducts = DataAccess.Products.GetProducts(filter, sqlParameters);

            ShowedProducts = SourceProducts;
        }

        private void chkLocation_CheckedChanged(object sender, EventArgs e)
        {
            cbLocations.Visible = chkLocation.Checked;

            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }

        private void chkCategory_CheckedChanged(object sender, EventArgs e)
        {
            cbCategories.Visible = chkCategory.Checked;

            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }

        private void chkSubCategory_CheckedChanged(object sender, EventArgs e)
        {
            cbSubCategories.Visible = chkSubCategory.Checked;

            if (chkCategory.Checked)
            {
                cbCategories_SelectedIndexChanged(cbCategories, null);
            }
            else
            {
                cbSubCategories.SetComboBoxDataSource(SourceSubCategories);
            }

            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }

        private void chkStockQuantity_CheckedChanged(object sender, EventArgs e)
        {
            pnlStockFilter.Visible = chkStockQuantity.Checked;

        }

        private void MainDashboard_Load(object sender, EventArgs e)
        {
            InitializeLocations();

            InitializeCategories();

            InitializeSubCategories();

            GetProducts();
        }

        private void chkLiveSearch_CheckedChanged(object sender, EventArgs e)
        {
            chkAutoSearch.Checked = chkAutoSearch.Enabled = !chkLiveSearch.Checked;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        private void DoSearch()
        {
            if (chkLiveSearch.Checked)
            {
                DoLiveSearch();
            }
            else
            {
                DoCachedDataSearch();
            }
        }

        private void DoLiveSearch()
        {
            var filters = string.Empty;
            var param = new List<SqlParameter>();

            if (chkLocation.Checked && cbLocations.SelectedValue != null)
            {
                filters += " and loc.LocationID = @LocationId";
                param.Add(new SqlParameter("@LocationId", cbLocations.SelectedValue));
            }

            if (chkCategory.Checked && cbCategories.SelectedValue != null)
            {
                filters += " and category.ProductCategoryID = @CategoryId";
                param.Add(new SqlParameter("@CategoryId", cbCategories.SelectedValue));
            }

            if (chkSubCategory.Checked && cbSubCategories.SelectedValue != null)
            {
                filters += " and subCategory.ProductSubcategoryID = @SubCategoryId";
                param.Add(new SqlParameter("@SubCategoryId", cbSubCategories.SelectedValue));
            }

            if (chkStockQuantity.Checked)
            {
                if (txtFilterFrom.Text.IsNullOrEmpty() == false)
                {
                    filters += " and inventory.Quantity >= @QuantityFrom";
                    param.Add(new SqlParameter("@QuantityFrom", txtFilterFrom.Text.AsDecimalSafe()));
                }

                if (txtFilterTo.Text.IsNullOrEmpty() == false)
                {
                    filters += " and inventory.Quantity <= @QuantityTo";
                    param.Add(new SqlParameter("@QuantityTo", txtFilterTo.Text.AsDecimalSafe()));
                }
            }

            GetProducts(filters, param.ToArray());
        }

        private void DoCachedDataSearch()
        {
            var products = SourceProducts.AsEnumerable().AsQueryable();

            if (chkLocation.Checked && cbLocations.SelectedValue != null)
            {
                products = products.Where(a => a.Field<string>("ProductLocation") == cbLocations.Text);
            }

            if (chkCategory.Checked && cbCategories.SelectedValue != null)
            {
                products = products.Where(a => a.Field<string>("ProductCategory") == cbCategories.Text);
            }

            if (chkSubCategory.Checked && cbSubCategories.SelectedValue != null)
            {
                products = products.Where(a => a.Field<string>("ProductSubCategory") == cbSubCategories.Text);
            }

            if (chkStockQuantity.Checked)
            {
                if (txtFilterFrom.Text.IsNullOrEmpty() == false)
                {
                    products = products.Where(a => a.Field<short>("ProductStockQuantity") >= txtFilterFrom.Text.AsIntSafe());
                }

                if (txtFilterTo.Text.IsNullOrEmpty() == false)
                {
                    products = products.Where(a => a.Field<short>("ProductStockQuantity") <= txtFilterTo.Text.AsIntSafe());
                }
            }

            if (products.Count() <= 0)
                ShowedProducts = new DataTable();
            else
                ShowedProducts = products.CopyToDataTable();
        }

        private void txtFilterFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.ValidataNumberWithHotKeys();
        }

        private void txtFilterFrom_TextChanged(object sender, EventArgs e)
        {
            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }

        private void cbLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.SelectedIndex <= -1)
                return;

            if (cb.SelectedValue == null)
                return;

            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.SelectedIndex <= -1)
                return;

            if (cb.SelectedValue == null)
                return;

            if(chkCategory.Checked && chkSubCategory.Checked)
            {
                // Change SubCategory DataSource to Category items
                var categorySubs = SourceSubCategories
                    .AsEnumerable()
                    .Where(a => a.Field<int>("ProductCategoryID") == cbCategories.SelectedValue.AsIntSafe())
                    .CopyToDataTable();

                cbSubCategories.DataSource = categorySubs;
            }

            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }

        private void cbSubCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.SelectedIndex <= -1)
                return;

            if (cb.SelectedValue == null)
                return;

            if (chkAutoSearch.Checked)
                btnSearch.PerformClick();
        }
    }
}
