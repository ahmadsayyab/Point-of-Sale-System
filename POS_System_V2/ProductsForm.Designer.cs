namespace POS_System_V2
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AllProductBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.itemNameLbl = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.itemQuantityLbl = new System.Windows.Forms.Label();
            this.txtProductQuantity = new System.Windows.Forms.TextBox();
            this.itemPriceLbl = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.itemCategoryLbl = new System.Windows.Forms.Label();
            this.itemCostLbl = new System.Windows.Forms.Label();
            this.txtProductCategory = new System.Windows.Forms.TextBox();
            this.txtProductCost = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Addbtn = new System.Windows.Forms.Button();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.ClearFieldsbtn = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 78);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(83, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add Product";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(13, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(696, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 35);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 525);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 14);
            this.panel2.TabIndex = 8;
            // 
            // AllProductBox
            // 
            this.AllProductBox.ForeColor = System.Drawing.Color.Green;
            this.AllProductBox.FormattingEnabled = true;
            this.AllProductBox.Location = new System.Drawing.Point(12, 193);
            this.AllProductBox.Name = "AllProductBox";
            this.AllProductBox.Size = new System.Drawing.Size(186, 316);
            this.AllProductBox.TabIndex = 9;
            this.AllProductBox.SelectedIndexChanged += new System.EventHandler(this.AllProductBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Products";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.itemNameLbl, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.itemQuantityLbl, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProductQuantity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.itemPriceLbl, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtProductPrice, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.itemCategoryLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.itemCostLbl, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtProductCategory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProductCost, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(240, 193);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(513, 269);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // itemNameLbl
            // 
            this.itemNameLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.itemNameLbl.AutoSize = true;
            this.itemNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLbl.ForeColor = System.Drawing.Color.Green;
            this.itemNameLbl.Location = new System.Drawing.Point(3, 11);
            this.itemNameLbl.Name = "itemNameLbl";
            this.itemNameLbl.Size = new System.Drawing.Size(48, 16);
            this.itemNameLbl.TabIndex = 0;
            this.itemNameLbl.Text = "Name";
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductName.ForeColor = System.Drawing.Color.Gray;
            this.txtProductName.Location = new System.Drawing.Point(3, 47);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 20);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.Text = "Enter product name";
            this.txtProductName.Enter += new System.EventHandler(this.txtProductName_Enter);
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // itemQuantityLbl
            // 
            this.itemQuantityLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.itemQuantityLbl.AutoSize = true;
            this.itemQuantityLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemQuantityLbl.ForeColor = System.Drawing.Color.Green;
            this.itemQuantityLbl.Location = new System.Drawing.Point(3, 87);
            this.itemQuantityLbl.Name = "itemQuantityLbl";
            this.itemQuantityLbl.Size = new System.Drawing.Size(63, 16);
            this.itemQuantityLbl.TabIndex = 0;
            this.itemQuantityLbl.Text = "Quantity";
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductQuantity.ForeColor = System.Drawing.Color.Gray;
            this.txtProductQuantity.Location = new System.Drawing.Point(3, 123);
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.Size = new System.Drawing.Size(196, 20);
            this.txtProductQuantity.TabIndex = 2;
            this.txtProductQuantity.Text = "Enter product quantity";
            this.txtProductQuantity.Enter += new System.EventHandler(this.txtProductQuantity_Enter);
            this.txtProductQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductQuantity_KeyPress);
            this.txtProductQuantity.Leave += new System.EventHandler(this.txtProductQuantity_Leave);
            // 
            // itemPriceLbl
            // 
            this.itemPriceLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.itemPriceLbl.AutoSize = true;
            this.itemPriceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemPriceLbl.ForeColor = System.Drawing.Color.Green;
            this.itemPriceLbl.Location = new System.Drawing.Point(3, 163);
            this.itemPriceLbl.Name = "itemPriceLbl";
            this.itemPriceLbl.Size = new System.Drawing.Size(43, 16);
            this.itemPriceLbl.TabIndex = 0;
            this.itemPriceLbl.Text = "Price";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductPrice.ForeColor = System.Drawing.Color.Gray;
            this.txtProductPrice.Location = new System.Drawing.Point(3, 199);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(196, 20);
            this.txtProductPrice.TabIndex = 4;
            this.txtProductPrice.Text = "Enter product price";
            this.txtProductPrice.Enter += new System.EventHandler(this.txtProductPrice_Enter);
            this.txtProductPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductPrice_KeyPress);
            this.txtProductPrice.Leave += new System.EventHandler(this.txtProductPrice_Leave);
            // 
            // itemCategoryLbl
            // 
            this.itemCategoryLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.itemCategoryLbl.AutoSize = true;
            this.itemCategoryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCategoryLbl.ForeColor = System.Drawing.Color.Green;
            this.itemCategoryLbl.Location = new System.Drawing.Point(259, 11);
            this.itemCategoryLbl.Name = "itemCategoryLbl";
            this.itemCategoryLbl.Size = new System.Drawing.Size(70, 16);
            this.itemCategoryLbl.TabIndex = 0;
            this.itemCategoryLbl.Text = "Category";
            // 
            // itemCostLbl
            // 
            this.itemCostLbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.itemCostLbl.AutoSize = true;
            this.itemCostLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemCostLbl.ForeColor = System.Drawing.Color.Green;
            this.itemCostLbl.Location = new System.Drawing.Point(259, 87);
            this.itemCostLbl.Name = "itemCostLbl";
            this.itemCostLbl.Size = new System.Drawing.Size(38, 16);
            this.itemCostLbl.TabIndex = 0;
            this.itemCostLbl.Text = "Cost";
            // 
            // txtProductCategory
            // 
            this.txtProductCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductCategory.ForeColor = System.Drawing.Color.Gray;
            this.txtProductCategory.Location = new System.Drawing.Point(259, 47);
            this.txtProductCategory.Name = "txtProductCategory";
            this.txtProductCategory.Size = new System.Drawing.Size(196, 20);
            this.txtProductCategory.TabIndex = 1;
            this.txtProductCategory.Text = "Enter product category";
            this.txtProductCategory.Enter += new System.EventHandler(this.txtProductCategory_Enter);
            this.txtProductCategory.Leave += new System.EventHandler(this.txtProductCategory_Leave);
            // 
            // txtProductCost
            // 
            this.txtProductCost.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtProductCost.ForeColor = System.Drawing.Color.Gray;
            this.txtProductCost.Location = new System.Drawing.Point(259, 123);
            this.txtProductCost.Name = "txtProductCost";
            this.txtProductCost.Size = new System.Drawing.Size(196, 20);
            this.txtProductCost.TabIndex = 3;
            this.txtProductCost.Text = "Enter per product cost";
            this.txtProductCost.Enter += new System.EventHandler(this.txtProductCost_Enter);
            this.txtProductCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCost_KeyPress);
            this.txtProductCost.Leave += new System.EventHandler(this.txtProductCost_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(337, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = " Product Detail";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.Color.Green;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(246, 473);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(109, 47);
            this.Addbtn.TabIndex = 5;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Green;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(375, 473);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(105, 46);
            this.Updatebtn.TabIndex = 6;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.Red;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(502, 473);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(103, 46);
            this.Deletebtn.TabIndex = 7;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // ClearFieldsbtn
            // 
            this.ClearFieldsbtn.BackColor = System.Drawing.Color.Green;
            this.ClearFieldsbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFieldsbtn.ForeColor = System.Drawing.Color.White;
            this.ClearFieldsbtn.Location = new System.Drawing.Point(625, 473);
            this.ClearFieldsbtn.Name = "ClearFieldsbtn";
            this.ClearFieldsbtn.Size = new System.Drawing.Size(97, 47);
            this.ClearFieldsbtn.TabIndex = 11;
            this.ClearFieldsbtn.Text = "Clear";
            this.ClearFieldsbtn.UseVisualStyleBackColor = false;
            this.ClearFieldsbtn.Click += new System.EventHandler(this.ClearFieldsbtn_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(753, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 29);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(12, 167);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(139, 20);
            this.txtSearchProduct.TabIndex = 12;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchProduct.Image")));
            this.btnSearchProduct.Location = new System.Drawing.Point(158, 157);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(40, 30);
            this.btnSearchProduct.TabIndex = 13;
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.ClearFieldsbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AllProductBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsForm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox AllProductBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label itemNameLbl;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label itemQuantityLbl;
        private System.Windows.Forms.TextBox txtProductQuantity;
        private System.Windows.Forms.Label itemPriceLbl;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.Label itemCategoryLbl;
        private System.Windows.Forms.Label itemCostLbl;
        private System.Windows.Forms.TextBox txtProductCategory;
        private System.Windows.Forms.TextBox txtProductCost;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Button ClearFieldsbtn;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.TextBox txtSearchProduct;
    }
}