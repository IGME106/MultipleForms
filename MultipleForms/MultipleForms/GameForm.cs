using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 6 - Multiple Forms
/// Class Description   : The actual form wherein the game is played
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 2, 2018
/// Filename            : GameForm.cs
/// </summary>

namespace MultipleForms
{
    /// <summary>
    /// This is the actual form on which the game is played
    /// </summary>
    public partial class GameForm : Form
    {
        private int lowerValue;
        private int upperValue;
        private int guessValue;

        private Random random = new Random();                           // Create random number generator object

        /// <summary>
        /// Default constructor to initialize form components and start the timer
        /// </summary>
        public GameForm()
        {
            InitializeComponent();

            this.Timer1.Start();
        }

        /// <summary>
        /// Parameterized constructor to initialize form components and start the timer
        /// </summary>
        /// <param name="lowerValue">Lower bound for number guessing game</param>
        /// <param name="upperValue">Upper bound for number guessing game</param>
        public GameForm(int lowerValue, int upperValue)
        {
            InitializeComponent();

            this.LowerValue = lowerValue;
            this.UpperValue = upperValue;
            this.GuessValue = RandomNumber();

            this.Timer1.Start();
        }

        /// <summary>
        /// Create property for lower bound
        /// </summary>
        public int LowerValue
        {
            set { this.lowerValue = value; }
            get { return this.lowerValue; }
        }

        /// <summary>
        /// Create property for upper bound
        /// </summary>
        public int UpperValue
        {
            set { this.upperValue = value; }
            get { return this.upperValue; }
        }

        /// <summary>
        /// Create property for number to guess
        /// </summary>
        public int GuessValue
        {
            set { this.guessValue = value; }
            get { return this.guessValue; }
        }

        /// <summary>
        /// Change button color when mouse moves over
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void BtnOKGameForm_MouseOver(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        /// <summary>
        /// Start evaluation of guess
        /// </summary>
        /// <param name="sender">Object sending the event</param>
        /// <param name="e">Event details</param>
        private void BtnOKGameForm_Click(object sender, EventArgs e)
        {
            int inputValue = 0;

            if (InputTester.IsInteger(TxtBGuessGameForm.Text))          // Test if input is correct data type
            {
                inputValue = int.Parse(TxtBGuessGameForm.Text);

                try                                                     // Test if entered value is within specified bounds
                {
                    if ((inputValue < this.LowerValue) || (inputValue > this.UpperValue))
                        throw new ValueOutOfBoundsException();          // If not in bounds, throw exception
                }
                catch (ValueOutOfBoundsException ex)                    // Catch thrown exception and provide feedback to user
                {
                    Console.WriteLine("The player guess it outside of player defined bounds");
                    InputTester.ExceptionHandler(ex, "Your guess it outside of the bounds specified," +
                        "please try again.");
                }

                if (inputValue > this.GuessValue)                       // Test if the value is low, high or a winning number
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

                    DisplayLocalMessage("Win");                         // Display message box stating game was won
                    
                    this.Close();                                       // Close this form
                }
            }
        }

        /// <summary>
        /// Generates a random number
        /// </summary>
        /// <returns>random number generated</returns>
        private int RandomNumber()
        {
            return random.Next(this.LowerValue, (this.UpperValue + 1));
        }

        /// <summary>
        /// Configures and monitors the timer associated with the game.  Displays Game Over message when
        ///     timer runs out
        /// </summary>
        /// <param name="sender">Object throwing the event</param>
        /// <param name="e">Event details</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.ProgressBarGameForm.Value < 100)                   // While the counter has not reached 100, increment
            {
                this.ProgressBarGameForm.Increment(1);
            }
            else                                                        // Once the timer reaches 100, game over
            {
                this.Timer1.Stop();

                ListBoxGameForm.Items.Add("GAME OVER!!!");
                ListBoxGameForm.Items.Add("");

                DisplayLocalMessage("Loose");                           // Display message box stating game was lost

                this.Close();
            }
        }

        /// <summary>
        /// Definitions and messages for message box
        /// </summary>
        /// <param name="messageDefinition">Value to be evaluated by switch to determine which message to throw</param>
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

            MessageBox.Show(                                                // Display messagebox with specified characteristics
                text: messageString,
                caption: titleString,
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Exclamation
            );
        }
    }
}

