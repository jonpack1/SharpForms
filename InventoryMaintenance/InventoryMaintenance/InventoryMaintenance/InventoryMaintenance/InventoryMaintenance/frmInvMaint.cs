//jonpack
//worked with luke

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }

        private List<InvItem> invItems = null; //list to store items

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            invItems = InvItemDB.GetItems(); // gets items from invitemdb
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            lstItems.Items.Clear(); //clear items

            foreach (InvItem item in invItems)
            {
                lstItems.Items.Add(item.GetDisplayText());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewItem newItemForm = new frmNewItem();

            InvItem newItem = newItemForm.GetNewItem(); //instance of new item form

            if (newItem != null)
            {
                invItems.Add(newItem);
                InvItemDB.SaveItems(invItems);
                FillItemListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex; // get index of selected item
            if (i != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this item?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int selectedIndex = lstItems.SelectedIndex;

                    invItems.RemoveAt(selectedIndex);

                    InvItemDB.SaveItems(invItems);

                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
