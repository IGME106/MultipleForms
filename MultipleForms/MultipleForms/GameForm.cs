using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms
{
    public partial class GameForm : Form
    {
        private int lowerValue;
        private int upperValue;
        private int guessValue;

        private Random random = new Random();

        public GameForm()
        {
            InitializeComponent();

            this.Timer1.Start();
        }

        public GameForm(int lowerValue, int upperValue)
        {
            InitializeComponent();

            this.LowerValue = lowerValue;
            this.UpperValue = upperValue;
            this.GuessValue = RandomNumber();

            this.Timer1.Start();
        }

        public int LowerValue
        {
            set { this.lowerValue = value; }
            get { return this.lowerValue; }
        }

        public int UpperValue
        {
            set { this.upperValue = value; }
            get { return this.upperValue; }
        }

        public int GuessValue
        {
            set { this.guessValue = value; }
            get { return this.guessValue; }
        }

        private void BtnOKGameForm_Click(object sender, EventArgs e)
        {
            int inputValue = 0;

            if (InputTester.IsInteger(TxtBGuessGameForm.Text))
            {
                inputValue = int.Parse(TxtBGuessGameForm.Text);

                try
                {
                    if ((inputValue < this.LowerValue) || (inputValue > this.UpperValue))
                        throw new ValueOutOfBoundsException();
                }
                catch (ValueOutOfBoundsException ex)
                {
                    Console.WriteLine("The player guess it outside of player defined bounds");
                    InputTester.ExceptionHandler(ex, "Your guess it outside of the bounds specified," +
                        "please try again.");
                }

                if (inputValue > this.GuessValue)
                {
                    ListBoxGameForm.Items.Add("Your guess of " + inputValue + " was HIGH");
                    ListBoxGameForm.Items.Add("");
                }
                else if (inputValue < this.GuessValue)
                {
                    ListBoxGameForm.Items.Add("Your guess of " + inputValue + " was LOW");
                    ListBoxGameForm.Items.Add("");
                }
                else if (inputValue == this.GuessValue)
                {
                    ListBoxGameForm.Items.Add("CONGRATULATIONS!!! YOU WON!!!");
                    ListBoxGameForm.Items.Add("");

                    this.Timer1.Stop();

                    DisplayLocalMessage("Win");
                    
                    this.Close();
                }
            }
        }

        private int RandomNumber()
        {
            return random.Next(this.LowerValue, (this.UpperValue + 1));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.ProgressBarGameForm.Value < 100)
            {
                this.ProgressBarGameForm.Increment(1);
            }
            else
            {
                this.Timer1.Stop();

                ListBoxGameForm.Items.Add("GAME OVER!!!");
                ListBoxGameForm.Items.Add("");

                DisplayLocalMessage("Loose");

                this.Close();
            }
        }

        public static void DisplayLocalMessage(string messageDefinition)
        {
            string messageString = "default";
            string titleString = "GAME OVER!!!";

            switch (messageDefinition)
            {
                case "Win":
                    messageString = "CONGRATULATIONS!!! YOU WIN!!!";

                    break;
                case "Loose":
                    messageString = "YOU LOOSE!!!";

                    break;
                default:
                    break;
            }

            MessageBox.Show(
                text: messageString,
                caption: titleString,
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Exclamation
            );
        }
    }
}

