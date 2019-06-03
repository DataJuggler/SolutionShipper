

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SolutionShipper.Objects
{

    #region class SolutionStatus
    /// <summary>
    /// This class is used to get the status of a folder and all of its subfolders.
    /// This object contains a Source and an Output FolderStatus and the
    /// two objects are compared.
    /// </summary>
    public class SolutionStatus
    {

        #region Private Variables
        private FolderStatus sourceFolderStatus;
        private FolderStatus outputFolderStatus;
        #endregion

        #region Properties

            #region HasOutputFolderStatus
            /// <summary>
            /// This property returns true if this object has an 'OutputFolderStatus'.
            /// </summary>
            public bool HasOutputFolderStatus
            {
                get
                {
                    // initial value
                    bool hasOutputFolderStatus = (this.OutputFolderStatus != null);
                    
                    // return value
                    return hasOutputFolderStatus;
                }
            }
            #endregion
            
            #region HasSourceFolderStatus
            /// <summary>
            /// This property returns true if this object has a 'SourceFolderStatus'.
            /// </summary>
            public bool HasSourceFolderStatus
            {
                get
                {
                    // initial value
                    bool hasSourceFolderStatus = (this.SourceFolderStatus != null);
                    
                    // return value
                    return hasSourceFolderStatus;
                }
            }
            #endregion
            
            #region OutputFolderStatus
            /// <summary>
            /// This property gets or sets the value for 'OutputFolderStatus'.
            /// </summary>
            public FolderStatus OutputFolderStatus
            {
                get { return outputFolderStatus; }
                set { outputFolderStatus = value; }
            }
            #endregion

            #region ReductionPercentage
            /// <summary>
            /// Return the percentage reduction
            /// </summary>
            public double ReductionPercentage
            {
                get
                {
                    // initial value
                    double percentage = 0;

                    // if the SourceFolderStatus exists
                    if ((this.HasSourceFolderStatus) && (this.HasOutputFolderStatus))
                    {
                        // if the SizeInKiloBytes is set for both the Source and Output Status objects
                        if ((this.OutputFolderStatus.SizeInKilobytes > 0) && (this.SourceFolderStatus.SizeInKilobytes > 0))
                        {
                            // Set the value as a percentage
                            percentage = 1 - this.OutputFolderStatus.SizeInKilobytes / this.SourceFolderStatus.SizeInKilobytes;
                        }
                    }

                    // return value
                    return percentage;
                }
            }
            #endregion
            
            #region ReductionSize
            /// <summary>
            /// This read only property returns the value for 'ReductionSize'.
            /// </summary>
            public double ReductionSize
            {
                get
                {
                    // initial value
                    double reductionSize = 0;
                    
                    // if the Source and Output FolderStatus objects exist
                    if ((this.HasSourceFolderStatus) && (this.HasOutputFolderStatus))
                    {
                        // set the return value
                        reductionSize = this.SourceFolderStatus.Size - this.OutputFolderStatus.Size;
                    }
                    
                    // return value
                    return reductionSize;
                }
            }
            #endregion

            #region ReductionSizeInKilobytes
            /// <summary>
            /// This read only property returns the value for 'ReductionSizeInKilobytes'.
            /// </summary>
            public double ReductionSizeInKilobytes
            {
                get
                {
                    // initial value
                    double reductionSizeInKilobytes = 0;
                    
                    // if the Source and Output FolderStatus objects exist
                    if ((this.HasSourceFolderStatus) && (this.HasOutputFolderStatus))
                    {
                        // set the return value
                        reductionSizeInKilobytes = this.SourceFolderStatus.SizeInKilobytes - this.OutputFolderStatus.SizeInKilobytes;
                    }
                    
                    // return value
                    return reductionSizeInKilobytes;
                }
            }
            #endregion
            
            #region SourceFolderStatus
            /// <summary>
            /// This property gets or sets the value for 'SourceFolderStatus'.
            /// </summary>
            public FolderStatus SourceFolderStatus
            {
                get { return sourceFolderStatus; }
                set { sourceFolderStatus = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
