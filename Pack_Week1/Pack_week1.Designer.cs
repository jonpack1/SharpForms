namespace Pack_Week1
{
    partial class Pack_week1
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
            totalMilesPerDay = new TextBox();
            gallonCost = new TextBox();
            MPG = new TextBox();
            parking = new TextBox();
            tolls = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            exitBtn = new Button();
            dailyTotal = new TextBox();
            label6 = new Label();
            calcbtn = new Button();
            SuspendLayout();
            // 
            // totalMilesPerDay
            // 
            totalMilesPerDay.Location = new Point(275, 86);
            totalMilesPerDay.Name = "totalMilesPerDay";
            totalMilesPerDay.Size = new Size(100, 23);
            totalMilesPerDay.TabIndex = 0;
            // 
            // gallonCost
            // 
            gallonCost.Location = new Point(275, 143);
            gallonCost.Name = "gallonCost";
            gallonCost.Size = new Size(100, 23);
            gallonCost.TabIndex = 1;
            // 
            // MPG
            // 
            MPG.Location = new Point(275, 192);
            MPG.Name = "MPG";
            MPG.Size = new Size(100, 23);
            MPG.TabIndex = 2;
            // 
            // parking
            // 
            parking.Location = new Point(275, 246);
            parking.Name = "parking";
            parking.Size = new Size(100, 23);
            parking.TabIndex = 3;
            // 
            // tolls
            // 
            tolls.Location = new Point(275, 299);
            tolls.Name = "tolls";
            tolls.Size = new Size(100, 23);
            tolls.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 86);
            label1.Name = "label1";
            label1.Size = new Size(141, 15);
            label1.TabIndex = 5;
            label1.Text = "Total miles driven per day";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(90, 143);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 6;
            label2.Text = "Cost per gallon of gas¢";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 192);
            label3.Name = "label3";
            label3.Size = new Size(137, 15);
            label3.TabIndex = 7;
            label3.Text = "Average miles per gallon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 246);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 8;
            label4.Text = "parking fees per day ¢";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 299);
            label5.Name = "label5";
            label5.Size = new Size(81, 15);
            label5.TabIndex = 9;
            label5.Text = "Tolls per day ¢";
            // 
            // exitBtn
            // 
            exitBtn.Location = new Point(551, 303);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(75, 23);
            exitBtn.TabIndex = 11;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // dailyTotal
            // 
            dailyTotal.Location = new Point(275, 359);
            dailyTotal.Name = "dailyTotal";
            dailyTotal.ReadOnly = true;
            dailyTotal.Size = new Size(100, 23);
            dailyTotal.TabIndex = 12;
            dailyTotal.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 359);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 13;
            label6.Text = "Total cost per day";
            // 
            // calcbtn
            // 
            calcbtn.Location = new Point(479, 143);
            calcbtn.Name = "calcbtn";
            calcbtn.Size = new Size(211, 40);
            calcbtn.TabIndex = 14;
            calcbtn.Text = "Calculate";
            calcbtn.UseVisualStyleBackColor = true;
            calcbtn.Click += calcbtn_Click;
            // 
            // Pack_week1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(calcbtn);
            Controls.Add(label6);
            Controls.Add(dailyTotal);
            Controls.Add(exitBtn);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tolls);
            Controls.Add(parking);
            Controls.Add(MPG);
            Controls.Add(gallonCost);
            Controls.Add(totalMilesPerDay);
            Name = "Pack_week1";
            Text = "Daily Driver Expense Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox totalMilesPerDay;
        private TextBox gallonCost;
        private TextBox MPG;
        private TextBox parking;
        private TextBox tolls;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button exitBtn;
        private TextBox dailyTotal;
        private Label label6;
        private Button calcbtn;
    }
}
