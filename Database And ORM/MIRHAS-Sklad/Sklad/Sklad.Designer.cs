namespace Sklad
{
    partial class Sklad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.updateProvider_btn = new System.Windows.Forms.Button();
            this.removeProvider_btn = new System.Windows.Forms.Button();
            this.addProvider_btn = new System.Windows.Forms.Button();
            this.provider_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.providerPhone_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.providerName_txb = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.updateCustomer_btn = new System.Windows.Forms.Button();
            this.removeCustomer_btn = new System.Windows.Forms.Button();
            this.addCustomer_btn = new System.Windows.Forms.Button();
            this.customer_list = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.customerPhone_txb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customerName_txb = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.productProvider_txb = new System.Windows.Forms.ComboBox();
            this.updateProduct_btn = new System.Windows.Forms.Button();
            this.removeProduct_btn = new System.Windows.Forms.Button();
            this.addProduct_btn = new System.Windows.Forms.Button();
            this.product_list = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.productName_txb = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.buyProductSellingPrice_txb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buyProductPrice_txb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buyProductProduct_txb = new System.Windows.Forms.ComboBox();
            this.buyProduct_btn = new System.Windows.Forms.Button();
            this.buyProduct_list = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.buyProductQuantity_txb = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_list)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyProduct_list)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.updateProvider_btn);
            this.tabPage1.Controls.Add(this.removeProvider_btn);
            this.tabPage1.Controls.Add(this.addProvider_btn);
            this.tabPage1.Controls.Add(this.provider_list);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.providerPhone_txb);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.providerName_txb);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 417);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manage Provider";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // updateProvider_btn
            // 
            this.updateProvider_btn.Location = new System.Drawing.Point(31, 270);
            this.updateProvider_btn.Name = "updateProvider_btn";
            this.updateProvider_btn.Size = new System.Drawing.Size(125, 29);
            this.updateProvider_btn.TabIndex = 7;
            this.updateProvider_btn.Text = "Update";
            this.updateProvider_btn.UseVisualStyleBackColor = true;
            this.updateProvider_btn.Click += new System.EventHandler(this.updateProvider_btn_Click);
            // 
            // removeProvider_btn
            // 
            this.removeProvider_btn.Location = new System.Drawing.Point(31, 324);
            this.removeProvider_btn.Name = "removeProvider_btn";
            this.removeProvider_btn.Size = new System.Drawing.Size(125, 29);
            this.removeProvider_btn.TabIndex = 6;
            this.removeProvider_btn.Text = "Remove";
            this.removeProvider_btn.UseVisualStyleBackColor = true;
            this.removeProvider_btn.Click += new System.EventHandler(this.removeProvider_btn_Click);
            // 
            // addProvider_btn
            // 
            this.addProvider_btn.Location = new System.Drawing.Point(31, 211);
            this.addProvider_btn.Name = "addProvider_btn";
            this.addProvider_btn.Size = new System.Drawing.Size(125, 29);
            this.addProvider_btn.TabIndex = 5;
            this.addProvider_btn.Text = "Add";
            this.addProvider_btn.UseVisualStyleBackColor = true;
            this.addProvider_btn.Click += new System.EventHandler(this.addProvider_btn_Click);
            // 
            // provider_list
            // 
            this.provider_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.provider_list.Location = new System.Drawing.Point(205, 16);
            this.provider_list.Name = "provider_list";
            this.provider_list.RowHeadersWidth = 51;
            this.provider_list.RowTemplate.Height = 29;
            this.provider_list.Size = new System.Drawing.Size(552, 393);
            this.provider_list.TabIndex = 4;
            this.provider_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provider_list_CellContentClick);
            this.provider_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.provider_list_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Phone";
            // 
            // providerPhone_txb
            // 
            this.providerPhone_txb.Location = new System.Drawing.Point(31, 145);
            this.providerPhone_txb.Name = "providerPhone_txb";
            this.providerPhone_txb.Size = new System.Drawing.Size(125, 27);
            this.providerPhone_txb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // providerName_txb
            // 
            this.providerName_txb.Location = new System.Drawing.Point(31, 55);
            this.providerName_txb.Name = "providerName_txb";
            this.providerName_txb.Size = new System.Drawing.Size(125, 27);
            this.providerName_txb.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.updateCustomer_btn);
            this.tabPage2.Controls.Add(this.removeCustomer_btn);
            this.tabPage2.Controls.Add(this.addCustomer_btn);
            this.tabPage2.Controls.Add(this.customer_list);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.customerPhone_txb);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.customerName_txb);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 417);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Manage Customers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // updateCustomer_btn
            // 
            this.updateCustomer_btn.Location = new System.Drawing.Point(33, 266);
            this.updateCustomer_btn.Name = "updateCustomer_btn";
            this.updateCustomer_btn.Size = new System.Drawing.Size(125, 29);
            this.updateCustomer_btn.TabIndex = 15;
            this.updateCustomer_btn.Text = "Update";
            this.updateCustomer_btn.UseVisualStyleBackColor = true;
            this.updateCustomer_btn.Click += new System.EventHandler(this.updateCustomer_btn_Click);
            // 
            // removeCustomer_btn
            // 
            this.removeCustomer_btn.Location = new System.Drawing.Point(33, 320);
            this.removeCustomer_btn.Name = "removeCustomer_btn";
            this.removeCustomer_btn.Size = new System.Drawing.Size(125, 29);
            this.removeCustomer_btn.TabIndex = 14;
            this.removeCustomer_btn.Text = "Remove";
            this.removeCustomer_btn.UseVisualStyleBackColor = true;
            this.removeCustomer_btn.Click += new System.EventHandler(this.removeCustomer_btn_Click);
            // 
            // addCustomer_btn
            // 
            this.addCustomer_btn.Location = new System.Drawing.Point(33, 207);
            this.addCustomer_btn.Name = "addCustomer_btn";
            this.addCustomer_btn.Size = new System.Drawing.Size(125, 29);
            this.addCustomer_btn.TabIndex = 13;
            this.addCustomer_btn.Text = "Add";
            this.addCustomer_btn.UseVisualStyleBackColor = true;
            this.addCustomer_btn.Click += new System.EventHandler(this.addCustomer_btn_Click);
            // 
            // customer_list
            // 
            this.customer_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customer_list.Location = new System.Drawing.Point(207, 12);
            this.customer_list.Name = "customer_list";
            this.customer_list.RowHeadersWidth = 51;
            this.customer_list.RowTemplate.Height = 29;
            this.customer_list.Size = new System.Drawing.Size(552, 393);
            this.customer_list.TabIndex = 12;
            this.customer_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_list_CellContentClick);
            this.customer_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customer_list_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone";
            // 
            // customerPhone_txb
            // 
            this.customerPhone_txb.Location = new System.Drawing.Point(33, 141);
            this.customerPhone_txb.Name = "customerPhone_txb";
            this.customerPhone_txb.Size = new System.Drawing.Size(125, 27);
            this.customerPhone_txb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // customerName_txb
            // 
            this.customerName_txb.Location = new System.Drawing.Point(33, 51);
            this.customerName_txb.Name = "customerName_txb";
            this.customerName_txb.Size = new System.Drawing.Size(125, 27);
            this.customerName_txb.TabIndex = 8;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.productProvider_txb);
            this.tabPage3.Controls.Add(this.updateProduct_btn);
            this.tabPage3.Controls.Add(this.removeProduct_btn);
            this.tabPage3.Controls.Add(this.addProduct_btn);
            this.tabPage3.Controls.Add(this.product_list);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.productName_txb);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 417);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Manage Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Provider";
            // 
            // productProvider_txb
            // 
            this.productProvider_txb.FormattingEnabled = true;
            this.productProvider_txb.Location = new System.Drawing.Point(33, 157);
            this.productProvider_txb.Name = "productProvider_txb";
            this.productProvider_txb.Size = new System.Drawing.Size(151, 28);
            this.productProvider_txb.TabIndex = 16;
            // 
            // updateProduct_btn
            // 
            this.updateProduct_btn.Location = new System.Drawing.Point(33, 309);
            this.updateProduct_btn.Name = "updateProduct_btn";
            this.updateProduct_btn.Size = new System.Drawing.Size(125, 29);
            this.updateProduct_btn.TabIndex = 15;
            this.updateProduct_btn.Text = "Update";
            this.updateProduct_btn.UseVisualStyleBackColor = true;
            this.updateProduct_btn.Click += new System.EventHandler(this.updateProduct_btn_Click);
            // 
            // removeProduct_btn
            // 
            this.removeProduct_btn.Location = new System.Drawing.Point(33, 363);
            this.removeProduct_btn.Name = "removeProduct_btn";
            this.removeProduct_btn.Size = new System.Drawing.Size(125, 29);
            this.removeProduct_btn.TabIndex = 14;
            this.removeProduct_btn.Text = "Remove";
            this.removeProduct_btn.UseVisualStyleBackColor = true;
            this.removeProduct_btn.Click += new System.EventHandler(this.removeProduct_btn_Click);
            // 
            // addProduct_btn
            // 
            this.addProduct_btn.Location = new System.Drawing.Point(33, 250);
            this.addProduct_btn.Name = "addProduct_btn";
            this.addProduct_btn.Size = new System.Drawing.Size(125, 29);
            this.addProduct_btn.TabIndex = 13;
            this.addProduct_btn.Text = "Add";
            this.addProduct_btn.UseVisualStyleBackColor = true;
            this.addProduct_btn.Click += new System.EventHandler(this.addProduct_btn_Click);
            // 
            // product_list
            // 
            this.product_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.product_list.Location = new System.Drawing.Point(207, 12);
            this.product_list.Name = "product_list";
            this.product_list.RowHeadersWidth = 51;
            this.product_list.RowTemplate.Height = 29;
            this.product_list.Size = new System.Drawing.Size(552, 393);
            this.product_list.TabIndex = 12;
            this.product_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_list_CellContentClick);
            this.product_list.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.product_list_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // productName_txb
            // 
            this.productName_txb.Location = new System.Drawing.Point(33, 62);
            this.productName_txb.Name = "productName_txb";
            this.productName_txb.Size = new System.Drawing.Size(125, 27);
            this.productName_txb.TabIndex = 8;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.buyProductSellingPrice_txb);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.buyProductPrice_txb);
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.buyProductProduct_txb);
            this.tabPage4.Controls.Add(this.buyProduct_btn);
            this.tabPage4.Controls.Add(this.buyProduct_list);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.buyProductQuantity_txb);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 417);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Buy Product";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 243);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 27;
            this.label10.Text = "SellingPrice";
            // 
            // buyProductSellingPrice_txb
            // 
            this.buyProductSellingPrice_txb.Location = new System.Drawing.Point(20, 266);
            this.buyProductSellingPrice_txb.Name = "buyProductSellingPrice_txb";
            this.buyProductSellingPrice_txb.Size = new System.Drawing.Size(125, 27);
            this.buyProductSellingPrice_txb.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 166);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 25;
            this.label9.Text = "Price";
            // 
            // buyProductPrice_txb
            // 
            this.buyProductPrice_txb.Location = new System.Drawing.Point(21, 189);
            this.buyProductPrice_txb.Name = "buyProductPrice_txb";
            this.buyProductPrice_txb.Size = new System.Drawing.Size(125, 27);
            this.buyProductPrice_txb.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Product";
            // 
            // buyProductProduct_txb
            // 
            this.buyProductProduct_txb.FormattingEnabled = true;
            this.buyProductProduct_txb.Location = new System.Drawing.Point(21, 43);
            this.buyProductProduct_txb.Name = "buyProductProduct_txb";
            this.buyProductProduct_txb.Size = new System.Drawing.Size(151, 28);
            this.buyProductProduct_txb.TabIndex = 22;
            // 
            // buyProduct_btn
            // 
            this.buyProduct_btn.Location = new System.Drawing.Point(20, 354);
            this.buyProduct_btn.Name = "buyProduct_btn";
            this.buyProduct_btn.Size = new System.Drawing.Size(125, 29);
            this.buyProduct_btn.TabIndex = 21;
            this.buyProduct_btn.Text = "Buy";
            this.buyProduct_btn.UseVisualStyleBackColor = true;
            this.buyProduct_btn.Click += new System.EventHandler(this.buyProduct_btn_Click);
            // 
            // buyProduct_list
            // 
            this.buyProduct_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.buyProduct_list.Location = new System.Drawing.Point(208, 12);
            this.buyProduct_list.Name = "buyProduct_list";
            this.buyProduct_list.RowHeadersWidth = 51;
            this.buyProduct_list.RowTemplate.Height = 29;
            this.buyProduct_list.Size = new System.Drawing.Size(552, 393);
            this.buyProduct_list.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Quantity";
            // 
            // buyProductQuantity_txb
            // 
            this.buyProductQuantity_txb.Location = new System.Drawing.Point(21, 114);
            this.buyProductQuantity_txb.Name = "buyProductQuantity_txb";
            this.buyProductQuantity_txb.Size = new System.Drawing.Size(125, 27);
            this.buyProductQuantity_txb.TabIndex = 18;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 417);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Sell Product";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Sklad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Sklad";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.provider_list)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customer_list)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.product_list)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buyProduct_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button updateProvider_btn;
        private Button removeProvider_btn;
        private Button addProvider_btn;
        private DataGridView provider_list;
        private Label label2;
        private TextBox providerPhone_txb;
        private Label label1;
        private TextBox providerName_txb;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Button updateCustomer_btn;
        private Button removeCustomer_btn;
        private Button addCustomer_btn;
        private DataGridView customer_list;
        private Label label3;
        private TextBox customerPhone_txb;
        private Label label4;
        private TextBox customerName_txb;
        private ComboBox productProvider_txb;
        private Button updateProduct_btn;
        private Button removeProduct_btn;
        private Button addProduct_btn;
        private DataGridView product_list;
        private Label label6;
        private TextBox productName_txb;
        private Label label7;
        private Label label10;
        private TextBox buyProductSellingPrice_txb;
        private Label label9;
        private TextBox buyProductPrice_txb;
        private Label label5;
        private ComboBox buyProductProduct_txb;
        private Button buyProduct_btn;
        private DataGridView buyProduct_list;
        private Label label8;
        private TextBox buyProductQuantity_txb;
    }
}