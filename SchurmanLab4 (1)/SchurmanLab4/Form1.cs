using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchurmanLab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Name: Kristian Schurman
        //Date: 2022/11/17
        //The purpose of this program is to calculate the price of a trip to Cuba, Mexico or Florida

        public void ResetTrip() //Hides Trip Information groupbox, checks Cuba radio button, blanks out People textbox and Price label, checks Credit Card radio button, and focuses the cursor on the People textbox
        {
            grpTripInformation.Hide();
            radCuba.Checked = true;
            txtPeople.Text = "";
            lblPrice.Text = "";
            radCreditCard.Checked = true;
            txtPeople.Focus();
        }

        public void SetFlight() //If the Florida radio button is selected, uncheck the Flight Included checkbox. Otherwise, Flight Included is checked
        {
            if (radFlorida.Checked == true)
            {
                chkFlightIncluded.Checked = false;
                chkFlightIncluded.Checked = true;
            }
                
            else
            {
                chkFlightIncluded.Checked = true;
                chkFlightIncluded.Checked = false;
            }
                
        }

        public void DisplayMsg(string msg, string title) //When called, displays the message box
        {
            MessageBox.Show(msg, title);
        }

        private void btnReset_Click(object sender, EventArgs e) //Does the Reset Trip function when reset is clicked
        {
            ResetTrip();
        }

        private void Form1_Load(object sender, EventArgs e) //Same as the last, but on form load
        {
            ResetTrip();
        }

        private void radCuba_CheckedChanged(object sender, EventArgs e) //Calls the Set Flight function when the Cuba radio button is checked
        {
            SetFlight();
        }

        private void radFlorida_CheckedChanged(object sender, EventArgs e) //Same as last, but for Florida
        {
            SetFlight();
        }

        private void radMexico_CheckedChanged(object sender, EventArgs e) //Same as last, but for Mexico
        {
            SetFlight();
        }

        private void btnBook_Click(object sender, EventArgs e) //On Book button click, it displays one of two error messages when the People textbox input is invalid. If the People textbox input is valid, it does the equation, displays the price in the Price label below, and displays the amount of people, the location, optionally displays flight included if the Flight checkbox was selected, optionally displays if the discount was applied if the Cash radio button was selected, and displays the price in the Trip Information groupbox. It also makes it so you can't interact with anything within the Book groupbox when the Book button is pressed. Also also, displays a special message if People was 1 or 3
        {
            int people;
            double moneyModifier;
            double locationModifier;
            double answer = 0;
            string locationText;
            string canFly;
            string discount;
            bool itsInt = int.TryParse(txtPeople.Text, out people);

            if (itsInt == false)
            {
                DisplayMsg("People must be a whole number", "Input Error"); //Displays if the People textbox is not an integer
                txtPeople.Focus();
                txtPeople.Clear();
            }

            else if (people < 1 || people > 10)
            {
                DisplayMsg("People must be between 1-10", "Input Error"); //Displays if the People textbox has an integer that's more than 10 or less than 1
                txtPeople.Focus();
                txtPeople.SelectAll();
            }

            else
            {
                if (radMexico.Checked)
                {
                    locationModifier = 2300.79;
                    locationText = "MEXICO";
                    canFly = "Flight Included";
                }
                else if (radFlorida.Checked)
                {
                    locationModifier = 2150.50;
                    locationText = "FLORIDA";
                    canFly = "";
                }
                else
                {
                    locationModifier = 2150.50;
                    locationText = "CUBA";
                    canFly = "Flight Included";
                }
                if (radCash.Checked == true)
                {
                    moneyModifier = locationModifier * people * 0.1;
                    discount = "Cash Discount Applied";
                }
                else
                {
                    moneyModifier = 0;
                    discount = "";
                }
                    answer = locationModifier * people - moneyModifier;

                lblPrice.Text = answer.ToString("N");

                lblTripInformation.Text = "Booked by Kristian Schurman \n \nPeople: " + people + "\nLocation: " + locationText +
                "\n" + canFly + discount + "\nPrice: $" + lblPrice.Text;

                

                grpTripInformation.Show();
                grpBook.Enabled = false;

                switch (people)
                {
                    case 1:
                    case 3:
                        DisplayMsg("Special when booking single or triple. \nBOGO Special - Call 555-1212 to recieve another person free!", "Limited Time Offer"); //The special message
                        break;

                }
            }

        }

        private void btnConfirm_Click(object sender, EventArgs e) //When the Confirm button is clicked, display this message, enable the Book groupbox, and resets everything
        {
            DisplayMsg("Trip booked and paid \nPrice: $" + lblPrice.Text, "Confirmation Email Sent");
            grpBook.Enabled = true;
            ResetTrip();
        }

    }
}