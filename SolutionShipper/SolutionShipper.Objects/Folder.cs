

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolutionShipper.Enumerations;

#endregion

namespace SolutionShipper.Objects
{

    #region class Folder
    /// <summary>
    /// This class represents a Folder on the file system.
    /// </summary>
    public class Folder
    {
        
        #region Private Variables
        private Folder parentFolder;
        private List<Folder> subFolders;
        private List<FileData> files;
        private List<IgnoreFolderException> ignoreExceptions;
        private string name;
        private string path;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Folder object
        /// </summary>
        public Folder()
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
                // Create the child objects
                this.SubFolders = new List<Folder>();
                this.Files = new List<FileData>();
                this.IgnoreExceptions = new List<IgnoreFolderException>();
            }
            #endregion

            #region ToString()
            /// <summary>
            /// This method returns the name of this object when ToString is called
            /// </summary>
            public override string ToString()
            {
                // return the name
                return this.Name;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Files
            /// <summary>
            /// This property gets or sets the value for 'Files'.
            /// </summary>
            public List<FileData> Files
            {
                get { return files; }
                set { files = value; }
            }
            #endregion
            
            #region HasFiles
            /// <summary>
            /// This property returns true if this object has a 'Files'.
            /// </summary>
            public bool HasFiles
            {
                get
                {
                    // initial value
                    bool hasFiles = (this.Files != null);
                    
                    // return value
                    return hasFiles;
                }
            }
            #endregion
            
            #region HasIgnoreExceptions
            /// <summary>
            /// This property returns true if this object has an 'IgnoreExceptions'.
            /// </summary>
            public bool HasIgnoreExceptions
            {
                get
                {
                    // initial value
                    bool hasIgnoreExceptions = (this.IgnoreExceptions != null);
                    
                    // return value
                    return hasIgnoreExceptions;
                }
            }
            #endregion
            
            #region HasParentFolder
            /// <summary>
            /// This property returns true if this object has a 'ParentFolder'.
            /// </summary>
            public bool HasParentFolder
            {
                get
                {
                    // initial value
                    bool hasParentFolder = (this.ParentFolder != null);
                    
                    // return value
                    return hasParentFolder;
                }
            }
            #endregion
            
            #region HasSubFolders
            /// <summary>
            /// This property returns true if this object has a 'SubFolders'.
            /// </summary>
            public bool HasSubFolders
            {
                get
                {
                    // initial value
                    bool hasSubFolders = (this.SubFolders != null);
                    
                    // return value
                    return hasSubFolders;
                }
            }
            #endregion
            
            #region IgnoreExceptions
            /// <summary>
            /// This property gets or sets the value for 'IgnoreExceptions'.
            /// </summary>
            public List<IgnoreFolderException> IgnoreExceptions
            {
                get { return ignoreExceptions; }
                set { ignoreExceptions = value; }
            }
            #endregion
            
            #region Name
            /// <summary>
            /// This property gets or sets the value for 'Name'.
            /// </summary>
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            #endregion
            
            #region ParentFolder
            /// <summary>
            /// This property gets or sets the value for 'ParentFolder'.
            /// </summary>
            public Folder ParentFolder
            {
                get { return parentFolder; }
                set { parentFolder = value; }
            }
            #endregion
            
            #region Path
            /// <summary>
            /// This property gets or sets the value for 'Path'.
            /// </summary>
            public string Path
            {
                get { return path; }
                set { path = value; }
            }
            #endregion

            #region Size
            /// <summary>
            /// This read only property returns the size of all the files in this folder
            /// plus the size of all of the subfolders and all their descendants.
            /// </summary>
            public double Size
            {
                get
                {
                    // initial value
                    double size = 0;

                    // if this object has a files object
                    if (this.HasFiles)
                    {
                        // iterate the files                        
                        foreach (FileData file in this.Files)
                        {
                            // add this file's size to the total                          
                            size += file.Size;
                        }
                    }

                    // If the SubFolders object exists
                    if (this.HasSubFolders)
                    {
                        // iterate the collection of folders                        
                        foreach (Folder folder in this.SubFolders)
                        {
                            // add this folder's size to the total
                            size += folder.Size;
                        }
                    }

                    // return value
                    return size;
                }
            }
            #endregion
            
            #region SubFolders
            /// <summary>
            /// This property gets or sets the value for 'SubFolders'.
            /// </summary>
            public List<Folder> SubFolders
            {
                get { return subFolders; }
                set { subFolders = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
