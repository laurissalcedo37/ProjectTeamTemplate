﻿using System;
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
    public partial class DisplayQuote : Form
    {
         public DeskQuote newQuote { get; set; }
         public Desk newDesk { get; set; }
        public DisplayQuote(DeskQuote newQuote)
        {
            InitializeComponent();
            QuoteDateOutput.Text = newQuote.quoteDate.ToString();
            CustomerFullNameOutput.Text = newQuote.fullName.ToString();
            DeskWidthOutput.Text = newQuote.newDesk.width.ToString();
            DeskDepthOutput.Text = newQuote.newDesk.depth.ToString();
            NumDrawersOutput.Text = newQuote.newDesk.numDrawers.ToString();
            DeskMatOutput.Text = newQuote.newDesk.desktop.ToString();
            RushOrderOutput.Text = newQuote.rushDays.ToString();
            QuoteTotal.Text = newQuote.quote.ToString() + ".00";
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }


        private void DisplayQouteToMenuButton_Click(object sender, EventArgs e)
        {
            
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }


    }
}
