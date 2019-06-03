

#region using statements

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Delimiter.Objects;

#endregion

namespace Delimiter.Util
{

    #region class TextParser
    /// <summary>
    /// This class is used to parse a CSharpCodeFile into objects.
    /// </summary>
    public class TextParser
    {  
      
        #region Methods
                
            #region ParseLines(string sourceText)
            /// <summary>
            /// This method parses the lines for a string.
            /// This could be a document or a code block.
            /// </summary>
            /// <param name="sourceText"></param>
            /// <returns></returns>
            public static List<TextLine> ParseLines(string sourceText)
            {
                List<TextLine> textLines = new List<TextLine>();
                    
                try
                {
                    // view the reader
                    using (StringReader reader = new StringReader(sourceText))
                    {
                        // LineNumber starts a 1 not 0
                        int lineNumber = 0;
                        string line;
                            
                        // read all lines in the string
                        while ((line = reader.ReadLine()) != null)
                        {
                            // increment lineNumber (LineNumber starts a 1 not 0)
                            lineNumber++;
                                
                            // Create a text line
                            TextLine textLine = new TextLine(line, lineNumber);    
                                
                            // add this line
                            textLines.Add(textLine);
                        }
                    }
                        
                }
                catch(Exception error)
                {
                    // for debugging only
                    string err = error.ToString();
                }
                    
                return textLines;
            } 
            #endregion
            
        #endregion
            
    }
    #endregion
    
}
