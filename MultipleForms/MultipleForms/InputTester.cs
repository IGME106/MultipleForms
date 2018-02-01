using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace MultipleForms {
    public class InputTester {

        public static bool IsInteger(string testValue) {

            bool returnValue = false;

            try {
                int convertedValue = int.Parse(testValue);

                returnValue = true;
            } catch (Exception e) {
                Console.WriteLine(e.ToString());
                ExceptionHandler(e, "Integer");
            }

            return returnValue;
        }

        public static void ExceptionHandler(Exception e, String requirement) {

            string myException = e.GetType().Name;

            switch (myException) {
                case "FormatException":

                    DisplayMessage("InvalidType", requirement);

                    break;
                case "InvalidRangeException":

                    DisplayMessage("InvalidRange", requirement);

                    break;
                default:
                    break;
            }
        }

        public static void DisplayMessage(string messageDefinition, string requirement) {

            string messageString = "default";

            switch (messageDefinition) {
                case "InvalidType":
                    messageString = "The values entered are not of type " +
                        requirement + ", please try again";

                    break;
                case "InvalidRange":
                    messageString = "Your upper value should be higher than your lower value" +
                        ", please try again";

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
    
    public class InvalidRangeException : Exception {

        const string name = "InvalidRangeException";

        public InvalidRangeException()
            : base() { }

        public InvalidRangeException(string message)
            : base(message) { }
    }
}
