using Microsoft.EntityFrameworkCore;
using shoeProject.Models;
using shoeProject.Properties;
using System.Drawing;

namespace shoeProject
{
    public partial class FormOrders : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormOrders(User user, bool guest)
        {
            InitializeComponent();

            var colCustomer = new DataGridViewTextBoxColumn();
            colCustomer.Name = "colCustomer";
            colCustomer.HeaderText = "Покупатель";
            colCustomer.FillWeight = 25;
            colCustomer.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colOrderInfo = new DataGridViewTextBoxColumn();
            colOrderInfo.Name = "colOrderInfo";
            colOrderInfo.HeaderText = "Детали заказа";
            colOrderInfo.FillWeight = 50;
            colOrderInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colStatus = new DataGridViewTextBoxColumn();
            colStatus.Name = "colStatus";
            colStatus.HeaderText = "Статус";
            colStatus.FillWeight = 25;
            colStatus.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvOrders.Columns.AddRange([colCustomer, colOrderInfo, colStatus]);

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.FullNmae;

            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                using (var db = new ShopContext())
                {
                    var today = DateOnly.FromDateTime(DateTime.Today);
                    var orders = db.Orders
                        .Include(o => o.User)
                        .Include(o => o.DeliveryPoint)
                        .Include(o => o.Status)
                        .Include(o => o.ProductsOrders)
                        .ThenInclude(po => po.Product)
                        .OrderByDescending(o => o.OrderDate)
                        .ToList();

                    dgvOrders.SuspendLayout();
                    dgvOrders.Rows.Clear();

                    foreach (var order in orders)
                    {
                        int rowIndex = dgvOrders.Rows.Add();
                        var row = dgvOrders.Rows[rowIndex];

                        row.Cells["colCustomer"].Value = order.User.FullNmae;

                        row.Cells["colOrderInfo"].Value = FormatOrderInfo(order);

                        row.Cells["colStatus"].Value = order.Status.StatusName;
                        row.Cells["colStatus"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        ApplyRowStyles(row, order, today);
                    }
                    dgvOrders.ResumeLayout();
                    dgvOrders.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки заказов: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatOrderInfo(Order order)
        {
            int totalQuantity = order.ProductsOrders.Sum(po => po.Quantity);
            int itemsCount = order.ProductsOrders.Count;
            decimal totalSum = order.ProductsOrders.Sum(po => po.Quantity * po.Product.Price);

            string datesText = $"Дата заказа: {order.OrderDate} | Доставка: {order.DeliveryDate}";
            string detailsText = $"Код: {order.Code} | Адрес: {order.DeliveryPoint.DeliveryAddress}";
            string totalsText = $"Товаров: {itemsCount}, шт: {totalQuantity}, сумма: {totalSum:C}";

            return $"{datesText}{Environment.NewLine}{detailsText}{Environment.NewLine}{totalsText}";
        }

        private void ApplyRowStyles(DataGridViewRow row, Order order, DateOnly today)
        {
            if (order.Status.StatusName.Contains("Новый") || order.OrderDate == today)
            {
                row.DefaultCellStyle.BackColor = Color.LightCoral;
            }
            // Завершен - зеленый
            else if (order.Status.StatusName.Contains("Завершен"))
            {
                row.DefaultCellStyle.BackColor = Color.LightGreen;
            }

            // Выделение статуса
            row.Cells["colStatus"].Style.Font = new Font("Times New Roman", 12, FontStyle.Bold);
            row.Cells["colStatus"].Style.ForeColor = row.DefaultCellStyle.ForeColor == Color.White ? Color.White : Color.DarkBlue;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            using (var formProducts = new FormProducts(CurrentUser, IsGuest))
            {
                formProducts.ShowDialog();
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }

        private void BthFormsProduct_Click(object sender, EventArgs e)
        {
            this.Close();
            using (var formProducts = new FormProducts(CurrentUser, IsGuest))
            {
                formProducts.ShowDialog();
            }
        }
    }
}
