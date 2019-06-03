

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Core.UltimateHelper;
using SolutionShipper.Objects;
using SolutionShipper.Enumerations;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;

#endregion

namespace SolutionShipper
{

    #region class IgnoreFolderExceptionEditor
    /// <summary>
    /// This class is used to add an exception to the ignoring folder content.
    /// </summary>
    public partial class IgnoreFolderExceptionEditor : Form, ITextChanged, ISelectedIndexListener
    {
        
        #region Private Variables
        private IgnoreFolderException selectedIgnoreFolderException;
        private Folder ignoreFolder;
        #endregion
    
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'IgnoreFolderExceptionEditor' object.
        /// </summary>
        public IgnoreFolderExceptionEditor()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion

        #region Events
            
            #region AddIgnoreExceptionButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'AddIgnoreExceptionButton' is clicked.
            /// </summary>
            private void AddIgnoreExceptionButton_Click(object sender, EventArgs e)
            {
                // If the IgnoreExceptions object exists
                if (this.HasIgnoreExceptions)
                {
                    // Create a new instance of an 'IgnoreFolderException' object.
                    IgnoreFolderException exception = new IgnoreFolderException();

                    // Add the name that must be changed
                    exception.Name = "New Exception";

                    // Add this exception
                    this.IgnoreExceptions.Add(exception);

                    // Display the exceptions
                    this.DisplayExceptions(exception);
                    
                    // Set Focus to the Textbox
                    this.ExceptionNameControl.SetFocusToTextBox();
                }
            }
            #endregion
            
            #region Button_Enter(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Enter
            /// </summary>
            private void Button_Enter(object sender, EventArgs e)
            {
                // Change the cursor to a hand
                this.Cursor = Cursors.Hand;
            }
            #endregion
            
            #region Button_Leave(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Button _ Leave
            /// </summary>
            private void Button_Leave(object sender, EventArgs e)
            {
                // Change the cursor back to the default pointer
                this.Cursor = Cursors.Default;
            }
        #endregion
            
            #region DoneExceptionsButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'DoneExceptionsButton' is clicked.
            /// </summary>
            private void DoneExceptionsButton_Click(object sender, EventArgs e)
            {
                // close this form
                this.Close();
            }
            #endregion
                        
            #region IgnoreFoldersListBox_KeyDown(object sender, KeyEventArgs e)
            /// <summary>
            /// event is fired when Ignore Folders List Box _ Key Down
            /// </summary>
            private void IgnoreFoldersListBox_KeyDown(object sender, KeyEventArgs e)
            {
                // if the delete key was pressed
                if ((e.KeyCode == Keys.Delete) && (this.HasIgnoreExceptions) && (this.IgnoreFoldersListBox.SelectedItem != null))
                {
                    // cast the SelectedItem as an IgnoreFolderException
                    IgnoreFolderException exception = this.IgnoreFoldersListBox.SelectedItem as IgnoreFolderException;

                    // If the exception object exists
                    if (NullHelper.Exists(exception))
                    {
                        // attempt to find the index of the selected exception
                        int index = this.IgnoreExceptions.IndexOf(exception);

                        // if the index was found
                        if (index >= 0)
                        {
                            // remove this exception
                            this.IgnoreExceptions.RemoveAt(index);

                            // Display the exceptions
                            this.DisplayExceptions(null);
                        }
                    }
                }
            }
            #endregion
            
            #region IgnoreFoldersListBox_SelectedIndexChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a selection is made in the 'IgnoreFoldersListBox_'.
            /// </summary>
            private void IgnoreFoldersListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Set the Selected Folder Exception
                this.SelectedIgnoreFolderException = this.IgnoreFoldersListBox.SelectedItem as IgnoreFolderException;    

                // Display the selected item
                this.DisplayException(this.SelectedIgnoreFolderException);
            }
            #endregion
            
            #region OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            /// <summary>
            /// The Selected has changed.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="selectedIndex"></param>
            public void OnSelectedIndexChanged(LabelComboBoxControl control, int selectedIndex, object selectedItem)
            {
                // if the control and selectedItem both exist                                
                if ((NullHelper.Exists(control, selectedItem)) && (this.HasSelectedIgnoreFolderException))
                {
                    // set the exceptionType
                    IgnoreFolderExceptionTypeEnum exceptionType = ParseExceptionType(selectedItem);

                    // Set the exceptionType
                    this.SelectedIgnoreFolderException.IgnoreExceptionType = exceptionType;
                }
            }
            #endregion

            #region OnTextChanged(LabelTextBoxControl sender, string text)
            /// <summary>
            /// The Selected has changed.
            /// </summary>
            /// <param name="control"></param>
            /// <param name="selectedIndex"></param>
            public void OnTextChanged(Control control, string text)
            {
                // cast the sender as a LabelTextBoxControl
                LabelTextBoxControl sender = control as LabelTextBoxControl;

                // if the sender exists and there is a SelectedIgnoreFodlerException
                if ((NullHelper.Exists(sender)) && (this.HasSelectedIgnoreFolderException))
                {
                    // if this is the ExceptionNameControl
                    if (sender.Name == "ExceptionNameControl")
                    {
                        // set the name
                        this.SelectedIgnoreFolderException.Name = text;

                        // Display the Exceptions
                        this.DisplayExceptions(this.SelectedIgnoreFolderException);
                    }
                    else if (sender.Name == "ExceptionTextControl")
                    {
                        // set the text
                        this.SelectedIgnoreFolderException.Text = text;
                    }
                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region DisplayException(IgnoreFolderException exception)
            /// <summary>
            /// This method Display Exception
            /// </summary>
            public void DisplayException(IgnoreFolderException exception)
            {
                // locals
                string name = "";
                int selectedIndex = -1;
                string text = "";

                // If the exception object exists
                if (NullHelper.Exists(exception))
                {
                    // set the values
                    name = exception.Name;
                    selectedIndex = this.IgnoreExceptionType.FindItemIndexByValue(exception.IgnoreExceptionType.ToString());
                    text = exception.Text;
                }

                // Display the values
                this.ExceptionNameControl.Text = name;
                this.IgnoreExceptionType.SelectedIndex = selectedIndex;
                this.ExceptionTextControl.Text = text; 
            }
            #endregion
            
            #region DisplayExceptions()
            /// <summary>
            /// This method Display Exceptions
            /// </summary>
            public void DisplayExceptions(IgnoreFolderException selectedException = null)
            {
                // Clear the ListBox
                this.IgnoreFoldersListBox.Items.Clear();

                // locals
                int index = -1;
                int selectedIndex = -1;

                // If the IgnoreExceptions object exists
                if (this.HasIgnoreExceptions)
                {
                    // iterate the exceptions                    
                    foreach (IgnoreFolderException exception in this.IgnoreExceptions)
                    {
                        // Increment the value for index
                        index++;

                        // if the selected exception exists
                        if (NullHelper.Exists(selectedException))
                        {
                            // if this is the selected item
                            if (exception.Name == selectedException.Name)
                            {
                                // set the selectedIndex
                                selectedIndex = index;

                                // Set the SelectedIgnoreFolderException
                                this.SelectedIgnoreFolderException = exception;
                            }
                        }

                        // Add this object
                        this.IgnoreFoldersListBox.Items.Add(exception);
                    }

                    // set the selected index
                    this.IgnoreFoldersListBox.SelectedIndex = selectedIndex;

                    // Display the Exception
                    this.DisplayException(this.SelectedIgnoreFolderException);
                }
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Setup the listeners
                this.IgnoreExceptionType.SelectedIndexListener = this;
                this.ExceptionNameControl.OnTextChangedListener = this;
                this.ExceptionTextControl.OnTextChangedListener = this;
                
                // Load the items
                this.IgnoreExceptionType.LoadItems(typeof(IgnoreFolderExceptionTypeEnum));
            }
            #endregion
            
            #region ParseExceptionType(object selectedItem)
            /// <summary>
            /// This method returns the Exception Type
            /// </summary>
            public IgnoreFolderExceptionTypeEnum ParseExceptionType(object selectedItem)
            {
                // initial value
                IgnoreFolderExceptionTypeEnum exceptionType = IgnoreFolderExceptionTypeEnum.Do_Not_Add_Any_Content;

                // If the selectedItem object exists
                if (NullHelper.Exists(selectedItem))
                {
                    // get the text of the selectedItem
                    string text = selectedItem.ToString();

                    // Determine the action by the text
                    switch (text)
                    {

                        case "Do Not Add Any Content":

                            // Set the return value
                            exceptionType = IgnoreFolderExceptionTypeEnum.Do_Not_Add_Any_Content;

                            // required
                            break;

                        case "Do Not Add Matching Extensions":

                            // Set the return value
                            exceptionType = IgnoreFolderExceptionTypeEnum.Do_Not_Add_Matching_Extensions;

                            // required
                            break;

                        case "Do Not Add Matching Names":
                        
                            // Set the return value
                            exceptionType = IgnoreFolderExceptionTypeEnum.Do_Not_Add_Matching_Names;

                            // required
                            break;

                        case "Do Not Copy The Folder":

                            // Set the return value
                            exceptionType = IgnoreFolderExceptionTypeEnum.Do_Not_Copy_The_Folder;

                            // required
                            break;

                        case "Add Matching Extensions":

                            // Set the return value
                            exceptionType = IgnoreFolderExceptionTypeEnum.Add_Matching_Extensions;

                            // required
                            break;

                        case "Add Matching Names":

                            // Set the return value
                            exceptionType = IgnoreFolderExceptionTypeEnum.Add_Matching_Names;

                            // required
                            break;
                    }
                }
                
                // return value
                return exceptionType;
            }
            #endregion
            
            #region Setup(Folder selectedFolder)
            /// <summary>
            /// method sets the SelectedFolder
            /// </summary>
            public void Setup(Folder selectedFolder)
            {
                // set the ignore folder
                this.IgnoreFolder = selectedFolder;

                // if the IgnoreFolder exists and the selectedFolder exists
                if ((this.HasIgnoreFolder) && (NullHelper.Exists(selectedFolder)))
                {
                    // display the name
                    this.IgnoreFolderNameLabel.Text = selectedFolder.Name;
                }

                // Display the exceptions if any
                this.DisplayExceptions();
            }
            #endregion
            
        #endregion

        #region Properties
            
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
            
            #region HasIgnoreFolder
            /// <summary>
            /// This property returns true if this object has an 'IgnoreFolder'.
            /// </summary>
            public bool HasIgnoreFolder
            {
                get
                {
                    // initial value
                    bool hasIgnoreFolder = (this.IgnoreFolder != null);
                    
                    // return value
                    return hasIgnoreFolder;
                }
            }
            #endregion
            
            #region HasSelectedIgnoreFolderException
            /// <summary>
            /// This property returns true if this object has a 'SelectedIgnoreFolderException'.
            /// </summary>
            public bool HasSelectedIgnoreFolderException
            {
                get
                {
                    // initial value
                    bool hasSelectedIgnoreFolderException = (this.SelectedIgnoreFolderException != null);
                    
                    // return value
                    return hasSelectedIgnoreFolderException;
                }
            }
            #endregion

            #region IgnoreExceptions
            /// <summary>
            /// This read only property returns the IgnoreExceptions from the IgnoreFolder
            /// </summary>
            List<IgnoreFolderException> IgnoreExceptions
            {
                get
                {
                    // initial value
                    List<IgnoreFolderException> ignoreExceptions = null;

                    // If the IgnoreFolder object exists
                    if (this.HasIgnoreFolder)
                    {
                        // set the return value
                        ignoreExceptions = this.IgnoreFolder.IgnoreExceptions;
                    }

                    // return value
                    return ignoreExceptions;
                }
            }
            #endregion
            
            #region IgnoreFolder
            /// <summary>
            /// This property gets or sets the value for 'IgnoreFolder'.
            /// </summary>
            public Folder IgnoreFolder
            {
                get { return ignoreFolder; }
                set { ignoreFolder = value; }
            }
            #endregion
            
            #region SelectedIgnoreFolderException
            /// <summary>
            /// This property gets or sets the value for 'SelectedIgnoreFolderException'.
            /// </summary>
            public IgnoreFolderException SelectedIgnoreFolderException
            {
                get { return selectedIgnoreFolderException; }
                set { selectedIgnoreFolderException = value; }
            }
        #endregion

        #endregion
            
    }
    #endregion

}
