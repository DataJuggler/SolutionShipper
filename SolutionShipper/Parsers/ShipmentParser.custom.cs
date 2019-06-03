

#region using statements

using SolutionShipper.Objects;
using System;
using System.Collections.Generic;
using XmlMirror.Runtime.Objects;
using XmlMirror.Runtime.Util;
using DataJuggler.Core.UltimateHelper;

#endregion

namespace SolutionShipper.Parsers
{

    #region class ShipmentParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'Shipment' objects.
    /// </summary>
    public partial class ShipmentParser : ParserBaseClass
    {

        #region Private Variables
        private string selectedShipmentPath;
        #endregion

        #region Constructor(string selectedShipmentFolder)
        /// <summary>
        /// Create a new instance of a ShipmentParser
        /// </summary>
        /// <param name="selectedShipmentPath"></param>
        public ShipmentParser(string selectedShipmentPath)
        {
            // Store the argument
            this.SelectedShipmentPath = selectedShipmentPath;
        }
        #endregion

        #region Events

            #region Parsing(XmlNode xmlNode)
            /// <summary>
            /// This event is fired BEFORE the collection is initialized.
            /// An example of this is the shipments (plural) node.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsing(XmlNode xmlNode)
            {
                // initial value
                bool cancel = false;

                // Add any pre processing code here. Set cancel to true to abort parsing this collection.

                // return value
                return cancel;
            }
            #endregion

            #region Parsing(XmlNode xmlNode, ref Shipment shipment)
            /// <summary>
            /// This event is fired when a single object is initialized.
            /// An example of this is the shipment (singlular) node.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="shipment"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsing(XmlNode xmlNode, ref Shipment shipment)
            {
                // initial value
                bool cancel = false;

                // Add any pre processing code here. Set cancel to true to abort adding this object.

                // return value
                return cancel;
            }
            #endregion

            #region Parsed(XmlNode xmlNode, ref Shipment shipment)
            /// <summary>
            /// This event is fired AFTER the shipment is parsed.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="shipment"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsed(XmlNode xmlNode, ref Shipment shipment)
            {
                // initial value
                bool cancel = false;

                // If the shipment object exists
                if (NullHelper.Exists(shipment))
                {
                    // Create a new instance of an 'OptionsParser' object.
                    OptionsParser parser = new OptionsParser();

                    // get a copy of the options
                    Options options = shipment.Options;

                    // parse the options
                    parser.ParseOptions(ref options, xmlNode);

                    // Raise the Parsed event so the Folders get loaded
                    parser.Parsed(xmlNode, ref options);
                }

                // return value
                return cancel;
            }
        #endregion

        #endregion

        #region Properties

            #region HasSelectedShipmentPath
            /// <summary>
            /// This property returns true if the 'SelectedShipmentPath' exists.
            /// </summary>
            public bool HasSelectedShipmentPath
            {
                get
                {
                    // initial value
                    bool hasSelectedShipmentPath = (!String.IsNullOrEmpty(this.SelectedShipmentPath));
                    
                    // return value
                    return hasSelectedShipmentPath;
                }
            }
            #endregion
            
            #region SelectedShipmentPath
            /// <summary>
            /// This property gets or sets the value for 'SelectedShipmentPath'.
            /// </summary>
            public string SelectedShipmentPath
            {
                get { return selectedShipmentPath; }
                set { selectedShipmentPath = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
