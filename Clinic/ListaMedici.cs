using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinica_Eva
{
    public partial class ListaMedici : Form
    {
        public ListaMedici()
        {
            InitializeComponent();
        }

        private void ListaMedici_Load(object sender, EventArgs e)
        {

        }

        private void ListaMedici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
