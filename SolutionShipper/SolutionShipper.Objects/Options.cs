

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SolutionShipper.Objects
{

    #region class Options
    /// <summary>
    /// This class contains the options for which features should be deleted or copied
    /// </summary>
    public class Options
    {

        #region Private Variables
        private bool deleteBinFolder;
        private bool deleteObjFolder;
        private bool deletePackagesFolder;
        private bool zipProject;
        private bool copy;
        private bool addTimestamp;
        private List<Folder> doNotCopyContentFolders;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of an Options class
        /// </summary>
        public Options()
        {
            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create a new collection of 'string' objects.
                this.DoNotCopyContentFolders = new List<Folder>();
            }
            #endregion
            
        #endregion

        #region Properties

            #region AddTimestamp
            /// <summary>
            /// This property gets or sets the value for 'AddTimestamp'.
            /// </summary>
            public bool AddTimestamp
            {
                get { return addTimestamp; }
                set { addTimestamp = value; }
            }
            #endregion
            
            #region Copy
            /// <summary>
            /// This property gets or sets the value for 'Copy'.
            /// </summary>
            public bool Copy
            {
                get { return copy; }
                set { copy = value; }
            }
            #endregion
            
            #region DeleteBinFolder
            /// <summary>
            /// This property gets or sets the value for 'DeleteBinFolder'.
            /// </summary>
            public bool DeleteBinFolder
            {
                get { return deleteBinFolder; }
                set { deleteBinFolder = value; }
            }
            #endregion
            
            #region DeleteObjFolder
            /// <summary>
            /// This property gets or sets the value for 'DeleteObjFolder'.
            /// </summary>
            public bool DeleteObjFolder
            {
                get { return deleteObjFolder; }
                set { deleteObjFolder = value; }
            }
            #endregion
            
            #region DeletePackagesFolder
            /// <summary>
            /// This property gets or sets the value for 'DeletePackagesFolder'.
            /// </summary>
            public bool DeletePackagesFolder
            {
                get { return deletePackagesFolder; }
                set { deletePackagesFolder = value; }
            }
            #endregion
            
            #region DoNotCopyContentFolders
            /// <summary>
            /// This property gets or sets the value for 'DoNotCopyContentFolders'.
            /// </summary>
            public List<Folder> DoNotCopyContentFolders
            {
                get { return doNotCopyContentFolders; }
                set { doNotCopyContentFolders = value; }
            }
            #endregion
            
            #region HasDoNotCopyContentFolders
            /// <summary>
            /// This property returns true if this object has a 'DoNotCopyContentFolders'.
            /// </summary>
            public bool HasDoNotCopyContentFolders
            {
                get
                {
                    // initial value
                    bool hasDoNotCopyContentFolders = (this.DoNotCopyContentFolders != null);
                    
                    // return value
                    return hasDoNotCopyContentFolders;
                }
            }
            #endregion
            
            #region ZipProject
            /// <summary>
            /// This property gets or sets the value for 'ZipProject'.
            /// </summary>
            public bool ZipProject
            {
                get { return zipProject; }
                set { zipProject = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
