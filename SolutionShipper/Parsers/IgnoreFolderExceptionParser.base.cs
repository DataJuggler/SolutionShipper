

#region using statements

using DataJuggler.Core.UltimateHelper;
using SolutionShipper.Objects;
using System;
using System.Collections.Generic;
using XmlMirror.Runtime.Objects;
using XmlMirror.Runtime.Util;

#endregion

namespace SolutionShipper.Parsers
{

    #region class IgnoreFolderExceptionParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'IgnoreFolderException' objects.
    /// </summary>
    public partial class IgnoreFolderExceptionParser : ParserBaseClass
    {

        #region Methods

            #region LoadIgnoreFolderExceptions(string sourceXmlText)
            /// <summary>
            /// This method is used to load a list of 'IgnoreFolderException' objects.
            /// </summary>
            /// <param name="sourceXmlText">The source xml to be parsed.</param>
            /// <returns>A list of 'IgnoreFolderException' objects.</returns>
            public List<IgnoreFolderException> LoadIgnoreFolderExceptions(string sourceXmlText)
            {
                // initial value
                List<IgnoreFolderException> ignoreFolderExceptions = null;

                // if the source text exists
                if (TextHelper.Exists(sourceXmlText))
                {
                    // create an instance of the parser
                    XmlParser parser = new XmlParser();

                    // Create the XmlDoc
                    this.XmlDoc = parser.ParseXmlDocument(sourceXmlText);

                    // If the XmlDoc exists and has a root node.
                    if ((this.HasXmlDoc) && (this.XmlDoc.HasRootNode))
                    {
                        // parse the ignoreFolderExceptions
                        ignoreFolderExceptions = ParseIgnoreFolderExceptions(this.XmlDoc.RootNode);
                    }
                }

                // return value
                return ignoreFolderExceptions;
            }
            #endregion

            #region ParseIgnoreFolderException(ref IgnoreFolderException ignoreFolderException, XmlNode xmlNode)
            /// <summary>
            /// This method is used to parse IgnoreFolderException objects.
            /// </summary>
            public IgnoreFolderException ParseIgnoreFolderException(ref IgnoreFolderException ignoreFolderException, XmlNode xmlNode)
            {
                // if the ignoreFolderException object exists and the xmlNode exists
                if ((ignoreFolderException != null) && (xmlNode != null))
                {
                    // get the full name of this node
                    string fullName = xmlNode.GetFullName();

                    // Check the name of this node to see if it is mapped to a property
                    switch(fullName)
                    {
                        case "Shipment.Options.DoNotCopyContentFolders.Folder.Exceptions.Exception.ExceptionType":

                            // Set the value for ignoreFolderException.ExceptionTypeValue
                            ignoreFolderException.ExceptionTypeValue = NumericHelper.ParseInteger(xmlNode.FormattedNodeValue, 0, -1);

                            // required
                            break;

                        case "Shipment.Options.DoNotCopyContentFolders.Folder.Exceptions.Exception.Name":

                            // Set the value for ignoreFolderException.Name
                            ignoreFolderException.Name = xmlNode.FormattedNodeValue;

                            // required
                            break;

                        case "Shipment.Options.DoNotCopyContentFolders.Folder.Exceptions.Exception.Text":

                            // Set the value for ignoreFolderException.Text
                            ignoreFolderException.Text = xmlNode.FormattedNodeValue;

                            // required
                            break;

                    }

                    // if there are ChildNodes
                    if (xmlNode.HasChildNodes)
                    {
                        // iterate the child nodes
                         foreach(XmlNode childNode in xmlNode.ChildNodes)
                        {
                            // append to this IgnoreFolderException
                            ignoreFolderException = ParseIgnoreFolderException(ref ignoreFolderException, childNode);
                        }
                    }
                }

                // return value
                return ignoreFolderException;
            }
            #endregion

            #region ParseIgnoreFolderExceptions(XmlNode xmlNode, List<IgnoreFolderException> ignoreFolderExceptions = null)
            /// <summary>
            /// This method is used to parse a list of 'IgnoreFolderException' objects.
            /// </summary>
            /// <param name="XmlNode">The XmlNode to be parsed.</param>
            /// <returns>A list of 'IgnoreFolderException' objects.</returns>
            public List<IgnoreFolderException> ParseIgnoreFolderExceptions(XmlNode xmlNode, List<IgnoreFolderException> ignoreFolderExceptions = null)
            {
                // locals
                IgnoreFolderException ignoreFolderException = null;
                bool cancel = false;

                // if the xmlNode exists
                if (xmlNode != null)
                {
                    // get the full name for this node
                    string fullName = xmlNode.GetFullName();

                    // if this is the new collection line
                    if (fullName == "Shipment.Options.DoNotCopyContentFolders.Folder.Exceptions")
                    {
                        // Raise event Parsing is starting.
                        cancel = Parsing(xmlNode);

                        // If not cancelled
                        if (!cancel)
                        {
                            // create the return collection
                            ignoreFolderExceptions = new List<IgnoreFolderException>();
                        }
                    }
                    // if this is the new object line and the return collection exists
                    else if ((fullName == "Shipment.Options.DoNotCopyContentFolders.Folder.Exceptions.Exception") && (ignoreFolderExceptions != null))
                    {
                        // Create a new object
                        ignoreFolderException = new IgnoreFolderException();

                        // Perform pre parse operations
                        cancel = Parsing(xmlNode, ref ignoreFolderException);

                        // If not cancelled
                        if (!cancel)
                        {
                            // parse this object
                            ignoreFolderException = ParseIgnoreFolderException(ref ignoreFolderException, xmlNode);
                        }

                        // Perform post parse operations
                        cancel = Parsed(xmlNode, ref ignoreFolderException);

                        // If not cancelled
                        if (!cancel)
                        {
                            // Add this object to the return value
                            ignoreFolderExceptions.Add(ignoreFolderException);
                        }
                    }

                    // if there are ChildNodes
                    if (xmlNode.HasChildNodes)
                    {
                        // iterate the child nodes
                        foreach(XmlNode childNode in xmlNode.ChildNodes)
                        {
                            // self call this method for each childNode
                            ignoreFolderExceptions = ParseIgnoreFolderExceptions(childNode, ignoreFolderExceptions);
                        }
                    }
                }

                // return value
                return ignoreFolderExceptions;
            }
            #endregion

        #endregion

    }
    #endregion

}
