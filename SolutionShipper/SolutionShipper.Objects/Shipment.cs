

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SolutionShipper.Objects
{

    #region class Shipment
    /// <summary>
    /// This class represents a Shipment
    /// </summary>
    public class Shipment
    {

        #region Private Variables
        private string name;
        private Options options;
        private string sourceFolderPath;
        private string outputFolderPath;
        private Folder sourceFolder;
        private Folder outputFolder;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a Shipment object
        /// </summary>
        public Shipment()
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
                // Create a new instance of an 'Options' object.
                this.Options = new Options();
            }
            #endregion

        #endregion

        #region Properties

            #region HasOptions
            /// <summary>
            /// This property returns true if this object has an 'Options'.
            /// </summary>
            public bool HasOptions
            {
                get
                {
                    // initial value
                    bool hasOptions = (this.Options != null);
                    
                    // return value
                    return hasOptions;
                }
            }
            #endregion
            
            #region HasOutputFolder
            /// <summary>
            /// This property returns true if this object has an 'OutputFolder'.
            /// </summary>
            public bool HasOutputFolder
            {
                get
                {
                    // initial value
                    bool hasOutputFolder = (this.OutputFolder != null);
                    
                    // return value
                    return hasOutputFolder;
                }
            }
            #endregion
            
            #region HasOutputFolderPath
            /// <summary>
            /// This property returns true if the 'OutputFolderPath' exists.
            /// </summary>
            public bool HasOutputFolderPath
            {
                get
                {
                    // initial value
                    bool hasOutputFolderPath = (!String.IsNullOrEmpty(this.OutputFolderPath));
                    
                    // return value
                    return hasOutputFolderPath;
                }
            }
            #endregion
            
            #region HasSourceFolder
            /// <summary>
            /// This property returns true if this object has a 'SourceFolder'.
            /// </summary>
            public bool HasSourceFolder
            {
                get
                {
                    // initial value
                    bool hasSourceFolder = (this.SourceFolder != null);
                    
                    // return value
                    return hasSourceFolder;
                }
            }
            #endregion
            
            #region HasSourceFolderPath
            /// <summary>
            /// This property returns true if the 'SourceFolderPath' exists.
            /// </summary>
            public bool HasSourceFolderPath
            {
                get
                {
                    // initial value
                    bool hasSourceFolderPath = (!String.IsNullOrEmpty(this.SourceFolderPath));
                    
                    // return value
                    return hasSourceFolderPath;
                }
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
            
            #region Options
            /// <summary>
            /// This property gets or sets the value for 'Options'.
            /// </summary>
            public Options Options
            {
                get { return options; }
                set { options = value; }
            }
            #endregion
            
            #region OutputFolder
            /// <summary>
            /// This property gets or sets the value for 'OutputFolder'.
            /// </summary>
            public Folder OutputFolder
            {
                get { return outputFolder; }
                set { outputFolder = value; }
            }
            #endregion
            
            #region OutputFolderPath
            /// <summary>
            /// This property gets or sets the value for 'OutputFolderPath'.
            /// </summary>
            public string OutputFolderPath
            {
                get { return outputFolderPath; }
                set { outputFolderPath = value; }
            }
            #endregion
            
            #region SourceFolder
            /// <summary>
            /// This property gets or sets the value for 'SourceFolder'.
            /// </summary>
            public Folder SourceFolder
            {
                get { return sourceFolder; }
                set { sourceFolder = value; }
            }
            #endregion
            
            #region SourceFolderPath
            /// <summary>
            /// This property gets or sets the value for 'SourceFolderPath'.
            /// </summary>
            public string SourceFolderPath
            {
                get { return sourceFolderPath; }
                set { sourceFolderPath = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
