namespace StateMaintenance
{
    partial class frmStateMaintenance
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
            btnAdd = new System.Windows.Forms.Button();
            btnExit = new System.Windows.Forms.Button();
            dgvStates = new System.Windows.Forms.DataGridView();
            modifyButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            deleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            btnFirst = new System.Windows.Forms.Button();
            btnPrevious = new System.Windows.Forms.Button();
            btnNext = new System.Windows.Forms.Button();
            btnLast = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dgvStates).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.AutoSize = true;
            btnAdd.Location = new System.Drawing.Point(46, 670);
            btnAdd.Margin = new System.Windows.Forms.Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(189, 68);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new System.Drawing.Point(962, 670);
            btnExit.Margin = new System.Windows.Forms.Padding(5);
            btnExit.Name = "btnExit";
            btnExit.Size = new System.Drawing.Size(189, 68);
            btnExit.TabIndex = 4;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // dgvStates
            // 
            dgvStates.AllowUserToAddRows = false;
            dgvStates.AllowUserToDeleteRows = false;
            dgvStates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStates.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { modifyButtonColumn, deleteButtonColumn });
            dgvStates.Location = new System.Drawing.Point(124, 61);
            dgvStates.Name = "dgvStates";
            dgvStates.RowHeadersWidth = 102;
            dgvStates.Size = new System.Drawing.Size(950, 546);
            dgvStates.TabIndex = 5;
            dgvStates.CellClick += dgvStates_CellClick;
            // 
            // modifyButtonColumn
            // 
            modifyButtonColumn.HeaderText = "Modify";
            modifyButtonColumn.MinimumWidth = 12;
            modifyButtonColumn.Name = "modifyButtonColumn";
            modifyButtonColumn.UseColumnTextForButtonValue = true;
            modifyButtonColumn.Width = 250;
            // 
            // deleteButtonColumn
            // 
            deleteButtonColumn.HeaderText = "Delete";
            deleteButtonColumn.MinimumWidth = 12;
            deleteButtonColumn.Name = "deleteButtonColumn";
            deleteButtonColumn.UseColumnTextForButtonValue = true;
            deleteButtonColumn.Width = 250;
            // 
            // btnFirst
            // 
            btnFirst.Location = new System.Drawing.Point(404, 678);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new System.Drawing.Size(96, 53);
            btnFirst.TabIndex = 6;
            btnFirst.Text = "<<";
            btnFirst.UseVisualStyleBackColor = true;
            btnFirst.Click += btnFirst_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new System.Drawing.Point(506, 678);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new System.Drawing.Size(96, 53);
            btnPrevious.TabIndex = 7;
            btnPrevious.Text = "<";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new System.Drawing.Point(608, 678);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(96, 53);
            btnNext.TabIndex = 8;
            btnNext.Text = ">";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnLast
            // 
            btnLast.Location = new System.Drawing.Point(710, 678);
            btnLast.Name = "btnLast";
            btnLast.Size = new System.Drawing.Size(96, 53);
            btnLast.TabIndex = 9;
            btnLast.Text = ">>";
            btnLast.UseVisualStyleBackColor = true;
            btnLast.Click += btnLast_Click;
            // 
            // frmStateMaintenance
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            CancelButton = btnExit;
            ClientSize = new System.Drawing.Size(1200, 763);
            Controls.Add(btnLast);
            Controls.Add(btnNext);
            Controls.Add(btnPrevious);
            Controls.Add(btnFirst);
            Controls.Add(dgvStates);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Margin = new System.Windows.Forms.Padding(5);
            Name = "frmStateMaintenance";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "State Maintenance";
            Load += frmStateMaintenance_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStates).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvStates;
        private System.Windows.Forms.DataGridViewButtonColumn modifyButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteButtonColumn;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
    }
}

