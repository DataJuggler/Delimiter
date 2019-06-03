

#region using statements

using DataJuggler.Core.UltimateHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Delimiter.Util;
using Delimiter.Objects;

#endregion

namespace Delimiter
{

    #region class MainForm
    /// <summary>
    /// This class is the MainForm for this application
    /// </summary>
    public partial class MainForm : Form
    {
        
        #region Private Variables
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a MainForm object
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events

            #region AddDelimiter_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'AddDelimiter' is clicked.
            /// </summary>
            private void AddDelimiter_Click(object sender, EventArgs e)
            {
                // get the sourceText
                string sourceText = this.ItemsTextBox.Text;

                // parse out the lines from the sourceText
                List<TextLine> lines = TextParser.ParseLines(sourceText);

                // locals
                int currentLine = 0;
                string delimiter = this.DelimiterTextBox.Text;

                // if there are one or more lines
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // Create a StringBuilder
                    StringBuilder sb = new StringBuilder();

                    // iterate the lines 
                    foreach (TextLine line in lines)
                    {
                        // increment the line
                        currentLine++;

                        // if surround with single quotes
                        if (this.SingleQuotesCheckbox.Checked)
                        {
                            // Append a single quote
                            sb.Append("'");
                        }

                        // append the line
                        sb.Append(line.Text);

                        // if surround with single quotes
                        if (this.SingleQuotesCheckbox.Checked)
                        {
                            // Append a single quote
                            sb.Append("'");
                        }

                        // if this is not the last line
                        if (currentLine < lines.Count)
                        {
                            // Append the Delimiter
                            sb.Append(delimiter);
                        }
                    }

                    // Set the Del
                    string delimitedItems = sb.ToString();

                    // copy the results to the clipboard
                    Clipboard.SetText(delimitedItems);

                    // Show a message to the user
                    MessageBoxHelper.ShowMessage("The items have been copied to the clipboard", "Items Copied");
                }
            }
            #endregion
            
            #region Button_MouseEnter(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Enter
            /// </summary>
            private void Button_MouseEnter(object sender, EventArgs e)
            {
                // Change the Cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_MouseLeave(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when Button _ Mouse Leave
            /// </summary>
            private void Button_MouseLeave(object sender, EventArgs e)
            {
                // Change the Cursor to a hand
                this.Cursor = Cursors.Default;
            }
            #endregion
            
            #region ClearButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'ClearButton' is clicked.
            /// </summary>
            private void ClearButton_Click(object sender, EventArgs e)
            {
                // Clear the TextBox
                this.ItemsTextBox.Clear();
            }
            #endregion
            
            #region DataJugglerButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'DataJugglerButton' is clicked.
            /// </summary>
            private void DataJugglerButton_Click(object sender, EventArgs e)
            {
                // send the user to the Data Juggler website
                System.Diagnostics.Process.Start("http://www.datajuggler.com");
            }
            #endregion
            
            #region DistinctListButton_Click(object sender, EventArgs e)
            /// <summary>
            /// This event is fired when the 'DistinctListButton' is clicked.
            /// </summary>
            private void DistinctListButton_Click(object sender, EventArgs e)
            {
                // get the sourceText
                string sourceText = this.ItemsTextBox.Text;

                // parse out the lines from the sourceText
                List<TextLine> lines = TextParser.ParseLines(sourceText);

                // local
                StringBuilder sb = new StringBuilder();
                
                // if there are one or more lines
                if (ListHelper.HasOneOrMoreItems(lines))
                {
                    // get a distinctList
                    var distinctList = lines.Select(o=>o.Text).Distinct();

                    // iterate the list
                    foreach (var item in distinctList)
                    {
                        // append this item
                        sb.Append(item);

                        // append a comma
                        sb.Append(",");
                    }

                    // Get the list
                    string temp = sb.ToString();

                    // if the string exists
                    if (!String.IsNullOrEmpty(temp))
                    {
                        // remove the last comma
                        string delimitedItems = temp.Substring(0, temp.Length - 1);

                        // copy the results to the clipboard
                        Clipboard.SetText(delimitedItems);

                        // Show a message to the user
                        MessageBoxHelper.ShowMessage("The distinct list has been copied to the clipboard", "Items Copied");
                    }
                    else
                    {
                        // Show a message to the user
                        MessageBoxHelper.ShowMessage("Something went wrong, did you paste a list of numbers?", "Oops");
                    }
                }                   
            }
            #endregion
            
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            private void Init()
            {
                // Set the default delimir
                this.DelimiterTextBox.Text = ",";
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
