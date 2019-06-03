

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

    #region class IgnoreFolderException
    /// <summary>
    /// This class is used to add exceptions to how folder content is handled.
    /// </summary>
    public class IgnoreFolderException
    {

        #region Private Variables
        private IgnoreFolderExceptionTypeEnum ignoreExceptionType;
        private int exceptionTypeValue;
        private string text;
        private string name;
        #endregion

        #region Methods

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

            #region ExceptionTypeValue
            /// <summary>
            /// This property gets or sets the value for 'ExceptionTypeValue'.
            /// </summary>
            public int ExceptionTypeValue
            {
                get { return exceptionTypeValue; }
                set 
                { 
                    // set the integer value
                    exceptionTypeValue = value;

                    // Set the IgnoreExceptionType
                    this.IgnoreExceptionType = (IgnoreFolderExceptionTypeEnum) exceptionTypeValue;
                }
            }
            #endregion
            
            #region HasIgnoreExceptionType
            /// <summary>
            /// This property returns true if this object has an 'IgnoreExceptionType'.
            /// </summary>
            public bool HasIgnoreExceptionType
            {
                get
                {
                    // initial value
                    bool hasIgnoreExceptionType = (this.IgnoreExceptionType != IgnoreFolderExceptionTypeEnum.Do_Not_Add_Any_Content);
                    
                    // return value
                    return hasIgnoreExceptionType;
                }
            }
            #endregion
            
            #region HasText
            /// <summary>
            /// This property returns true if the 'Text' exists.
            /// </summary>
            public bool HasText
            {
                get
                {
                    // initial value
                    bool hasText = (!String.IsNullOrEmpty(this.Text));
                    
                    // return value
                    return hasText;
                }
            }
            #endregion
            
            #region IgnoreExceptionType
            /// <summary>
            /// This property gets or sets the value for 'IgnoreExceptionType'.
            /// </summary>
            public IgnoreFolderExceptionTypeEnum IgnoreExceptionType
            {
                get { return ignoreExceptionType; }
                set { ignoreExceptionType = value; }
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
            
            #region Text
            /// <summary>
            /// This property gets or sets the value for 'Text'.
            /// </summary>
            public string Text
            {
                get { return text; }
                set { text = value; }
            }
            #endregion
            
        #endregion

    }
    #endregion

}
