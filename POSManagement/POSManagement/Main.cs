using System.Diagnostics;
using System.Xml.Linq;

namespace POSManagement;

public partial class Main : Form
{

    private IMainStoreAccess _storeAccess;
    private MainStore mainStore;

    public Main()
    {
        InitializeComponent();
        btnAdjust.Enabled = false;
        btnRemove.Enabled = false;
        _storeAccess = new MainStoreAccess(new SqlAccess(new XmlAccess()));

    }

    private void ClearForm()
    {
        txtproductID.Text = string.Empty;
        txtproductName.Text = string.Empty;
        txtPrice.Text = string.Empty;
        txtPriceUnit.Text = string.Empty;
        txtRemainingStock.Text = string.Empty;
        txtStockUnit.Text = string.Empty;
        dataGridView1.ClearSelection();

        btnAdjust.Enabled = false;
        btnRemove.Enabled = false;
    }

    private async void btnAddProduct_Click(object sender, EventArgs e)
    {
        mainStore = new MainStore
        {

            ProductId = int.Parse(txtproductID.Text),
            ProductName = txtproductName.Text,
            Price = decimal.Parse(txtPrice.Text),
            PriceUnit = txtPriceUnit.Text,
            RemainingStock = int.Parse(txtRemainingStock.Text),
            StockUnit = txtStockUnit.Text
        };

        try
        {
            await _storeAccess.AddNewProduct(mainStore);
            await LoadProducts();
            ClearForm();
        }
        catch (Exception ex)
        {

            MessageBox.Show($"An error occurred: {ex.Message}");
        }
    }
    private async Task LoadProducts()
    {
        try
        {
            var products = await _storeAccess.GetAllProduct();
            if (products != null && products.Any())
            {
                dataGridView1.DataSource = products;
                dataGridView1.Refresh();
            }
            else
            {
                MessageBox.Show("No products available or failed to load products.");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occurred while loading products: {ex.Message}");
        }
    }
    private async void Main_Load(object sender, EventArgs e)
    {
        await LoadProducts();
    }

    private async void btnRemove_Click(object sender, EventArgs e)
    {
        try
        {
            await _storeAccess.RemoveProduct(int.Parse(txtproductID.Text));
            MessageBox.Show("Done!!");
            await LoadProducts();
            ClearForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }


    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            btnAdjust.Enabled = true;
            btnRemove.Enabled = true;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtproductID.Text = row.Cells[0].Value.ToString();
            txtproductName.Text = row.Cells[1].Value.ToString();
            txtPrice.Text = row.Cells[2].Value.ToString();
            txtPriceUnit.Text = row.Cells[3].Value.ToString();
            txtRemainingStock.Text = row.Cells[4].Value.ToString();
            txtStockUnit.Text = row.Cells[5].Value.ToString();
        }
        else
        {
            btnAdjust.Enabled = false;
            btnRemove.Enabled = false;
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        ClearForm();
        MessageBox.Show("Clear Form is done");
    }

    private async void btnAdjust_Click(object sender, EventArgs e)
    {
        mainStore = new MainStore
        {

            ProductId = int.Parse(txtproductID.Text),
            ProductName = txtproductName.Text,
            Price = decimal.Parse(txtPrice.Text),
            PriceUnit = txtPriceUnit.Text,
            RemainingStock = int.Parse(txtRemainingStock.Text),
            StockUnit = txtStockUnit.Text
        };

        try
        {
            await _storeAccess.AdjustProductDetail(int.Parse(txtproductID.Text), mainStore);
            MessageBox.Show("Done!!");
            await LoadProducts();
            ClearForm();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
}
