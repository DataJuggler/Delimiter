

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Delimiter.Util;

#endregion

namespace Delimiter.Objects
{

    #region class TextLine
    /// <summary>
    /// This class represents one line of text.
    /// </summary>
    public class TextLine
    {
        
        #region Private Variables
        private string text;
        private int lineNumber;
        #endregion
        
        #region Constructors

            #region #region Parameterized Constructor(string text)
            /// <summary>
            /// Create a new instance of a TextLine object
            /// </summary>
            public TextLine(string text)
            {
                // Set the text
                this.Text = text;
            }
            #endregion

            #region Parameterized Constructor(string text, int lineNumber)
            /// <summary>
            /// Create a new instance of a TextLine object
            /// </summary>
            public TextLine(string text, int lineNumber)
            {
                // Set the text
                this.Text = text;
                
                // Set the LineNumber
                this.LineNumber = lineNumber;
            }
            #endregion
            
        #endregion
        
        #region Properties
            
            #region LineNumber
            /// <summary>
            /// This property gets or sets the value for LineNumber. 
            /// </summary>
            public int LineNumber
            {
                get { return lineNumber; }
                set { lineNumber = value; }
            }
            #endregion
            
            #region Text
            /// <summary>
            /// This property gets or sets the value for Text.
            /// </summary>
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
