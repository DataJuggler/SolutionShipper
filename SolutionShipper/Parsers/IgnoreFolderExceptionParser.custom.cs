

#region using statements

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

        #region Events

            #region Parsing(XmlNode xmlNode)
            /// <summary>
            /// This event is fired BEFORE the collection is initialized.
            /// An example of this is the ignoreFolderExceptions (plural) node.
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

            #region Parsing(XmlNode xmlNode, ref IgnoreFolderException ignoreFolderException)
            /// <summary>
            /// This event is fired when a single object is initialized.
            /// An example of this is the ignoreFolderException (singlular) node.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="ignoreFolderException"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsing(XmlNode xmlNode, ref IgnoreFolderException ignoreFolderException)
            {
                // initial value
                bool cancel = false;

                // Add any pre processing code here. Set cancel to true to abort adding this object.

                // return value
                return cancel;
            }
            #endregion

            #region Parsed(XmlNode xmlNode, ref IgnoreFolderException ignoreFolderException)
            /// <summary>
            /// This event is fired AFTER the ignoreFolderException is parsed.
            /// </summary>
            /// <param name="xmlNode"></param>
            /// <param name="ignoreFolderException"></param>
            /// <returns>True if cancelled else false if not.</returns>
            public bool Parsed(XmlNode xmlNode, ref IgnoreFolderException ignoreFolderException)
            {
                // initial value
                bool cancel = false;

                // Add any post processing code here. Set cancel to true to abort adding this object.

                // return value
                return cancel;
            }
            #endregion

        #endregion

    }
    #endregion

}
