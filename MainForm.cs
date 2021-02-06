using carserviceapp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carserviceapp
{
    public partial class MainForm : Form
    {
        private List<Service> cartServices = new List<Service>();
        private List<Service> dbServices;
        private Order loadedOrder;

        public MainForm()
        {
            InitializeComponent();
            UpdateServicesTable();
            UpdateOrdersTable();
            LoadServices();
            statusCb.Items.AddRange(AppDB.GetStatusDescriptions());
            cartDGV.DataSource = null;
        }

        private void LoadServices()
        {
            dbServices = AppDB.GetServices();
            cartCb.Items.Clear();
            cartCb.Items.AddRange(dbServices.Select(s => s.Label).ToArray());
        }

        private void UpdateOrdersTable()
        {
            ordersDGV.DataSource = AppDB.GetOrders().OrderBy(o => o.Status).ToList();
        }

        private void UpdateServicesTable()
        {
            var data = AppDB.GetServices();
            servicesListView.Clear();
            foreach (var service in data)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = service.Label;
                lvi.SubItems.Add(service.Cost.ToString());
                lvi.SubItems.Add(service.Id.ToString());
                servicesListView.Items.Add(lvi);
            }
        }

        private void LoadOrderServices(Order order)
        {
            if(order != null)
            {
                orderServicesDGV.DataSource = order.Services;
                statusCb.Text = order.Status.GetDescription();
                statusLabel.Text = $"Замовлення '{order.Label}' (id: {order.Id}) на суму {order.GetTotalCost()} (+{order.OverPriceString})";
                updateStatusBtn.Enabled = true;
                loadedOrder = order;
            }
            else
            {
                orderServicesDGV.ClearSelection();
                orderServicesDGV.DataSource = null;
                statusLabel.Text = "Замовлення не обрано";
                updateStatusBtn.Enabled = false;
                statusCb.Text = string.Empty;
                loadedOrder = null;
            }
        }

        private bool GetServiceFieldsValid()
        {
            if (string.IsNullOrWhiteSpace(serviceLabelTb.Text))
                return false;

            return true;
        }

        private bool GetCartFieldsValid()
        {
            if (string.IsNullOrWhiteSpace(orderTb.Text))
                return false;
            if (cartDGV.Rows.Count == 0)
                return false;

            return true;
        }

        private void ClearFields(Control.ControlCollection container)
        {
            foreach (var control in container)
            {
                if (control is TextBoxBase)
                    ((TextBoxBase)control).Text = string.Empty;
                else if(control is NumericUpDown)
                    ((NumericUpDown)control).Value = 0m;
                else if (control is ComboBox)
                    ((ComboBox)control).Text = string.Empty;
            }
        }

        private void addService_Click(object sender, EventArgs e)
        {
            if(GetServiceFieldsValid() == true)
            {
                AppDB.AddService(new Service(serviceLabelTb.Text, servicePriceNud.Value));
                UpdateServicesTable();
                ClearFields(tabPage1.Controls);
                LoadServices();
            }
            else
            {
                MessageBox.Show("Усі поля повинні бути заповнені!", "Помічник",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteService_Click(object sender, EventArgs e)
        {
            if(servicesListView.SelectedItems.Count > 0)
            {
                AppDB.RemoveService(int.Parse(servicesListView.SelectedItems[0].SubItems[2].Text));
                UpdateServicesTable();
                ClearFields(tabPage1.Controls);
                LoadServices();
            }
            else
            {
                MessageBox.Show("Спочатку оберіть послугу!", "Помічник",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (servicesListView.SelectedItems.Count > 0)
            {
                int id = int.Parse(servicesListView.SelectedItems[0].SubItems[2].Text);
                AppDB.UpdateService(new Service
                {
                    Label = serviceLabelTb.Text,
                    Cost = servicePriceNud.Value,
                    Id = id
                });
                UpdateServicesTable();
                ClearFields(tabPage1.Controls);
                LoadServices();
            }
            else
            {
                MessageBox.Show("Спочатку оберіть послугу!", "Помічник",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void servicesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(servicesListView.SelectedItems.Count > 0)
            {
                serviceLabelTb.Text = servicesListView.SelectedItems[0].Text;
                servicePriceNud.Value = decimal.Parse(servicesListView.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void viewOrderBtn_Click(object sender, EventArgs e)
        {
            if(ordersDGV.SelectedRows.Count > 0)
            {
                LoadOrderServices(ordersDGV.SelectedRows[0].DataBoundItem as Order);
                tabControl1.SelectedTab = tabControl1.TabPages[3];
            }
            else
            {
                MessageBox.Show("Спочатку оберіть замовлення!", "Помічник",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void deleteOrderBtn_Click(object sender, EventArgs e)
        {
            if (ordersDGV.SelectedRows.Count > 0)
            {
                AppDB.RemoveOrder((ordersDGV.SelectedRows[0].DataBoundItem as Order).Id);
                UpdateOrdersTable();
                LoadOrderServices(null);
            }
            else
            {
                MessageBox.Show("Спочатку оберіть замовлення!", "Помічник",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void refreshOrdersTable_Click(object sender, EventArgs e)
        {
            UpdateOrdersTable();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (GetCartFieldsValid() == true)
            {
                cartDGV.DataSource = null;
                AppDB.AddOrder(new Order(orderTb.Text, (float)overpriceNud.Value/100, cartServices));
                cartServices.Clear();
                UpdateOrdersTable();
            }
            else
            {
                MessageBox.Show("Усі поля повинні бути заповнені, а послуги обрані!", "Помічник",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private decimal GetTotalCartPrice()
        {
            return new Order(orderTb.Text, (float)overpriceNud.Value/100, cartServices).GetTotalCost();
        }

        private void addServiceToCartBtb_Click(object sender, EventArgs e)
        {
            if(cartCb.SelectedIndex > -1)
            {
                cartDGV.DataSource = null;
                cartServices.Add(dbServices[cartCb.SelectedIndex]);
                cartDGV.DataSource = cartServices;
                label7.Text = "Вартість всього: " + GetTotalCartPrice();
            }
        }

        private void overpriceNud_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = "Вартість всього: " + GetTotalCartPrice();
        }

        private void remove_service_click(object sender, EventArgs e)
        {
            if (cartDGV.SelectedRows.Count > 0)
            {
                cartServices.RemoveAt(cartDGV.SelectedRows[0].Index);
                cartDGV.DataSource = null;
                cartDGV.DataSource = cartServices;
                label7.Text = "Вартість всього: " + GetTotalCartPrice();
            }
        }

        private void updateStatusBtn_Click(object sender, EventArgs e)
        {
            loadedOrder.Status = (Status)statusCb.SelectedIndex;
            AppDB.UpdateOrderStatus(loadedOrder);
            tabControl1.SelectedTab = tabControl1.TabPages[1];
            LoadOrderServices(null);
            UpdateOrdersTable(); 
        }
    }
}
