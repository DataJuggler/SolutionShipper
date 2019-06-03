

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SolutionShipper.Objects
{

    #region class FolderStatus
    /// <summary>
    /// This class is used to show the number of subfolders and files in a folder 
    /// and the size of these objects.
    /// </summary>
    public class FolderStatus
    {
        
        #region Private Variables
        private int folderCount;
        private int filesCount;
        private long size;
        #endregion

        #region Properties
        
            #region FilesCount
            /// <summary>
            /// This property gets or sets the value for 'FilesCount'.
            /// </summary>
            public int FilesCount
            {
                get { return filesCount; }
                set { filesCount = value; }
            }
            #endregion
            
            #region FolderCount
            /// <summary>
            /// This property gets or sets the value for 'FolderCount'.
            /// </summary>
            public int FolderCount
            {
                get { return folderCount; }
                set { folderCount = value; }
            }
            #endregion
            
            #region Size
            /// <summary>
            /// This property gets or sets the value for 'Size'.
            /// </summary>
            public long Size
            {
                get { return size; }
                set { size = value; }
            }
            #endregion
            
            #region SizeInKilobytes
            /// <summary>
            /// This read only property returns the value for 'SizeInKilobytes'.
            /// </summary>
            public double SizeInKilobytes
            {
                get
                {
                    // initial value
                    double sizeInKilobytes = 0;
                    
                    // if the value for Size is above 0                    
                    if (this.Size > 0)
                    {
                        // return the value in Kilobytes
                        sizeInKilobytes = this.Size / 1024;
                    }
                    
                    // return the value of size divided by 1024
                    return sizeInKilobytes;
                }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
