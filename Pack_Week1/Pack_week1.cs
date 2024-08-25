namespace Pack_Week1
{
    public partial class Pack_week1 : Form
    {
        public Pack_week1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            //create variables from converted textbox entries
            decimal milesPerDay = Convert.ToDecimal(totalMilesPerDay.Text);
            decimal galCost = Convert.ToDecimal(gallonCost.Text);
            decimal milePerGal = Convert.ToDecimal(MPG.Text);
            decimal tollFee = Convert.ToDecimal(tolls.Text);
            decimal parkingFee = Convert.ToDecimal(parking.Text);


           dailyTotal.Text = 
                ((((milesPerDay/milePerGal)*galCost) + tollFee + parkingFee)/100).ToString("c");
                //calc for total and displays 
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //option to exit program
        }

        /*
         collaborated with fellow classmates Luke Sewell and Carlos Garcia
         
         
         */
    }
}
