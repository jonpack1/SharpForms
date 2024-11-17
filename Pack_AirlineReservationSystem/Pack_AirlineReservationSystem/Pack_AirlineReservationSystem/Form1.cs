
using System;
using System.Windows.Forms;

//worked with luke

namespace Pack_AirlineReservationSystem
{
    public partial class Form1 : Form
    {
        bool[] seats = new bool[10]; //1d bool array

        public Form1()
        {
            InitializeComponent();
        }

        
        private void submitButton_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text; //get the user input
            if (input == "1")
            {
                AssignSeat(1); //first class
            }
            else if (input == "2")
            {
                AssignSeat(2); //economy class
            }
            else
            {
                label1.Text = "Invalid input. Please type 1 for First Class or 2 for Economy.";
            }
        }

        private void AssignSeat(int classType)
        {
            if (classType == 1)
            {
                //assign seats 1 to 5 
                for (int i = 0; i < 5; i++)
                {
                    if (!seats[i])
                    {
                        seats[i] = true;
                        label1.Text = "Seat " + (i + 1) + " (First Class) assigned.";
                        return;
                    }
                }
                AskForEconomy();
            }
            else if (classType == 2)
            {
                //assign seats 6 to 10 
                for (int i = 5; i < 10; i++)
                {
                    if (!seats[i])
                    {
                        seats[i] = true;
                        label1.Text = "Seat " + (i + 1) + " (Economy Class) assigned.";
                        return;
                    }
                }
                AskForFirstClass();
            }
        }

        private void AskForEconomy()
        {
            DialogResult result = MessageBox.Show("First class is full. Would you like to be placed in Economy?",
                "Seats Full", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                AssignSeat(2); //try to assign an economy seat
            }
            else
            {
                label1.Text = "Next flight leaves in 3 hours.";
            }
        }

        private void AskForFirstClass()
        {
            DialogResult result = MessageBox.Show("Economy class is full. Would you like to be placed in First Class?",
                "Seats Full", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                AssignSeat(1); //try to assign a first-class seat
            }
            else
            {
                label1.Text = "Next flight leaves in 3 hours.";
            }
        }
    }
}

