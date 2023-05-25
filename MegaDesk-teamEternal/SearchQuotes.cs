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
    public partial class SearchQuotes : Form
    {
        List<DeskQuote> deskQuotesList;
        public SearchQuotes(List<DeskQuote> deskQuotesList)
        {
            InitializeComponent();
            this.deskQuotesList = deskQuotesList;
            for (var i=0; i < deskQuotesList.Count; i++)
            {
                string[] quote = { deskQuotesList[i].fullName, deskQuotesList[i].quote.ToString(), 
                    deskQuotesList[i].newDesk.width.ToString(), deskQuotesList[i].newDesk.depth.ToString(), deskQuotesList[i].newDesk.numDrawers.ToString(), deskQuotesList[i].newDesk.desktop.ToString(),
                    deskQuotesList[i].rushDays};
                var listQuote = new ListViewItem(quote);
                listView1.Items.Add(listQuote);
            }
        }

        private void SearchToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            var search = searchBox.Text;
            Console.WriteLine(search.GetType());
            Console.WriteLine("value: "+search);
            if (search != null && search != "")
            {
                for (var i = 0; i < deskQuotesList.Count; i++)
                {
                    if (deskQuotesList[i].newDesk.desktop.ToString() == search)
                    {
                        string[] quote = { deskQuotesList[i].fullName, deskQuotesList[i].quote.ToString(),
                            deskQuotesList[i].newDesk.width.ToString(), deskQuotesList[i].newDesk.depth.ToString(), deskQuotesList[i].newDesk.numDrawers.ToString(), deskQuotesList[i].newDesk.desktop.ToString(),
                            deskQuotesList[i].rushDays};
                        var listQuote = new ListViewItem(quote);
                        listView1.Items.Add(listQuote);
                    }
                }
            } else
            {
                for (var i = 0; i < deskQuotesList.Count; i++)
                {
                    string[] quote = { deskQuotesList[i].fullName, deskQuotesList[i].quote.ToString(),
                    deskQuotesList[i].newDesk.width.ToString(), deskQuotesList[i].newDesk.depth.ToString(), deskQuotesList[i].newDesk.numDrawers.ToString(), deskQuotesList[i].newDesk.desktop.ToString(),
                    deskQuotesList[i].rushDays};
                    var listQuote = new ListViewItem(quote);
                    listView1.Items.Add(listQuote);
                }
            }

        }
    }
}
