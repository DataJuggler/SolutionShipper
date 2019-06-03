

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

    #region class FolderParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'Folder' objects.
    /// </summary>
    public partial class FolderParser : ParserBaseClass
    {

        #region Methods

            #region LoadFolders(string sourceXmlText)
            /// <summary>
            /// This method is used to load a list of 'Folder' objects.
            /// </summary>
            /// <param name="sourceXmlText">The source xml to be parsed.</param>
            /// <returns>A list of 'Folder' objects.</returns>
            public List<Folder> LoadFolders(string sourceXmlText)
            {
                // initial value
                List<Folder> folders = null;

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
                        // parse the folders
                        folders = ParseFolders(this.XmlDoc.RootNode);
                    }
                }

                // return value
                return folders;
            }
            #endregion

            #region ParseFolder(ref Folder folder, XmlNode xmlNode)
            /// <summary>
            /// This method is used to parse Folder objects.
            /// </summary>
            public Folder ParseFolder(ref Folder folder, XmlNode xmlNode)
            {
                // if the folder object exists and the xmlNode exists
                if ((folder != null) && (xmlNode != null))
                {
                    // get the full name of this node
                    string fullName = xmlNode.GetFullName();

                    // Check the name of this node to see if it is mapped to a property
                    switch(fullName)
                    {
                        case "Shipment.Options.DoNotCopyContentFolders.Folder.Name":

                            // Set the value for folder.Name
                            folder.Name = xmlNode.FormattedNodeValue;

                            // required
                            break;

                        case "Shipment.Options.DoNotCopyContentFolders.Folder.Path":

                            // Set the value for folder.Path
                            folder.Path = xmlNode.FormattedNodeValue;

                            // required
                            break;

                    }

                    // if there are ChildNodes
                    if (xmlNode.HasChildNodes)
                    {
                        // iterate the child nodes
                         foreach(XmlNode childNode in xmlNode.ChildNodes)
                        {
                            // append to this Folder
                            folder = ParseFolder(ref folder, childNode);
                        }
                    }
                }

                // return value
                return folder;
            }
            #endregion

            #region ParseFolders(XmlNode xmlNode, List<Folder> folders = null)
            /// <summary>
            /// This method is used to parse a list of 'Folder' objects.
            /// </summary>
            /// <param name="XmlNode">The XmlNode to be parsed.</param>
            /// <returns>A list of 'Folder' objects.</returns>
            public List<Folder> ParseFolders(XmlNode xmlNode, List<Folder> folders = null)
            {
                // locals
                Folder folder = null;
                bool cancel = false;

                // if the xmlNode exists
                if (xmlNode != null)
                {
                    // get the full name for this node
                    string fullName = xmlNode.GetFullName();

                    // if this is the new collection line
                    if (fullName == "Shipment.Options.DoNotCopyContentFolders")
                    {
                        // Raise event Parsing is starting.
                        cancel = Parsing(xmlNode);

                        // If not cancelled
                        if (!cancel)
                        {
                            // create the return collection
                            folders = new List<Folder>();
                        }
                    }
                    // if this is the new object line and the return collection exists
                    else if ((fullName == "Shipment.Options.DoNotCopyContentFolders.Folder") && (folders != null))
                    {
                        // Create a new object
                        folder = new Folder();

                        // Perform pre parse operations
                        cancel = Parsing(xmlNode, ref folder);

                        // If not cancelled
                        if (!cancel)
                        {
                            // parse this object
                            folder = ParseFolder(ref folder, xmlNode);
                        }

                        // Perform post parse operations
                        cancel = Parsed(xmlNode, ref folder);

                        // If not cancelled
                        if (!cancel)
                        {
                            // Add this object to the return value
                            folders.Add(folder);
                        }
                    }

                    // if there are ChildNodes
                    if (xmlNode.HasChildNodes)
                    {
                        // iterate the child nodes
                        foreach(XmlNode childNode in xmlNode.ChildNodes)
                        {
                            // self call this method for each childNode
                            folders = ParseFolders(childNode, folders);
                        }
                    }
                }

                // return value
                return folders;
            }
            #endregion

        #endregion

    }
    #endregion

}
