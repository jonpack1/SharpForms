namespace StateMaintenance
{
    partial class frmAddModify
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
            label1 = new System.Windows.Forms.Label();
            txtStateCode = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            txtStateName = new System.Windows.Forms.TextBox();
            btnSave = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(51, 52);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(165, 41);
            label1.TabIndex = 0;
            label1.Text = "State code:";
            // 
            // txtStateCode
            // 
            txtStateCode.Location = new System.Drawing.Point(238, 46);
            txtStateCode.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            txtStateCode.Name = "txtStateCode";
            txtStateCode.Size = new System.Drawing.Size(125, 47);
            txtStateCode.TabIndex = 1;
            txtStateCode.Tag = "State code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(51, 128);
            label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(173, 41);
            label2.TabIndex = 2;
            label2.Text = "State name:";
            // 
            // txtStateName
            // 
            txtStateName.Location = new System.Drawing.Point(238, 126);
            txtStateName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            txtStateName.Name = "txtStateName";
            txtStateName.Size = new System.Drawing.Size(252, 47);
            txtStateName.TabIndex = 3;
            txtStateName.Tag = "State name";
            // 
            // btnSave
            // 
            btnSave.Location = new System.Drawing.Point(51, 224);
            btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            btnSave.Name = "btnSave";
            btnSave.Size = new System.Drawing.Size(189, 68);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new System.Drawing.Point(304, 224);
            btnCancel.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new System.Drawing.Size(189, 68);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAddModify
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            CancelButton = btnCancel;
            ClientSize = new System.Drawing.Size(563, 339);
            ControlBox = false;
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtStateName);
            Controls.Add(label2);
            Controls.Add(txtStateCode);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddModify";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Add/Modify State";
            Load += frmAddModify_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStateCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStateName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}