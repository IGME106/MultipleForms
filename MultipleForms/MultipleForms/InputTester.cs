using System;
using System.Windows.Forms;

/// <summary>
/// IGME-106 - Game Development and Algorithmic Problem Solving
/// Practice Exercise 6 - Multiple Forms
/// Class Description   : Tests whether a value is of type int and provides appropriate error handling
///                         if it is not
/// Author              : Benjamin Kleynhans
/// Modified By         : Benjamin Kleynhans
/// Date                : February 2, 2018
/// Filename            : InputTester.cs
/// </summary>

namespace MultipleForms
{
    /// <summary>
    /// Tests input data type
    /// </summary>
    public class InputTester
    {
        /// <summary>
        /// Tests if the supplied value is an integer, throws exception if it is not
        /// </summary>
        /// <param name="testValue">The value to be tested</param>
        /// <returns>true if it is an integer, false if it is not</returns>
        public static bool IsInteger(string testValue)
        {
            bool returnValue = false;

            try
            {
                int convertedValue = int.Parse(testValue);

                returnValue = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                ExceptionHandler(e, "Integer");
            }

            return returnValue;
        }

        /// <summary>
        /// Handles exceptions
        /// </summary>
        /// <param name="e">The exception instance to be handled</param>
        /// <param name="requirement">Message parameters based on exception</param>
        public static void ExceptionHandler(Exception e, String requirement)
        {
            string myException = e.GetType().Name;

            switch (myException)
            {
                case "FormatException":

                    DisplayMessage("InvalidType", requirement);

                    break;
                case "InvalidRangeException":

                    DisplayMessage("InvalidRange", requirement);

                    break;
                case "ValueOutOfBoundsException":

                    DisplayMessage("OutOfBounds", requirement);

                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Displays the exception message box using supplied parameters
        /// </summary>
        /// <param name="messageDefinition">Index for use with the switch statement</param>
        /// <param name="requirement">Parameter or message to be used in exception</param>
        public static void DisplayMessage(string messageDefinition, string requirement)
        {
            string messageString = "default";

            switch (messageDefinition)
            {
                case "InvalidType":
                    messageString = "The values entered are not of type " +
                        requirement + ", please try again";

                    break;
                case "InvalidRange":
                    messageString = "Your upper value should be higher than your lower value" +
                        ", please try again";

                    break;
                case "OutOfBounds":
                    messageString = requirement;

                    break;
                default:
                    break;
            }

            MessageBox.Show(
                text: messageString,
                caption: messageDefinition,
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Exclamation
            );
        }
    }

    /// <summary>
    /// Tests whether the lower range is lower than the upper range and that the 
    ///     upper range is higher than the lower range
    /// </summary>
    public class InvalidRangeException : Exception
    {
        const string name = "InvalidRangeException";

        public InvalidRangeException()
            : base() { }

        public InvalidRangeException(string message)
            : base(message) { }
    }

    /// <summary>
    /// New exception type used to confirm if entered value is within lower and upper ranges
    ///     as provided by the player
    /// </summary>
    public class ValueOutOfBoundsException: Exception
    {
        const string name = "ValueOutOfBoundsException";

        public ValueOutOfBoundsException()
            : base() { }

        public ValueOutOfBoundsException(string message)
            : base(message) { }
    }
}
