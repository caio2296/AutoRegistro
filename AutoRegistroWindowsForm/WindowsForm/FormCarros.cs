using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace AutoRegistro
{
    public partial class FormCarros : Form
    {
        public FormCarros()
        {
            InitializeComponent();
            this.lblCadastroCarros.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            this.FormClosed += FormCarros_FormClosed;
        }
        private void FormCarros_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();
        }

        private void FormCarros_Load(object sender, EventArgs e)
        {

        }
    }
}
