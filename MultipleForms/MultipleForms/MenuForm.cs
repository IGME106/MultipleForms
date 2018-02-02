using System;
using System.Drawing;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 6 - Multiple Forms
/// Class Description   : Main class and main menu for a number guessing game
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 2, 2018
/// Filename            : MenuForm.cs
/// </summary>

namespace MultipleForms
{
    /// <summary>
    /// This is the startup menu and main launch form for a number guessing game
    /// </summary>
    public partial class MenuForm : Form
    {
        public static int lowerValue = 0;                   // Define upper and lower values for game
        public static int upperValue = 0;

        /// <summary>
        /// Initialize form components
        /// </summary>
        public MenuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Change button color when mouse moves over
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void BtnStartMenuForm_MouseOver(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        /// <summary>
        /// Confirms that the values entered are correct and launches the actual game 
        ///     window
        /// </summary>
        /// <param name="sender">Object calling the event</param>
        /// <param name="e">Arguments passed by the event</param>
        private void BtnStartMenuForm_Click(object sender, EventArgs e)
        {
            if (InputTester.IsInteger(TxtBLowerValueMenuForm.Text))         // Test if lower value is correct data type
            {
                lowerValue = int.Parse(TxtBLowerValueMenuForm.Text);

                if (InputTester.IsInteger(TxtBUpperValueMenuForm.Text))     // Test if upper value is correct data type
                {
                    upperValue = int.Parse(TxtBUpperValueMenuForm.Text);

                    try
                    {                                                       // Test if the bounds contain a valid range
                        if (int.Parse(TxtBLowerValueMenuForm.Text) < int.Parse(TxtBUpperValueMenuForm.Text))
                        {                                                   // Launch the game form
                            GameForm gameForm = new GameForm(lowerValue, upperValue);
                            DialogResult gameFormResult = gameForm.ShowDialog(this);

                            this.TxtBLowerValueMenuForm.Text = "1";          // Reset menu form values after game completes
                            this.TxtBUpperValueMenuForm.Text = "10";
                        }
                        else
                        {
                            throw new InvalidRangeException();              // If the range is invalid, throw exception
                        }
                    }
                    catch (InvalidRangeException ex)                        // Catch exception and launch exception handler
                    {                                                           // with error message
                        Console.WriteLine("The upper value is lower than the lower value");
                        InputTester.ExceptionHandler(ex, "");
                    }
                }
            }
        }
    }
}
