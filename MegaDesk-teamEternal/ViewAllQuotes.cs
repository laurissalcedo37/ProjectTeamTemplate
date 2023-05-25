using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_JimDeMordaunt
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
           
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {


        }

        private void AllQuotesToMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

        }

        private void GridAllQuotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
