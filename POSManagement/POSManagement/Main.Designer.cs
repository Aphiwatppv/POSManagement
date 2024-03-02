namespace POSManagement
{
    partial class Main
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
            txtproductID = new TextBox();
            txtproductName = new TextBox();
            txtPrice = new TextBox();
            txtPriceUnit = new TextBox();
            txtRemainingStock = new TextBox();
            txtStockUnit = new TextBox();
            btnAddProduct = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dataGridView1 = new DataGridView();
            btnRemove = new Button();
            btnAdjust = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtproductID
            // 
            txtproductID.Location = new Point(109, 18);
            txtproductID.Name = "txtproductID";
            txtproductID.Size = new Size(143, 23);
            txtproductID.TabIndex = 0;
            // 
            // txtproductName
            // 
            txtproductName.Location = new Point(109, 62);
            txtproductName.Name = "txtproductName";
            txtproductName.Size = new Size(143, 23);
            txtproductName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(109, 114);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(143, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtPriceUnit
            // 
            txtPriceUnit.Location = new Point(109, 167);
            txtPriceUnit.Name = "txtPriceUnit";
            txtPriceUnit.Size = new Size(143, 23);
            txtPriceUnit.TabIndex = 3;
            // 
            // txtRemainingStock
            // 
            txtRemainingStock.Location = new Point(109, 223);
            txtRemainingStock.Name = "txtRemainingStock";
            txtRemainingStock.Size = new Size(143, 23);
            txtRemainingStock.TabIndex = 4;
            // 
            // txtStockUnit
            // 
            txtStockUnit.Location = new Point(109, 277);
            txtStockUnit.Name = "txtStockUnit";
            txtStockUnit.Size = new Size(143, 23);
            txtStockUnit.TabIndex = 5;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(12, 362);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(363, 31);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 26);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 7;
            label1.Text = "Product Id :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 8;
            label2.Text = "Product Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 122);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 9;
            label3.Text = "Price :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 175);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Price Unit :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 231);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 11;
            label5.Text = "Stock :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 285);
            label6.Name = "label6";
            label6.Size = new Size(67, 15);
            label6.TabIndex = 12;
            label6.Text = "Stock Unit :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(268, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(644, 278);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(135, 325);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(117, 31);
            btnRemove.TabIndex = 14;
            btnRemove.Text = "Remove Product";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnAdjust
            // 
            btnAdjust.Location = new Point(258, 325);
            btnAdjust.Name = "btnAdjust";
            btnAdjust.Size = new Size(117, 31);
            btnAdjust.TabIndex = 15;
            btnAdjust.Text = "Adjust Product";
            btnAdjust.UseVisualStyleBackColor = true;
            btnAdjust.Click += btnAdjust_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(12, 325);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(117, 31);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 407);
            Controls.Add(btnClear);
            Controls.Add(btnAdjust);
            Controls.Add(btnRemove);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAddProduct);
            Controls.Add(txtStockUnit);
            Controls.Add(txtRemainingStock);
            Controls.Add(txtPriceUnit);
            Controls.Add(txtPrice);
            Controls.Add(txtproductName);
            Controls.Add(txtproductID);
            Name = "Main";
            Text = "Testting System";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtproductID;
        private TextBox txtproductName;
        private TextBox txtPrice;
        private TextBox txtPriceUnit;
        private TextBox txtRemainingStock;
        private TextBox txtStockUnit;
        private Button btnAddProduct;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DataGridView dataGridView1;
        private Button btnRemove;
        private Button btnAdjust;
        private Button btnClear;
    }
}
