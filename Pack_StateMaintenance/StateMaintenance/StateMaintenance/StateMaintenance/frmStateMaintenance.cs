using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using StateMaintenance.Models;

namespace StateMaintenance
{
    public partial class frmStateMaintenance : Form
    {
        public frmStateMaintenance()
        {
            InitializeComponent();
        }

        MMABooksContext context = new MMABooksContext();
        State selectedState = null;

        // private constants for the index values of the Modify and Delete button columns
        private const int ModifyButtonColumnIndex = 2;
        private const int DeleteButtonColumnIndex = 3;
        private const int RowsPerPage = 10;
        private int totalRows;              
        private int totalPages;              
        private int currentPage = 1;


        private void frmStateMaintenance_Load(object sender, EventArgs e)
        {
            totalRows = context.States.Count();           // Calculate total rows
            totalPages = (int)Math.Ceiling((double)totalRows / RowsPerPage); // Calculate total pages
            currentPage = 1;                              // Start at the first page
            DisplayStates();
        }

        private void DisplayStates()
        {
            int skip = (currentPage - 1) * RowsPerPage; // Calculate number of rows to skip

            // Set up data source first
            var states = context.States
                       .OrderBy(s => s.StateName)
                       .Skip(skip)
                       .Take(RowsPerPage)
                       .Select(s => new { s.StateCode, s.StateName })
                       .ToList();

            dgvStates.DataSource = states;

            // Clear existing button columns to prevent duplicates
            dgvStates.Columns.Remove("ModifyButtonColumn");
            dgvStates.Columns.Remove("DeleteButtonColumn");

            // Add Modify button column
            DataGridViewButtonColumn modifyButtonColumn = new DataGridViewButtonColumn();
            modifyButtonColumn.Name = "ModifyButtonColumn";
            modifyButtonColumn.HeaderText = "Modify";
            modifyButtonColumn.Text = "Modify";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            dgvStates.Columns.Add(modifyButtonColumn);

            // Add Delete button column
            DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn();
            deleteButtonColumn.Name = "DeleteButtonColumn";
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.Text = "Delete";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            dgvStates.Columns.Add(deleteButtonColumn);

            dgvStates.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            EnableDisableButtons();
        }

        private void EnableDisableButtons()
        {
            btnFirst.Enabled = currentPage > 1;
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }


        private void ModifyState()
        {
            var modifyForm = new frmAddModify()
            {
                AddState = false,
                State = selectedState
            };

            DialogResult result = modifyForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                using (var context = new MMABooksContext())
                {
                    try
                    {
                        var stateToModify = context.States.Find(modifyForm.State.StateCode);
                        if (stateToModify != null)
                        {
                            stateToModify.StateName = modifyForm.State.StateName;
                            context.SaveChanges();
                        }
                        selectedState = null;
                        DisplayStates(); 
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        HandleConcurrencyError(ex);
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDatabaseError(ex);
                    }
                    catch (Exception ex)
                    {
                        HandleGeneralError(ex);
                    }
                }
            }
        }


        private void DeleteState()
        {
            if (selectedState == null) return;

            DialogResult result = MessageBox.Show($"Delete {selectedState.StateName.Trim()}?",
                                                  "Confirm Delete",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (var context = new MMABooksContext())
                {
                    try
                    {
                        var stateToDelete = context.States.Find(selectedState.StateCode);
                        if (stateToDelete != null)
                        {
                            context.States.Remove(stateToDelete);
                            context.SaveChanges();
                        }
                        selectedState = null;
                        DisplayStates(); // Refresh with the main context
                    }
                    catch (DbUpdateConcurrencyException ex)
                    {
                        HandleConcurrencyError(ex);
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDatabaseError(ex);
                    }
                    catch (Exception ex)
                    {
                        HandleGeneralError(ex);
                    }
                }
            }
        }




        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MMABooksContext())
            {
                var addForm = new frmAddModify
                {
                    AddState = true,
                    State = new State()
                };

                DialogResult result = addForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        context.States.Add(addForm.State);
                        context.SaveChanges();
                        DisplayStates(); 
                    }
                    catch (DbUpdateException ex)
                    {
                        HandleDatabaseError(ex);
                    }
                    catch (Exception ex)
                    {
                        HandleGeneralError(ex);
                    }
                }
            }
        }

        private void dgvStates_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;  

            selectedState = context.States
                                  .Where(s => s.StateCode == dgvStates.Rows[e.RowIndex].Cells[0].Value.ToString())
                                  .FirstOrDefault();

            if (e.ColumnIndex == ModifyButtonColumnIndex)
            {
                ModifyState();
            }
            else if (e.ColumnIndex == DeleteButtonColumnIndex)
            {
                DeleteState();
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            DisplayStates();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                DisplayStates();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
            {
                currentPage++;
                DisplayStates();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            currentPage = totalPages;
            DisplayStates();
        }


        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)
        {
            ex.Entries.Single().Reload();
            var entityState = context.Entry(selectedState).State;
            if (entityState == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that state.",
                "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that state.\n" +
                "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            DisplayStates();
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE: " + error.Number + " " +
                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
