namespace Pack_AirlineReservationSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(300, 20);
            label1.Text = "Please type 1 for First Class, 2 for Economy:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            // 
            // submitButton
            // 
            submitButton.Location = new Point(50, 150);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(75, 23);
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += new EventHandler(submitButton_Click);
            // 
            // Form1
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(submitButton);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Airline Reservation System";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private TextBox textBox1;
        private Button submitButton;
    }
}

