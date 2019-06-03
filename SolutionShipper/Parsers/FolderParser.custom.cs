

#region using statements

using SolutionShipper.Objects;
using System;
using System.Collections.Generic;
using XmlMirror.Runtime.Objects;
using XmlMirror.Runtime.Util;
using DataJuggler.Core.UltimateHelper;
using System.IO;

#endregion

namespace SolutionShipper.Parsers
{

    #region class FolderParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'Folder' objects.
    /// </summary>
    public partial class FolderParser : ParserBaseClass
    {

        #region Private Variables
        #endregion

        #region Constructor()
        /// <summary>
        /// Create a new instance of a FolderParser object
        /// </summary>
        public FolderParser()
        {
            
        }
        #endregion

        #region Events

            #region Parsing(XmlNode xmlNode)
            /// <summary>
            /// This event is fired BEFORE the collection is initialized.
            /// An example of this is the folders (plural) node.
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

            #region Parsing(XmlNode xmlNode, ref Folder folder)
            /// <summary>
            /// This event is fired when a single object is initialized.
            /// An example of this is the folder (singlular) node.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="folder"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsing(XmlNode xmlNode, ref Folder folder)
            {
                // initial value
                bool cancel = false;

                // Add any pre processing code here. Set cancel to true to abort adding this object.

                // return value
                return cancel;
            }
            #endregion

            #region Parsed(XmlNode xmlNode, ref Folder folder)
            /// <summary>
            /// This event is fired AFTER the folder is parsed.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="folder"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsed(XmlNode xmlNode, ref Folder folder)
            {
                // initial value
                bool cancel = false;
                
                // If the folder object exists && the SelectedShipmentPath exists
                if (NullHelper.Exists(folder))
                {
                    // create the parser
                    IgnoreFolderExceptionParser parser = new IgnoreFolderExceptionParser();
                    
                    // load the ignoreFolderExceptions
                    folder.IgnoreExceptions = parser.ParseIgnoreFolderExceptions(xmlNode);
                }

                // return value
                return cancel;
            }
            #endregion

        #endregion

        #region Properties
            
        #endregion

    }
    #endregion

}
