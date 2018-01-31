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
    public partial class MenuForm : Form {
        public MenuForm() {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e) {

        }

        private void BtnStartMenuForm_MouseOver(object sender, EventArgs e) {
            this.BackColor = Color.LightGray;
        }

        private void BtnStartMenuForm_Click(object sender, EventArgs e) {

        }

        private void RichTxtBDescrMenuForm_TextChanged(object sender, EventArgs e) {

        }
    }
}
