namespace tic_taic
{


    public partial class Form1 : Form
    {
        bool turn = true;//true =xturn;false y turn;
        int turn_counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by eng Ramzi:","for more Detail contact us +252613962843");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "x";
            else
                b.Text = "o";



            turn = !turn;
            //disabling the button that user wont allow hin to change the his tap
            b.Enabled = false;
            turn_counter++;

            checkforwinner();

        }

        //method for cheking the winner
        private void checkforwinner()
        {
            bool there_is_awinner = false;

            //Horizontal winner cheking
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                there_is_awinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                there_is_awinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                there_is_awinner = true;

            //vertical winner cheking
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                there_is_awinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                there_is_awinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                there_is_awinner = true;
            //diagnol wnnier cheking
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                there_is_awinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C2.Enabled))
                there_is_awinner = true;
           




            if (there_is_awinner)
            {
                displaybutton();
                string winner = "";
                if (turn)
                    winner = "0";
                else
                    winner = "x";


                MessageBox.Show(winner + "wins!", "Yay!");
            }
            else
            {
                if (turn_counter == 9)
                    MessageBox.Show("its drow");
            }
            



        }
        private void displaybutton()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;

                }
            }
            catch { }
           
                

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turn_counter = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";

                }
            }
            catch { }


        }
    }
}