using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MegaDesk_JimDeMordaunt
{
    public partial class AddQuote : Form
    {
        int width = 0;
        int depth = 0;
        int numDrawers = 0;
        string desktop;
        string fullName;
        string rushDays;
        Desk newDesk;
        DeskQuote newQuote;

        DateTime quoteDate;
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQouteToMenuButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddNewQuoteButton_Click(object sender, EventArgs e)
        {
            AddNewQuoteButton.Enabled = false;
            width = Convert.ToInt32(DeskWidthInput.Value);
            depth = Convert.ToInt32(DeskDepthInput.Value);
            fullName = CustomerFullNameInput.Text;
            desktop = DesktopMatInput.Text;
            numDrawers = Convert.ToInt32(NumDrawersInput.Value);
            rushDays = RushOrderInput.Text;
            quoteDate = dateTimeQuote.Value;
            // unquote try/catch blocks for run, but leave quoted for debugging
            //try
            //{
                //try
               // {
                    if (fullName == string.Empty)
                    {
                        CustomerFullNameInput.BackColor = Color.Red;
                        CustomerFullNameInput.Focus();
                        AddNewQuoteButton.Enabled = true;

                    }
                    else if (DeskWidthInput.Validate() == false)
                    {


                        DeskWidthInput.BackColor = Color.Red;
                        AddNewQuoteButton.Enabled = true;

                    }


                    else if (DesktopMatInput.Text == "")
                    {
                        DesktopMatInput.BackColor = Color.Red;
                        DesktopMatInput.Focus();
                        AddNewQuoteButton.Enabled = true;

                    }
                    else if (rushDays == "")
                    {
                        RushOrderInput.BackColor = Color.Red;
                        RushOrderInput.Focus();
                        AddNewQuoteButton.Enabled = true;

                    }
                    else
                    {
                        AddNewQuoteButton.Enabled = true;
                        newDesk = new Desk(width, depth, numDrawers, desktop);
                        newQuote = new DeskQuote(newDesk, fullName, rushDays, quoteDate);

                        DisplayQuote displayQuote = new DisplayQuote(newDesk, newQuote);
                        displayQuote.Tag = this;
                        displayQuote.Show(this);
                        //this.Close();
                   }
             //   }
            /*    catch (Exception)
                {
                    MessageBox.Show("Invalid Entry. Numbers must be entered with range");
                    DeskWidthInput.Text = String.Empty;
                    DeskWidthInput.Focus();
                }
            } catch {
                throw;
            } */

        }

/*private void DeskWidthInput_ValueChanged(object sender, EventArgs e)
        {
            if (DeskWidthInput.Validate() == false) {
                DeskWidthInput.BackColor = Color.Red;
            }
            else
            {
                DeskWidthInput.BackColor = Color.MintCream;
            }


        }*/

        private void DeskDepthInput_KeyPress(object sender, KeyPressEventArgs e)
        { 
            //try
           // {
                if (DeskDepthInput.Validate() == false)
                {
                    DeskDepthInput.BackColor = Color.Red;

                }
                else
                {
                    DeskDepthInput.BackColor = Color.MintCream;
                }
                char depthinput = (Convert.ToChar(DeskDepthInput.Value));
                if (char.IsControl(depthinput))
                {
                    if (char.IsDigit(depthinput))
                    {
                        DeskDepthInput.BackColor = Color.MintCream;
                    }


                }
                else
                {
                    DeskDepthInput.BackColor = Color.Red;

                }
            }
          /*  catch (Exception) {
                MessageBox.Show("Invalid Entry. Numbers must be entered with range");
                DeskDepthInput.Text = String.Empty;
                DeskDepthInput.Focus();
            }*/
       // }
    }
}
