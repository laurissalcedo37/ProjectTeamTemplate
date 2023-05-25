using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk_JimDeMordaunt
{
    public partial class ViewAllQuotes : Form
    {
        List<DeskQuote> deskQuotesList;
        public ViewAllQuotes(List<DeskQuote> deskQuotes)
        {
            InitializeComponent();
            deskQuotesList = deskQuotes;
            //dataGridView1.DataSource = deskQuotesList;
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.ColumnHeadersVisible = true;
            // Set the column header names.
            dataGridView1.Columns[0].Name = "Full name";
            dataGridView1.Columns[1].Name = "Price";
            dataGridView1.Columns[2].Name = "Width";
            dataGridView1.Columns[3].Name = "Depth";
            dataGridView1.Columns[4].Name = "Num of drawers";
            dataGridView1.Columns[5].Name = "Material";
            dataGridView1.Columns[6].Name = "Rush order";
            
            //dataGridView1.DataSource = deskQuotesList;
            for (var i = 0; i < deskQuotesList.Count; i++)
            {
                string[] quote = { deskQuotesList[i].fullName, deskQuotesList[i].quote.ToString(),
                    deskQuotesList[i].newDesk.width.ToString(), deskQuotesList[i].newDesk.depth.ToString(), deskQuotesList[i].newDesk.numDrawers.ToString(), deskQuotesList[i].newDesk.desktop.ToString(),
                    deskQuotesList[i].rushDays};
                
                dataGridView1.Rows.Add(quote);
            }

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
