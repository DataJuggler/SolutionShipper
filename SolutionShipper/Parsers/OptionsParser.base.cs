

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

    #region class OptionsParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'Options' objects.
    /// </summary>
    public partial class OptionsParser : ParserBaseClass
    {

        #region Methods

            #region ParseOptions(string optionsXmlText)
            /// <summary>
            /// This method is used to parse an object of type 'Options'.
            /// </summary>
            /// <param name="optionsXmlText">The source xml to be parsed.</param>
            /// <returns>An object of type 'Options'.</returns>
            public Options ParseOptions(string optionsXmlText)
            {
                // initial value
                Options options = null;

                // if the sourceXmlText exists
                if (TextHelper.Exists(optionsXmlText))
                {
                    // create an instance of the parser
                    XmlParser parser = new XmlParser();

                    // Create the XmlDoc
                    this.XmlDoc = parser.ParseXmlDocument(optionsXmlText);

                    // If the XmlDoc exists and has a root node.
                    if ((this.HasXmlDoc) && (this.XmlDoc.HasRootNode))
                    {
                        // Create a new options
                        options = new Options();

                        // Perform preparsing operations
                        bool cancel = Parsing(this.XmlDoc.RootNode, ref options);

                        // if the parsing should not be cancelled
                        if (!cancel)
                        {
                            // Parse the 'Options' object
                            options = ParseOptions(ref options, this.XmlDoc.RootNode);

                            // Perform post parsing operations
                            cancel = Parsed(this.XmlDoc.RootNode, ref options);

                            // if the parsing should be cancelled
                            if (cancel)
                            {
                                // Set the 'options' object to null
                                options = null;
                            }
                        }
                    }
                }

                // return value
                return options;
            }
            #endregion

            #region ParseOptions(ref Options options, XmlNode xmlNode)
            /// <summary>
            /// This method is used to parse Options objects.
            /// </summary>
            public Options ParseOptions(ref Options options, XmlNode xmlNode)
            {
                // if the options object exists and the xmlNode exists
                if ((options != null) && (xmlNode != null))
                {
                    // get the full name of this node
                    string fullName = xmlNode.GetFullName();

                    // Check the name of this node to see if it is mapped to a property
                    switch(fullName)
                    {
                        case "Shipment.Options.AddTimestamp":

                            // Set the value for options.AddTimestamp
                            options.AddTimestamp = BooleanHelper.ParseBoolean(xmlNode.FormattedNodeValue, false, false);

                            // required
                            break;

                        case "Shipment.Options.Copy":

                            // Set the value for options.Copy
                            options.Copy = BooleanHelper.ParseBoolean(xmlNode.FormattedNodeValue, false, false);

                            // required
                            break;

                        case "Shipment.Options.DeleteBinFolder":

                            // Set the value for options.DeleteBinFolder
                            options.DeleteBinFolder = BooleanHelper.ParseBoolean(xmlNode.FormattedNodeValue, false, false);

                            // required
                            break;

                        case "Shipment.Options.DeleteObjFolder":

                            // Set the value for options.DeleteObjFolder
                            options.DeleteObjFolder = BooleanHelper.ParseBoolean(xmlNode.FormattedNodeValue, false, false);

                            // required
                            break;

                        case "Shipment.Options.DeletePackagesFolder":

                            // Set the value for options.DeletePackagesFolder
                            options.DeletePackagesFolder = BooleanHelper.ParseBoolean(xmlNode.FormattedNodeValue, false, false);

                            // required
                            break;

                        case "Shipment.Options.ZipProject":

                            // Set the value for options.ZipProject
                            options.ZipProject = BooleanHelper.ParseBoolean(xmlNode.FormattedNodeValue, false, false);

                            // required
                            break;

                    }

                    // if there are ChildNodes
                    if (xmlNode.HasChildNodes)
                    {
                        // iterate the child nodes
                         foreach(XmlNode childNode in xmlNode.ChildNodes)
                        {
                            // append to this Options
                            options = ParseOptions(ref options, childNode);
                        }
                    }
                }

                // return value
                return options;
            }
            #endregion

        #endregion

    }
    #endregion

}
