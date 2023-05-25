using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace MegaDesk_JimDeMordaunt
{
    public partial class AddQuote : Form
    {
        string width;
        string depth;
        string numDrawers;
        string desktop;
        string fullName;
        string rushDays;
        Desk newDesk;
        DeskQuote newQuote;

        DateTime quoteDate;
        List<DeskQuote> deskQuotesList;
        public AddQuote(List<DeskQuote> deskQuotes)
        {
            InitializeComponent();
            deskQuotesList = deskQuotes;
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
            width = DeskWidthInput.Value.ToString();
            depth = DeskDepthInput.Value.ToString();
            fullName = CustomerFullNameInput.Text;
            desktop = DesktopMatInput.Text;
            numDrawers = NumDrawersInput.Value.ToString();
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
                //new desk and new quote
                /*Desk newDesk = new Desk(width, depth, numDrawers, desktop);
                DeskQuote newQuote = new DeskQuote(newDesk, fullName, rushDays, quoteDate);*/
                DeskQuote newQuote = new DeskQuote(fullName, rushDays, quoteDate, width, depth, numDrawers, desktop);

                // below quote example code for attempt to add to json the deskQuote above maybe should be in deskquote.cs
                /*var list = JsonConvert.DeserializeObject<List<Person>>(myJsonString);
list.Add(new Person(1234,"carl2");
var convertedJson = JsonConvert.SerializeObject(list, Formatting.Indented);*/
                // send info to fileToJson function to place it in a json

                fileToJson(newQuote);

                /*string customer = CustomerFullNameInput.Text;

                string pathSave = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"quotes.json");
                string path = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), @"quotes.json");
                string json = File.ReadAllText(path);
                var jsonObj = JObject.Parse(json);

                var quoteArray = jsonObj.GetValue("quotes") as JArray;
                int count = quoteArray.Count;

                quoteArray.Add(newQuote);
                jsonObj["quotes"] = quoteArray;
                //Saving file with new Json
                string newJsonResult = JsonConvert.SerializeObject(jsonObj, Formatting.Indented);
                File.WriteAllText(pathSave, newJsonResult);

                Dictionary<string, Object> quoteData = new Dictionary<string, Object>();
                quoteData.Add("id", count + 1);
                quoteData.Add("customer", customer);

                */
                MainMenu mainMenu = new MainMenu();
                mainMenu.addQuote(deskQuotesList);
                mainMenu.displayQuote(newQuote);
                        Close();
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

        private void fileToJson(DeskQuote newQuote)
        {
            string jsonF = @"quotes.json";

            if (!File.Exists(jsonF))
            {
                File.Create(jsonF);
            }
            deskQuotesList.Add(newQuote);
            Console.WriteLine(deskQuotesList.Count);
            //Write data to json file - serialize
            string jsonQuoteList = JsonConvert.SerializeObject(deskQuotesList);

            File.WriteAllText(jsonF, jsonQuoteList);

        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }
    }
}
