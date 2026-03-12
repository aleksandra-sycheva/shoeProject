namespace shoeProject
{
    partial class FormOrders
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panelTop = new Panel();
            bthFormsProduct = new Button();
            lblUserName = new Label();
            btnLogout = new Button();
            dgvOrders = new DataGridView();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.Controls.Add(bthFormsProduct);
            panelTop.Controls.Add(lblUserName);
            panelTop.Controls.Add(btnLogout);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(10, 10);
            panelTop.Name = "panelTop";
            panelTop.Padding = new Padding(0, 0, 0, 10);
            panelTop.Size = new Size(962, 40);
            panelTop.TabIndex = 0;
            // 
            // bthFormsProduct
            // 
            bthFormsProduct.BackColor = Color.MediumSpringGreen;
            bthFormsProduct.Dock = DockStyle.Left;
            bthFormsProduct.FlatAppearance.BorderSize = 0;
            bthFormsProduct.FlatStyle = FlatStyle.Flat;
            bthFormsProduct.Location = new Point(0, 0);
            bthFormsProduct.Name = "bthFormsProduct";
            bthFormsProduct.Size = new Size(170, 30);
            bthFormsProduct.TabIndex = 7;
            bthFormsProduct.Text = "Товары";
            bthFormsProduct.UseVisualStyleBackColor = false;
            bthFormsProduct.Click += BthFormsProduct_Click;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Dock = DockStyle.Right;
            lblUserName.Location = new Point(732, 0);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(60, 22);
            lblUserName.TabIndex = 6;
            lblUserName.Text = "label1";
            lblUserName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.MediumSpringGreen;
            btnLogout.Dock = DockStyle.Right;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(792, 0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(170, 30);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Выход";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += BtnLogout_Click;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOrders.BackgroundColor = Color.White;
            dgvOrders.BorderStyle = BorderStyle.None;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Format = " ";
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.DefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(10, 50);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(962, 593);
            dgvOrders.TabIndex = 1;
            // 
            // FormOrders
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 653);
            Controls.Add(dgvOrders);
            Controls.Add(panelTop);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormOrders";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заказов";
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTop;
        private DataGridView dgvOrders;
        private Label lblUserName;
        private Button btnProducts;
        private Button btnLogout;
        private Button bthFormsProduct;
    }
}
