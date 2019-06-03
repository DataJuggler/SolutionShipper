

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SolutionShipper.Objects
{

    #region class FileData
    /// <summary>
    /// This class represents a File on the file system.
    /// </summary>
    public class FileData
    {

        #region Private Variables
        private string name;
        private string path;
        private double size;
        #endregion

        #region Constructors

            #region Default Constructor
            /// <summary>
            /// Create a new instance of a FileData object
            /// </summary>
            public FileData()
            {
                
            }
            #endregion

            #region Parameterized Constructor(string name, string path, double size)
            /// <summary>
            /// Create a new instance of a FileData object
            /// </summary>
            /// <param name="name"></param>
            /// <param name="path"></param>
            /// <param name="size"></param>
            public FileData(string name, string path, double size)
            {
                // Store the arguments
                this.Name = name;
                this.Path = path;
                this.Size = size;
            }
            #endregion

        #endregion

        #region Properties
        
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
            /// This property gets or sets the value for 'Size'.
            /// </summary>
            public double Size
            {
                get { return size; }
                set { size = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
