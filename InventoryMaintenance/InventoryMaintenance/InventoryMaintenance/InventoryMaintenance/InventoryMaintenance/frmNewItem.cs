//jon pack

//worked eith luke

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmNewItem : Form
    {

        public frmNewItem()
        {
            InitializeComponent();
        }

        private InvItem invItem = null;

        public InvItem GetNewItem()
        {
            this.ShowDialog();
            return invItem;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsValidData()) // Validate the data
            {
                int ItemNum = int.Parse(txtItemNo.Text);
                string Desc = txtDescription.Text;
                decimal Cost = decimal.Parse(txtPrice.Text);

                invItem = new InvItem(ItemNum, Desc, Cost);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtItemNo) &&
                   Validator.IsInt32(txtItemNo) &&
                   Validator.IsPresent(txtDescription) &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
