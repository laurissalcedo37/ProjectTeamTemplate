using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_JimDeMordaunt
{
    public partial class MainMenu : Form
    {
        List<DeskQuote> deskQuoteList = new List<DeskQuote>();
        public MainMenu()
        {
            InitializeComponent();
            //Add reading data from JSON file (quotes.json) - deserialisation
            string path = @"quotes.json";

            if (!File.Exists(path))
            {
                File.Create(path);
            }

            //Deserialize: V1
            /*var jsonData = File.ReadAllText(path);
            Console.WriteLine(jsonData);
            deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);*/


            //Deserialize: V2
            StreamReader m_ReaderParameter = new StreamReader(path);
            var json = m_ReaderParameter.ReadToEnd();
            m_ReaderParameter.Close();
            deskQuoteList = JsonConvert.DeserializeObject<List<DeskQuote>>(json);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuote = new AddQuote(deskQuoteList);
            addNewQuote.Tag = this;
            addNewQuote.Show(this);
            Hide();
        }

        private void ViewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuotes = new ViewAllQuotes(deskQuoteList);
            viewQuotes.Tag = this;
            viewQuotes.Show(this);
            Hide();
        }

        private void SearchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotes = new SearchQuotes(deskQuoteList);
            searchQuotes.Tag = this;
            searchQuotes.Show(this);
            Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void displayQuote(DeskQuote newQuote)
        {
            DisplayQuote form = new DisplayQuote(newQuote);
            form.Tag = this;
            form.Show(this);
            Hide();
        }
        //can be deleted after creating deserialization
        public void addQuote(List<DeskQuote> deskQuotes)
        {
            //deskQuoteList = deskQuotes;
        }
    }
}
