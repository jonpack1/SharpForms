using Microsoft.EntityFrameworkCore;
using OrderOptionsMaintenance.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderOptionsMaintenance
{
    public partial class frmOptionsMaint : Form
    {
        private OrderOptionsContext _context;
        private OrderOption _orderOption;

        public frmOptionsMaint()
        {
            InitializeComponent();
        }

        private void frmOptionsMaint_Load(object sender, EventArgs e)
        {
            _context = new OrderOptionsContext();
            _orderOption = _context.OrderOptions.Single();

            txtSalesTax.Text = _orderOption.SalesTaxRate.ToString();
            txtShipFirstBook.Text = _orderOption.FirstBookShipCharge.ToString();
            txtShipAddlBook.Text = _orderOption.AdditionalBookShipCharge.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                try
                {
                    _orderOption.SalesTaxRate = decimal.Parse(txtSalesTax.Text);
                    _orderOption.FirstBookShipCharge = decimal.Parse(txtShipFirstBook.Text);
                    _orderOption.AdditionalBookShipCharge = decimal.Parse(txtShipAddlBook.Text);

                    _context.SaveChanges();

                    MessageBox.Show("Order options updated successfully.");
                }
                catch (DbUpdateException ex)
                {
                    MessageBox.Show($"An error occurred while updating the database: {ex.Message}");
                }
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtSalesTax) &&
                   Validator.IsDecimal(txtSalesTax) &&
                   Validator.IsPresent(txtShipFirstBook) &&
                   Validator.IsDecimal(txtShipFirstBook) &&
                   Validator.IsPresent(txtShipAddlBook) &&
                   Validator.IsDecimal(txtShipAddlBook);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
