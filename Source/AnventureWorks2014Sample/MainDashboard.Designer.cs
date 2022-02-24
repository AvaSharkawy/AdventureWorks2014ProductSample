
namespace AnventureWorks2014Sample
{
    partial class MainDashboard
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
            this.components = new System.ComponentModel.Container();
            this.gbDGV = new System.Windows.Forms.GroupBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.chkLiveSearch = new System.Windows.Forms.CheckBox();
            this.pnlStockFilter = new System.Windows.Forms.Panel();
            this.txtFilterTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFilterFrom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSubCategories = new System.Windows.Forms.ComboBox();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chkAutoSearch = new System.Windows.Forms.CheckBox();
            this.chkStockQuantity = new System.Windows.Forms.CheckBox();
            this.chkSubCategory = new System.Windows.Forms.CheckBox();
            this.chkCategory = new System.Windows.Forms.CheckBox();
            this.chkLocation = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbDGV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.gbFilter.SuspendLayout();
            this.pnlStockFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDGV
            // 
            this.gbDGV.Controls.Add(this.DGV);
            this.gbDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDGV.Location = new System.Drawing.Point(0, 200);
            this.gbDGV.Margin = new System.Windows.Forms.Padding(5);
            this.gbDGV.Name = "gbDGV";
            this.gbDGV.Padding = new System.Windows.Forms.Padding(5);
            this.gbDGV.Size = new System.Drawing.Size(1008, 529);
            this.gbDGV.TabIndex = 1;
            this.gbDGV.TabStop = false;
            this.gbDGV.Text = "Count: 0";
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(5, 30);
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.RowTemplate.Height = 25;
            this.DGV.Size = new System.Drawing.Size(998, 494);
            this.DGV.TabIndex = 0;
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.chkLiveSearch);
            this.gbFilter.Controls.Add(this.pnlStockFilter);
            this.gbFilter.Controls.Add(this.cbSubCategories);
            this.gbFilter.Controls.Add(this.cbCategories);
            this.gbFilter.Controls.Add(this.cbLocations);
            this.gbFilter.Controls.Add(this.btnSearch);
            this.gbFilter.Controls.Add(this.chkAutoSearch);
            this.gbFilter.Controls.Add(this.chkStockQuantity);
            this.gbFilter.Controls.Add(this.chkSubCategory);
            this.gbFilter.Controls.Add(this.chkCategory);
            this.gbFilter.Controls.Add(this.chkLocation);
            this.gbFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilter.Location = new System.Drawing.Point(0, 0);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(1008, 200);
            this.gbFilter.TabIndex = 0;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            // 
            // chkLiveSearch
            // 
            this.chkLiveSearch.AutoSize = true;
            this.chkLiveSearch.Location = new System.Drawing.Point(757, 78);
            this.chkLiveSearch.Name = "chkLiveSearch";
            this.chkLiveSearch.Size = new System.Drawing.Size(126, 29);
            this.chkLiveSearch.TabIndex = 10;
            this.chkLiveSearch.Text = "Live Search";
            this.toolTip1.SetToolTip(this.chkLiveSearch, "Perform Live Search on Database");
            this.chkLiveSearch.UseVisualStyleBackColor = true;
            this.chkLiveSearch.CheckedChanged += new System.EventHandler(this.chkLiveSearch_CheckedChanged);
            // 
            // pnlStockFilter
            // 
            this.pnlStockFilter.Controls.Add(this.txtFilterTo);
            this.pnlStockFilter.Controls.Add(this.label2);
            this.pnlStockFilter.Controls.Add(this.txtFilterFrom);
            this.pnlStockFilter.Controls.Add(this.label1);
            this.pnlStockFilter.Location = new System.Drawing.Point(189, 146);
            this.pnlStockFilter.Name = "pnlStockFilter";
            this.pnlStockFilter.Size = new System.Drawing.Size(327, 35);
            this.pnlStockFilter.TabIndex = 7;
            this.pnlStockFilter.Visible = false;
            // 
            // txtFilterTo
            // 
            this.txtFilterTo.Location = new System.Drawing.Point(225, 1);
            this.txtFilterTo.Name = "txtFilterTo";
            this.txtFilterTo.Size = new System.Drawing.Size(100, 32);
            this.txtFilterTo.TabIndex = 1;
            this.txtFilterTo.TextChanged += new System.EventHandler(this.txtFilterFrom_TextChanged);
            this.txtFilterTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterFrom_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "To: ";
            // 
            // txtFilterFrom
            // 
            this.txtFilterFrom.Location = new System.Drawing.Point(73, 1);
            this.txtFilterFrom.Name = "txtFilterFrom";
            this.txtFilterFrom.Size = new System.Drawing.Size(100, 32);
            this.txtFilterFrom.TabIndex = 0;
            this.txtFilterFrom.TextChanged += new System.EventHandler(this.txtFilterFrom_TextChanged);
            this.txtFilterFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterFrom_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            // 
            // cbSubCategories
            // 
            this.cbSubCategories.FormattingEnabled = true;
            this.cbSubCategories.Location = new System.Drawing.Point(189, 109);
            this.cbSubCategories.Name = "cbSubCategories";
            this.cbSubCategories.Size = new System.Drawing.Size(325, 33);
            this.cbSubCategories.TabIndex = 5;
            this.cbSubCategories.Visible = false;
            this.cbSubCategories.SelectedIndexChanged += new System.EventHandler(this.cbSubCategories_SelectedIndexChanged);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(189, 68);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(325, 33);
            this.cbCategories.TabIndex = 3;
            this.cbCategories.Visible = false;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.cbCategories_SelectedIndexChanged);
            // 
            // cbLocations
            // 
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(189, 29);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(325, 33);
            this.cbLocations.TabIndex = 1;
            this.cbLocations.Visible = false;
            this.cbLocations.SelectedIndexChanged += new System.EventHandler(this.cbLocations_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(757, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(239, 50);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.toolTip1.SetToolTip(this.btnSearch, "Perform Search and Filtering");
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkAutoSearch
            // 
            this.chkAutoSearch.AutoSize = true;
            this.chkAutoSearch.Location = new System.Drawing.Point(757, 113);
            this.chkAutoSearch.Name = "chkAutoSearch";
            this.chkAutoSearch.Size = new System.Drawing.Size(118, 29);
            this.chkAutoSearch.TabIndex = 9;
            this.chkAutoSearch.Text = "Auto Filter";
            this.toolTip1.SetToolTip(this.chkAutoSearch, "Perform Auto Filter on Cached Data. Can\'t be activated while Live Search is enabl" +
        "ed.");
            this.chkAutoSearch.UseVisualStyleBackColor = true;
            // 
            // chkStockQuantity
            // 
            this.chkStockQuantity.AutoSize = true;
            this.chkStockQuantity.Location = new System.Drawing.Point(9, 149);
            this.chkStockQuantity.Name = "chkStockQuantity";
            this.chkStockQuantity.Size = new System.Drawing.Size(177, 29);
            this.chkStockQuantity.TabIndex = 6;
            this.chkStockQuantity.Text = "By Stock Quantity";
            this.toolTip1.SetToolTip(this.chkStockQuantity, "Filter by Product Stock Quantity (From:To)");
            this.chkStockQuantity.UseVisualStyleBackColor = true;
            this.chkStockQuantity.CheckedChanged += new System.EventHandler(this.chkStockQuantity_CheckedChanged);
            // 
            // chkSubCategory
            // 
            this.chkSubCategory.AutoSize = true;
            this.chkSubCategory.Location = new System.Drawing.Point(6, 109);
            this.chkSubCategory.Name = "chkSubCategory";
            this.chkSubCategory.Size = new System.Drawing.Size(169, 29);
            this.chkSubCategory.TabIndex = 4;
            this.chkSubCategory.Text = "By Sub Category";
            this.toolTip1.SetToolTip(this.chkSubCategory, "Filter by Product Sub Category");
            this.chkSubCategory.UseVisualStyleBackColor = true;
            this.chkSubCategory.CheckedChanged += new System.EventHandler(this.chkSubCategory_CheckedChanged);
            // 
            // chkCategory
            // 
            this.chkCategory.AutoSize = true;
            this.chkCategory.Location = new System.Drawing.Point(6, 70);
            this.chkCategory.Name = "chkCategory";
            this.chkCategory.Size = new System.Drawing.Size(132, 29);
            this.chkCategory.TabIndex = 2;
            this.chkCategory.Text = "By Category";
            this.toolTip1.SetToolTip(this.chkCategory, "Filter by Product Category");
            this.chkCategory.UseVisualStyleBackColor = true;
            this.chkCategory.CheckedChanged += new System.EventHandler(this.chkCategory_CheckedChanged);
            // 
            // chkLocation
            // 
            this.chkLocation.AutoSize = true;
            this.chkLocation.Location = new System.Drawing.Point(6, 31);
            this.chkLocation.Name = "chkLocation";
            this.chkLocation.Size = new System.Drawing.Size(128, 29);
            this.chkLocation.TabIndex = 0;
            this.chkLocation.Text = "By Location";
            this.toolTip1.SetToolTip(this.chkLocation, "Filter by Product Location");
            this.chkLocation.UseVisualStyleBackColor = true;
            this.chkLocation.CheckedChanged += new System.EventHandler(this.chkLocation_CheckedChanged);
            // 
            // MainDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.gbDGV);
            this.Controls.Add(this.gbFilter);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainDashboard";
            this.Text = "AdventureWorks2014 Products";
            this.Load += new System.EventHandler(this.MainDashboard_Load);
            this.gbDGV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.gbFilter.ResumeLayout(false);
            this.gbFilter.PerformLayout();
            this.pnlStockFilter.ResumeLayout(false);
            this.pnlStockFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDGV;
        private System.Windows.Forms.GroupBox gbFilter;
        private System.Windows.Forms.CheckBox chkStockQuantity;
        private System.Windows.Forms.CheckBox chkSubCategory;
        private System.Windows.Forms.CheckBox chkCategory;
        private System.Windows.Forms.CheckBox chkLocation;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chkAutoSearch;
        private System.Windows.Forms.Panel pnlStockFilter;
        private System.Windows.Forms.TextBox txtFilterTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFilterFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSubCategories;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.CheckBox chkLiveSearch;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

