using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleForms {
    public partial class GameForm : Form {
        public GameForm() {
            InitializeComponent();
        }

        private void BtnOKGameForm_Click(object sender, EventArgs e) {

            int inputValue = 0;

            if (InputTester.IsInteger(TxtBGuessGameForm.Text)) {
                inputValue = int.Parse(TxtBGuessGameForm.Text);
            }
            
            if (inputValue > MenuForm.lowerValue) {

            } else if (inputValue < MenuForm.lowerValue) {

            }
        }
    }
}
