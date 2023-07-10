using Application.Service;
using Application.Service.OrdersActions;
using Domain.Models;
using Infrastructure.Repository;

namespace Sklad
{
    public partial class Sklad : Form
    {
        private ProviderActions provider;
        private CustomerActions customer;
        private ProductActions product;
        private MyOrderActions myOrder;
        private UnitOfWork unitOFwork;
        int providerId = -1;
        int customerId = -1;
        int productId = -1;
        public Sklad()
        {
            InitializeComponent();

            productProvider_txb.DropDownStyle = ComboBoxStyle.DropDownList;
            buyProductProduct_txb.DropDownStyle = ComboBoxStyle.DropDownList;

            unitOFwork = new UnitOfWork();
            provider = new ProviderActions(unitOFwork);
            customer = new CustomerActions(unitOFwork);
            product = new ProductActions(unitOFwork);
            myOrder = new MyOrderActions(unitOFwork);
            SetLists();
        }

        void SetLists()
        {
            provider_list.DataSource = provider.GetAll();
            customer_list.DataSource = customer.GetAll();
            product_list.DataSource = product.GetAll();
            buyProduct_list.DataSource = myOrder.GetAll();
            productProvider_txb.DataSource = provider.GetAll().Select(x => x.Name).ToList();
            buyProductProduct_txb.DataSource = product.GetAll().Select(x => x.Name).ToList();
        }
        void ProviderReset()
        {
            providerName_txb.Text = string.Empty;
            providerPhone_txb.Text = string.Empty;
        }
        void CustomerReset()
        {
            customerName_txb.Text = string.Empty;
            customerPhone_txb.Text = string.Empty;
        }
        void ProductReset()
        {
            productName_txb.Text = string.Empty;
            productProvider_txb.Text = string.Empty;
        }
        void MyOrderReset()
        {
            buyProductPrice_txb.Text = string.Empty;
            buyProductProduct_txb.Text = string.Empty;
            buyProductQuantity_txb.Text = string.Empty;
            buyProductSellingPrice_txb.Text = string.Empty;
        }

        private void addProvider_btn_Click(object sender, EventArgs e)
        {
            if (providerId != -1)
            {
                MessageBox.Show("Can not add, provider exists in the database");
                return;
            }
            Provider provider1 = new Provider()
            {
                Name = providerName_txb.Text,
                Phone = providerPhone_txb.Text
            };
            provider.Add(provider1);
            SetLists();
            ProviderReset();
        }
        private void updateProvider_btn_Click(object sender, EventArgs e)
        {
            if (providerId == -1)
            {
                MessageBox.Show("Provider not selected");
                return;
            }
            var pro = new Provider()
            {
                Id = providerId,
                Name = providerName_txb.Text,
                Phone = providerPhone_txb.Text
            };
            provider.Update(pro);
            SetLists();
            ProviderReset();
            providerId = -1;
        }
        private void provider_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            providerId = Convert.ToInt32(provider_list.CurrentRow.Cells[0].Value);
            providerName_txb.Text = provider_list.CurrentRow.Cells[1].Value.ToString();
            providerPhone_txb.Text = provider_list.CurrentRow.Cells[2].Value.ToString();
        }
        private void removeProvider_btn_Click(object sender, EventArgs e)
        {
            if (providerId == -1)
            {
                MessageBox.Show("Provider not selected");
                return;
            }
            provider.Remove(providerId);
            SetLists();
            ProviderReset();
            providerId = -1;
        }


        private void addCustomer_btn_Click(object sender, EventArgs e)
        {

            if (customerId != -1)
            {
                MessageBox.Show("Can not add, customer already exists in the database");
                return;
            }
            Customer customer1 = new Customer()
            {
                Name = customerName_txb.Text,
                Phone = customerPhone_txb.Text
            };
            customer.Add(customer1);
            SetLists();
            CustomerReset();
        }
        private void customer_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            customerId = Convert.ToInt32(customer_list.CurrentRow.Cells[0].Value);
            customerName_txb.Text = customer_list.CurrentRow.Cells[1].Value.ToString();
            customerPhone_txb.Text = customer_list.CurrentRow.Cells[2].Value.ToString();
        }
        private void updateCustomer_btn_Click(object sender, EventArgs e)
        {
            if (customerId == -1)
            {
                MessageBox.Show("Customer not selected");
                return;
            }
            var cus = new Customer()
            {
                Id = customerId,
                Name = customerName_txb.Text,
                Phone = customerPhone_txb.Text
            };
            customer.Update(cus);
            SetLists();
            CustomerReset();
            customerId = -1;
        }
        private void removeCustomer_btn_Click(object sender, EventArgs e)
        {
            if (customerId == -1)
            {
                MessageBox.Show("Customer not selected");
                return;
            }
            customer.Remove(customerId);
            SetLists();
            CustomerReset();
            customerId = -1;
        }


        private void addProduct_btn_Click(object sender, EventArgs e)
        {
            if (productId != -1)
            {
                MessageBox.Show("Can not add, product already exists in the database");
                return;
            }
            var prov = (from p in provider.GetAll()
                        where p.Name == productProvider_txb.Text
                        select p).FirstOrDefault();
            if (prov == null)
            {
                MessageBox.Show("Provider not found");
                return;
            }
            var product1 = new Product()
            {
                Name = productName_txb.Text,
                ProviderId = prov.Id
            };
            product.Add(product1);
            SetLists();
            ProductReset();
        }
        private void updateProduct_btn_Click(object sender, EventArgs e)
        {
            if (productId == -1)
            {
                MessageBox.Show("Product not selected");
                return;
            }
            var pro = new Product()
            {
                Id = productId,
                Name = productName_txb.Text,
                ProviderId = (from p in provider.GetAll()
                              where p.Name == productProvider_txb.Text
                              select p.Id).FirstOrDefault()
            };
            product.Update(pro);
            SetLists();
            ProductReset();
            productId = -1;
        }
        private void product_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productId = Convert.ToInt32(product_list.CurrentRow.Cells[0].Value);
            productName_txb.Text = product_list.CurrentRow.Cells[1].Value.ToString();
            productProvider_txb.Text = product_list.CurrentRow.Cells[2].Value.ToString();
        }
        private void removeProduct_btn_Click(object sender, EventArgs e)
        {
            if (productId == -1)
            {
                MessageBox.Show("Product not selected");
                return;
            }
            product.Remove(productId);
            SetLists();
            ProductReset();
            productId = -1;
        }

        private void buyProduct_btn_Click(object sender, EventArgs e)
        {
            var order = new MyOrder()
            {
                ProductId = (from p in product.GetAll()
                             where p.Name == buyProductProduct_txb.Text
                             select p.Id).FirstOrDefault(),
                Quantity = Convert.ToInt32(buyProductQuantity_txb.Text),
                Price = Convert.ToInt32(buyProductPrice_txb.Text),
                SellingPrice = Convert.ToInt32(buyProductSellingPrice_txb.Text)
            };

            myOrder.Add(order);
            SetLists();
            MyOrderReset();
        }
    }
}