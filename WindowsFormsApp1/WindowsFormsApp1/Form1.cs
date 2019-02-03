using System;
using System.Windows.Forms;
using WindowsFormsApp1.Source.Forms;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void carteirasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWallet wallet = new FormWallet();
            wallet.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategory category = new FormCategory();
            category.Show();
        }
    }
}
