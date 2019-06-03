

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

    #region class OptionsParser : ParserBaseClass
    /// <summary>
    /// This class is used to parse 'Options' objects.
    /// </summary>
    public partial class OptionsParser : ParserBaseClass
    {

        #region Events

            #region Parsing(XmlNode xmlNode)
            /// <summary>
            /// This event is fired BEFORE the collection is initialized.
            /// An example of this is the options (plural) node.
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

            #region Parsing(XmlNode xmlNode, ref Options options)
            /// <summary>
            /// This event is fired when a single object is initialized.
            /// An example of this is the options (singlular) node.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="options"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsing(XmlNode xmlNode, ref Options options)
            {
                // initial value
                bool cancel = false;

                // Add any pre processing code here. Set cancel to true to abort adding this object.

                // return value
                return cancel;
            }
            #endregion

            #region Parsed(XmlNode xmlNode, ref Options options)
            /// <summary>
            /// This event is fired AFTER the options is parsed.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="options"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsed(XmlNode xmlNode, ref Options options)
            {
                // initial value
                bool cancel = false;

                // If the options object exists
                if (NullHelper.Exists(options))
                {
                    // Create a new instance of a 'FolderParser' object.
                    FolderParser parser = new FolderParser();

                    // Load the DoNotCopyContentFolders
                    options.DoNotCopyContentFolders = parser.ParseFolders(xmlNode);
                }

                // return value
                return cancel;
            }
            #endregion

        #endregion

    }
    #endregion

}
