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
    public partial class MenuForm : Form
    {
        public static int lowerValue = 0;
        public static int upperValue = 0;

        public MenuForm()
        {
            InitializeComponent();
            Console.WriteLine("This is a test");
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnStartMenuForm_MouseOver(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGray;
        }

        private void BtnStartMenuForm_Click(object sender, EventArgs e)
        {
            if (InputTester.IsInteger(TxtBLowerValueMenuForm.Text))
            {
                lowerValue = int.Parse(TxtBLowerValueMenuForm.Text);

                if (InputTester.IsInteger(TxtBUpperValueMenuForm.Text))
                {
                    upperValue = int.Parse(TxtBUpperValueMenuForm.Text);

                    try
                    {
                        if (int.Parse(TxtBLowerValueMenuForm.Text) < int.Parse(TxtBUpperValueMenuForm.Text))
                        {
                            GameForm gameForm = new GameForm(lowerValue, upperValue);
                            DialogResult gameFormResult = gameForm.ShowDialog(this);

                            this.TxtBLowerValueMenuForm.Text = "";
                            this.TxtBUpperValueMenuForm.Text = "";
                        }
                        else
                        {
                            throw new InvalidRangeException();
                        }
                    }
                    catch (InvalidRangeException ex)
                    {
                        Console.WriteLine("The upper value is lower than the lower value");
                        InputTester.ExceptionHandler(ex, "");
                    }
                }
            }
        }
    }
}
