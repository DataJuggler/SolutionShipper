

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

    #region class ShipmentParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'Shipment' objects.
    /// </summary>
    public partial class ShipmentParser : ParserBaseClass
    {

        #region Methods

            #region ParseShipment(string shipmentXmlText)
            /// <summary>
            /// This method is used to parse an object of type 'Shipment'.
            /// </summary>
            /// <param name="shipmentXmlText">The source xml to be parsed.</param>
            /// <returns>An object of type 'Shipment'.</returns>
            public Shipment ParseShipment(string shipmentXmlText)
            {
                // initial value
                Shipment shipment = null;

                // if the sourceXmlText exists
                if (TextHelper.Exists(shipmentXmlText))
                {
                    // create an instance of the parser
                    XmlParser parser = new XmlParser();

                    // Create the XmlDoc
                    this.XmlDoc = parser.ParseXmlDocument(shipmentXmlText);

                    // If the XmlDoc exists and has a root node.
                    if ((this.HasXmlDoc) && (this.XmlDoc.HasRootNode))
                    {
                        // Create a new shipment
                        shipment = new Shipment();

                        // Perform preparsing operations
                        bool cancel = Parsing(this.XmlDoc.RootNode, ref shipment);

                        // if the parsing should not be cancelled
                        if (!cancel)
                        {
                            // Parse the 'Shipment' object
                            shipment = ParseShipment(ref shipment, this.XmlDoc.RootNode);

                            // Perform post parsing operations
                            cancel = Parsed(this.XmlDoc.RootNode, ref shipment);

                            // if the parsing should be cancelled
                            if (cancel)
                            {
                                // Set the 'shipment' object to null
                                shipment = null;
                            }
                        }
                    }
                }

                // return value
                return shipment;
            }
            #endregion

            #region ParseShipment(ref Shipment shipment, XmlNode xmlNode)
            /// <summary>
            /// This method is used to parse Shipment objects.
            /// </summary>
            public Shipment ParseShipment(ref Shipment shipment, XmlNode xmlNode)
            {
                // if the shipment object exists and the xmlNode exists
                if ((shipment != null) && (xmlNode != null))
                {
                    // get the full name of this node
                    string fullName = xmlNode.GetFullName();

                    // Check the name of this node to see if it is mapped to a property
                    switch(fullName)
                    {
                        case "Shipment.Name":

                            // Set the value for shipment.Name
                            shipment.Name = xmlNode.FormattedNodeValue;

                            // required
                            break;

                        case "Shipment.OutputFolderPath":

                            // Set the value for shipment.OutputFolderPath
                            shipment.OutputFolderPath = xmlNode.FormattedNodeValue;

                            // required
                            break;

                        case "Shipment.SourceFolderPath":

                            // Set the value for shipment.SourceFolderPath
                            shipment.SourceFolderPath = xmlNode.FormattedNodeValue;

                            // required
                            break;

                    }

                    // if there are ChildNodes
                    if (xmlNode.HasChildNodes)
                    {
                        // iterate the child nodes
                         foreach(XmlNode childNode in xmlNode.ChildNodes)
                        {
                            // append to this Shipment
                            shipment = ParseShipment(ref shipment, childNode);
                        }
                    }
                }

                // return value
                return shipment;
            }
            #endregion

        #endregion

    }
    #endregion

}
