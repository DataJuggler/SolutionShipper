

#region using statements

using DataJuggler.Core.UltimateHelper;
using SolutionShipper.Objects;
using SolutionShipper.Parsers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

#endregion

namespace SolutionShipper
{

    #region class MainForm
    /// <summary>
    /// This is the main form for this application
    /// </summary>
    public partial class MainForm : Form
    {

        #region Private Variables
        private ShipManager shipManager;
        private Shipment selectedShipment;
        #endregion

        #region Constructor
        /// <summary>
        /// Create a new instance of a 'MainForm' object.
        /// </summary>
        public MainForm()
        {
            // Create Controls
            InitializeComponent();

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region AddIgnoreFolderButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'AddIgnoreFolderButton' is clicked.
            /// </summary>
            private void AddIgnoreFolderButton_Click(object sender, EventArgs e)
            {
                // set the selectedPath
                string selectedPath = this.SourceFolderTextBox.Text;

                // Choose a folder to ignore
                DialogHelper.ChooseFolder(this.IgnorFolderTextBox, selectedPath);
            }
            #endregion
            
            #region BrowseOutputFolderButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'BrowseOutputFolderButton' is clicked.
            /// </summary>
            private void BrowseOutputFolderButton_Click(object sender, EventArgs e)
            {
                // Choose the folder
                DialogHelper.ChooseFolder(this.OutputFolderTextBox.GetTextBox());
            }
            #endregion
            
            #region BrowseSourceFolderButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'BrowseSourceFolderButton' is clicked.
            /// </summary>
            private void BrowseSourceFolderButton_Click(object sender, EventArgs e)
            {
                // Choose the folder
                DialogHelper.ChooseFolder(this.SourceFolderTextBox.GetTextBox());
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

            #region IgnoreFoldersListBox_DoubleClick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Ignore Folders List Box _ Double Click
            /// </summary>
            private void IgnoreFoldersListBox_DoubleClick(object sender, EventArgs e)
            {
                // get the selectedFolder
                Folder selectedFolder = this.IgnoreFoldersListBox.SelectedItem as Folder;

                // If the selectedFolder object exists
                if (NullHelper.Exists(selectedFolder))
                {
                    // create the editor                    
                    IgnoreFolderExceptionEditor editor = new SolutionShipper.IgnoreFolderExceptionEditor();

                    // setup the folder
                    editor.Setup(selectedFolder);

                    // Show the editor
                    editor.ShowDialog();
                }
            }
            #endregion
            
            #region IgnoreFoldersListBox_KeyDown(object sender, KeyEventArgs e)
            /// <summary>
            /// event is fired when Ignore Folders List Box _ Key Down
            /// </summary>
            private void IgnoreFoldersListBox_KeyDown(object sender, KeyEventArgs e)
            {
                // if the delete key was pressed
                if ((e.KeyCode == Keys.Delete) && (this.IgnoreFoldersListBox.SelectedIndex >= 0))
                {
                    // remove the selected item
                    this.IgnoreFoldersListBox.Items.RemoveAt(this.IgnoreFoldersListBox.SelectedIndex);
                }
            }
            #endregion
            
            #region IgnorFolderTextBox_TextChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Ignor Folder Text Box _ Text Changed
            /// </summary>
            private void IgnorFolderTextBox_TextChanged(object sender, EventArgs e)
            {
                // if the TextBox has text
                if ((TextHelper.Exists(this.IgnorFolderTextBox.Text)) && (this.HasShipManager))
                {
                    // Create a new instance of a 'DirectoryInfo' object.
                    DirectoryInfo folderInfo = new DirectoryInfo(this.IgnorFolderTextBox.Text);

                    // get the name of the Folder
                    string name = folderInfo.Name;

                    // create a folder
                    Folder folder = new Folder();

                    // set the folder name
                    folder.Name = name;

                    // Set the path
                    folder.Path = folderInfo.FullName;

                    // Add this text
                    this.IgnoreFoldersListBox.Items.Add(folder);

                    // Erase the textbox
                    this.IgnorFolderTextBox.Text = "";
                }
            }
            #endregion
            
            #region OpenShipmentButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'OpenShipmentButton' is clicked.
            /// </summary>
            private void OpenShipmentButton_Click(object sender, EventArgs e)
            {
                // get the shipmentsFolder
                string shipmentsFolder = GetShipmentsFolder();

                // Ensure the folders exist
                EnsureFoldersExist(shipmentsFolder);

                // create the form to open the shipments
                OpenShipmentForm openForm = new OpenShipmentForm(shipmentsFolder);

                // Show the form
                openForm.ShowDialog();

                // if the user did not cancel
                if ((!openForm.UserCancelled) && (openForm.HasSelectedShipmentPath))
                {
                    // Get the path to the file to be parsed
                    string path = openForm.SelectedShipmentPath;

                    // If the path string exists
                    if (TextHelper.Exists(path))
                    {
                        // Get the full text of the xml document
                        string shipmentXmlText = File.ReadAllText(path);

                        // Create a new instance of a 'ShipmentParser' object.
                        ShipmentParser parser = new ShipmentParser(path);

                        // parse the shipment
                        this.SelectedShipment = parser.ParseShipment(shipmentXmlText);

                        // If the SelectedShipment exists
                        if (this.HasSelectedShipment)
                        {
                            // Display the selected shipment
                            this.DisplaySelectedShipment();
                        }
                        else
                        {
                            // Show the user a message something went wrong
                            MessageBoxHelper.ShowMessage("The shipment could not be opened.", "Open Failure");
                        }
                    }
                }
            }
            #endregion
            
            #region SaveShipmentButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SaveShipmentButton' is clicked.
            /// </summary>
            private void SaveShipmentButton_Click(object sender, EventArgs e)
            {
                // Save the current shipment
                SaveShipment();
            }
            #endregion
            
            #region ShipSolutionButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'ShipSolutionButton' is clicked.
            /// </summary>
            private void ShipSolutionButton_Click(object sender, EventArgs e)
            {
                // Clear only the bottom part of the screen (Status, Graph and DestinationLabel
                this.Clear(true);

                // Capture the current shipment
                Shipment shipment = CaptureShipment();

                // If the shipment object exists
                if (NullHelper.Exists(shipment))
                {
                    // Perform the shipment
                    SolutionStatus status = ShipManager.Ship(shipment, this.Graph);

                    // If the status object exists
                    if (NullHelper.Exists(status))
                    {
                        // hide the graph
                        this.Graph.Visible = false;

                        // Display the Status results
                        DisplayShipmentStatus(status);

                        // Display the text of the output folder
                        this.DestinationLabel.Text = "Destination: " + shipment.OutputFolder.Path;
                        this.DestinationLabel.Visible = true;
                    }
                }
            }
            #endregion

        #endregion

        #region Methods
            
            #region CaptureShipment()
            /// <summary>
            /// This method returns the Ship Manager
            /// </summary>
            public Shipment CaptureShipment()
            {
                // initial value
                Shipment shipment = new Shipment();

                // Capture the top portions
                shipment.Name = this.ShipmentNameControl.Text;
                shipment.SourceFolderPath = this.SourceFolderTextBox.Text;
                shipment.OutputFolderPath = this.OutputFolderTextBox.Text;

                // set the options
                shipment.Options.DeleteBinFolder = this.BinCheckBox.Checked;
                shipment.Options.DeleteObjFolder = this.ObjCheckBox.Checked;
                shipment.Options.DeletePackagesFolder = this.PackagesCheckBox.Checked;
                shipment.Options.ZipProject = this.ZipCheckBox.Checked;
                shipment.Options.Copy = this.CopyCheckBox.Checked;
                shipment.Options.AddTimestamp = this.AddTimeStampCheckBox.Checked;

                // Load the DoNotCopyFolder
                shipment.Options.DoNotCopyContentFolders = LoadDoNotCopyContentFolders();
                
                // return value
                return shipment;
            }
            #endregion

            #region Clear(bool justStatus = false)
            /// <summary>
            /// This method Clear
            /// </summary>
            public void Clear(bool justStatus = false)
            {
                // if the value for justStatus is false
                if (!justStatus)
                {
                    // Clear all the controls
                    this.ShipmentNameControl.Text = "";
                    this.SourceFolderTextBox.Text = "";
                    this.OutputFolderTextBox.Text = "";
                    this.BinCheckBox.Checked = false;
                    this.ObjCheckBox.Checked = false;
                    this.PackagesCheckBox.Checked = false;
                    this.ZipCheckBox.Checked = false;
                    this.CopyCheckBox.Checked = false;
                    this.AddTimeStampCheckBox.Checked = false;
                    this.IgnoreFoldersListBox.Items.Clear();
                }
                
                // Clear the Status
                SolutionStatus status = new SolutionStatus();
                status.OutputFolderStatus = new FolderStatus();
                status.SourceFolderStatus = new FolderStatus();
                
                // Erase the status values
                this.DisplayShipmentStatus(status);

                // Hide the graph
                this.DestinationLabel.Visible = false;
                this.Graph.Visible = false;
            }
            #endregion
            
            #region CreateDoNotCopyContentFolders(Shipment shipment)
            /// <summary>
            /// This method returns the Do Not Copy Content Folders
            /// </summary>
            public string CreateDoNotCopyContentFolders(Shipment shipment)
            {
                // initial value
                string folderDetail = string.Empty;

                // locals
                string indent3 = "      ";
                string indent4 = "        ";
                string indent5 = "          ";
                string indent6 = "            ";
                StringBuilder sb = new StringBuilder();
                string openFolder = indent3 + "<Folder>" + Environment.NewLine;
                string closeFolder = indent3 + "</Folder>" + Environment.NewLine;
                string folderName = indent4 + "<Name>" + "[Name]" + "</Name>" + Environment.NewLine;
                string folderNameValue = "";
                string folderPath = indent4 + "<Path>" + "[Path]" + "</Path>" + Environment.NewLine;
                string folderPathValue = "";
                string openExceptions = indent4 + "<Exceptions>" + Environment.NewLine;
                string closeExceptions = indent4 + "</Exceptions>" + Environment.NewLine;
                string openException = indent5 + "<Exception>" + Environment.NewLine;
                string closeException = indent5 + "</Exception>" + Environment.NewLine;
                string exceptionName = indent6 + "<Name>" + "[Name]" + "</Name>" + Environment.NewLine;
                string exceptionType = indent6 + "<ExceptionType>" + "[ExceptionType]" + "</ExceptionType>" + Environment.NewLine;
                string exceptionText = indent6 + "<Text>" + "[Text]" + "</Text>" + Environment.NewLine;
                string exceptionNameValue = "";
                string exceptionTypeValue = "";
                string exceptionTextValue = "";

                // If the shipment object exists
                if ((NullHelper.Exists(shipment)) && (shipment.HasOptions) && (shipment.Options.HasDoNotCopyContentFolders))
                {
                    // if there are one or more folders
                    if (ListHelper.HasOneOrMoreItems(shipment.Options.DoNotCopyContentFolders))
                    {
                        // iterate the DoNotCopyContentFolders
                        foreach (Folder folder in shipment.Options.DoNotCopyContentFolders)
                        {
                            // Write the open Folder
                            sb.Append(openFolder);

                            // Create the properties for the folder
                            folderNameValue = folderName.Replace("[Name]", folder.Name);
                            folderPathValue = folderPath.Replace("[Path]", folder.Path);

                            // Write out the Properties for the folder
                            sb.Append(folderNameValue);
                            sb.Append(folderPathValue);

                            // if there are one or more exceptions
                            if (ListHelper.HasOneOrMoreItems(folder.IgnoreExceptions))
                            {
                                // Add the open exceptions
                                sb.Append(openExceptions);

                                // iterate the exceptions
                                foreach (IgnoreFolderException exception in folder.IgnoreExceptions)
                                {
                                    // Add the openException
                                    sb.Append(openException);

                                    // Set the exception properties
                                    exceptionNameValue = exceptionName.Replace("[Name]", exception.Name);
                                    exceptionTypeValue = exceptionType.Replace("[ExceptionType]", ((int) exception.IgnoreExceptionType).ToString());
                                    exceptionTextValue = exceptionText.Replace("[Text]", exception.Text);

                                    // Now add the exception properties
                                    sb.Append(exceptionNameValue);
                                    sb.Append(exceptionTypeValue);
                                    sb.Append(exceptionTextValue);

                                    // Add the closeException
                                    sb.Append(closeException);
                                }

                                // Add the close exceptions
                                sb.Append(closeExceptions);
                            }

                            // Write the close Folder
                            sb.Append(closeFolder);
                        }

                        // Set the return value
                        folderDetail = sb.ToString();
                    }
                }

                
                
                // return value
                return folderDetail;
            }
            #endregion
            
            #region DisplaySelectedShipment()
            /// <summary>
            /// This method Display Selected Shipment
            /// </summary>
            public void DisplaySelectedShipment()
            {
                // locals
                string name = "";
                string sourceFolderPath = "";
                string outputFolderPath = "";
                bool deleteBinFolder = false;
                bool deleteObjFolder = false;
                bool deletePackagesFolder = false;
                bool zipProject = false;
                bool copy = false;
                bool addTimestamp = false;
                List<Folder> ignoreFolders = null;

                // Clear this form
                this.Clear();

                // If the SelectedShipment object exists
                if (this.HasSelectedShipment)
                {
                    // get a local reference
                    Shipment shipment = this.SelectedShipment;

                    // set the values
                    name = shipment.Name;
                    sourceFolderPath = shipment.SourceFolderPath;
                    outputFolderPath = shipment.OutputFolderPath;
                    
                    // get a local copy of the options
                    Options options = shipment.Options;

                    // set the options value
                    deleteBinFolder = options.DeleteBinFolder;
                    deleteObjFolder = options.DeleteObjFolder;
                    deletePackagesFolder = options.DeletePackagesFolder;
                    zipProject = options.ZipProject;
                    copy = options.Copy;
                    addTimestamp = options.AddTimestamp;

                    // Set the folders to ignore
                    ignoreFolders = shipment.Options.DoNotCopyContentFolders;
                }

                // display the value
                this.ShipmentNameControl.Text = name;
                this.SourceFolderTextBox.Text = sourceFolderPath;
                this.OutputFolderTextBox.Text = outputFolderPath;
                this.BinCheckBox.Checked =deleteBinFolder;
                this.ObjCheckBox.Checked = deleteObjFolder;
                this.PackagesCheckBox.Checked = deletePackagesFolder;
                this.ZipCheckBox.Checked = zipProject;
                this.CopyCheckBox.Checked = copy;
                this.AddTimeStampCheckBox.Checked = addTimestamp;

                // If the ignoreFolders collection exists and has one or more items
                if (ListHelper.HasOneOrMoreItems(ignoreFolders))
                {
                    // Display the folders

                    // Iterate the collection of Folder objects
                    foreach (Folder folder in ignoreFolders)    
                    {
                        // Add this folder
                        this.IgnoreFoldersListBox.Items.Add(folder);
                    }
                }
            }
            #endregion
            
            #region DisplayShipmentStatus(SolutionStatus status)
            /// <summary>
            /// This method Display Shipment Status
            /// </summary>
            public void DisplayShipmentStatus(SolutionStatus status)
            {
                // locals
                string sourceFoldersCount = "0";
                string sourceFilesCount = "0";
                string sourceSizeInKilobytes = "0";
                string outputFoldersCount = "0";
                string outputFilesCount = "0";
                string outputSizeInKilobytes = "0";
                string reductionInKilobytes = "0";
                string reductionPercentage = "0";

                // If the status object exists
                if (NullHelper.Exists(status))
                {
                    // Set the sourceFoldersCount
                    sourceFoldersCount = string.Format("{0:n0}", status.SourceFolderStatus.FolderCount);
                    sourceFilesCount = string.Format("{0:n0}", status.SourceFolderStatus.FilesCount);
                    sourceSizeInKilobytes = string.Format("{0:n0}", status.SourceFolderStatus.SizeInKilobytes) + " kb";
                    outputFoldersCount = string.Format("{0:n0}", status.OutputFolderStatus.FolderCount);
                    outputFilesCount = string.Format("{0:n0}", status.OutputFolderStatus.FilesCount);
                    outputSizeInKilobytes = string.Format("{0:n0}", status.OutputFolderStatus.SizeInKilobytes) + " kb";
                    reductionInKilobytes = string.Format("{0:n0}", status.ReductionSizeInKilobytes) + " kb";
                    reductionPercentage = String.Format("{0:P2}", status.ReductionPercentage);
                }
                
                // display the values
                this.SourceFoldersCountValueLabel.Text = sourceFoldersCount;
                this.SourceFilesCountValueLabel.Text = sourceFilesCount;
                this.SourceSizeValueLabel.Text = sourceSizeInKilobytes;
                this.OutputFolderCountValueLabel.Text = outputFoldersCount;
                this.OutputFilesCountValueLabel.Text = outputFilesCount;
                this.OutputSizeValueLabel.Text = outputSizeInKilobytes;
                this.ReductionSizeValueLabel.Text = reductionInKilobytes;
                this.ReductionPercentValueLabel.Text = reductionPercentage;
            }
            #endregion
            
            #region EnsureFoldersExist(string shipmentsFolder)
            /// <summary>
            /// This method Ensure Folders Exist
            /// </summary>
            public void EnsureFoldersExist(string shipmentsFolder)
            {
                // First we have to ensure the Data Juggler folder exists
                string dataJugglerFolder = shipmentsFolder.Replace(@"\Solution Shipper\Shipments", "");
                string productFolder = shipmentsFolder.Replace(@"\Shipments", "");

                // if the 'Data Juggler' folder does not exist
                if (!Directory.Exists(dataJugglerFolder))
                {
                    // Create the 'Data Juggler' folder
                    Directory.CreateDirectory(dataJugglerFolder);
                }

                // if the 'Solution Shipper' folder does not exist
                if (!Directory.Exists(productFolder))
                {
                    // Create the 'Solution Shipper' folder
                    Directory.CreateDirectory(productFolder);
                }

                // if the 'Shipments' folder does not exist
                if (!Directory.Exists(shipmentsFolder))
                {
                    // Create the 'Solution Shipper' folder
                    Directory.CreateDirectory(shipmentsFolder);
                }
            }
            #endregion
            
            #region ExportShipment(Shipment shipment)
            /// <summary>
            /// This method Export Shipment
            /// </summary>
            public string ExportShipment(Shipment shipment)
            {
                // initial value
                string xml = "";

                // If the shipment object exists
                if (NullHelper.Exists(shipment))
                {
                    // locals (lines to be added
                    string indent = "  ";
                    string indent2 = "    ";
                    string xmlDeclaration = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine;
                    string openShipment = "<Shipment >" + Environment.NewLine;
                    string closeShipment = "</Shipment >" + Environment.NewLine;
                    string shipmentName = indent + "<Name>" + shipment.Name + "</Name>" + Environment.NewLine;
                    string sourceFolderPath = indent + "<SourceFolderPath>" + shipment.SourceFolderPath + "</SourceFolderPath>" + Environment.NewLine;
                    string outputFolderPath = indent + "<OutputFolderPath>" + shipment.OutputFolderPath + "</OutputFolderPath>" + Environment.NewLine;
                    string openOptions = indent + "<Options>" + Environment.NewLine;
                    string closeOptions = indent + "</Options>" + Environment.NewLine;
                    string deleteBinFolder = indent2 + "<DeleteBinFolder>" + shipment.Options.DeleteBinFolder.ToString() + "</DeleteBinFolder>" + Environment.NewLine;
                    string deleteObjFolder = indent2 + "<DeleteObjFolder>" + shipment.Options.DeleteObjFolder.ToString() + "</DeleteObjFolder>" + Environment.NewLine;
                    string deletePackagesFolder = indent2 + "<DeletePackagesFolder>" + shipment.Options.DeletePackagesFolder.ToString() + "</DeletePackagesFolder>" + Environment.NewLine;
                    string zipProject = indent2 + "<ZipProject>" + shipment.Options.ZipProject.ToString() + "</ZipProject>" + Environment.NewLine;
                    string copyProject = indent2 + "<Copy>" + shipment.Options.Copy.ToString() + "</Copy>" + Environment.NewLine;
                    string addTimestamp = indent2 + "<AddTimestamp>" + shipment.Options.AddTimestamp.ToString() + "</AddTimestamp>" + Environment.NewLine;

                    // Now we must write out the DoNotCopyContentFolders
                    string openDoNotCopyContentFolder = indent2 + "<DoNotCopyContentFolders>" + Environment.NewLine;
                    string closeDoNotCopyContentFolder = indent2 + "</DoNotCopyContentFolders>" + Environment.NewLine;

                    // this holds a collection of lines for each folder
                    string doNotCopyContentFolders = CreateDoNotCopyContentFolders(shipment);
                    
                    // Create a new instance of a 'StringBuilder' object.
                    StringBuilder sb = new StringBuilder();

                    // Append each line
                    sb.Append(xmlDeclaration);
                    sb.Append(openShipment);
                    sb.Append(shipmentName);
                    sb.Append(sourceFolderPath);
                    sb.Append(outputFolderPath);
                    
                    // Add the open options
                    sb.Append(openOptions);

                    // Write out the Options properties
                    sb.Append(deleteBinFolder);
                    sb.Append(deleteObjFolder);
                    sb.Append(deletePackagesFolder);
                    sb.Append(zipProject);
                    sb.Append(copyProject);
                    sb.Append(addTimestamp);

                    // Write out the Do Not Copy Content Folders
                    sb.Append(openDoNotCopyContentFolder);
                        
                    // Write out the folder and any exceptions it may have
                    sb.Append(doNotCopyContentFolders);

                    // Write closing Do Not Copy Content Folders
                    sb.Append(closeDoNotCopyContentFolder);

                    // Add the close options
                    sb.Append(closeOptions);

                    // Add the close shipment
                    sb.Append(closeShipment);
                    
                    // set the return value
                    xml = sb.ToString();
                }

                // return value
                return xml;
            }
            #endregion
            
            #region GetProductFolder()
            /// <summary>
            /// This method returns the Product Folder
            /// </summary>
            public static string GetProductFolder()
            {
                // initial value
                string productFolder = "";

                // get the appData
                string appData = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                
                // set the path after the appData
                string tempFolder = @"Data Juggler\Solution Shipper";

                // set the return value
                productFolder = Path.Combine(appData, tempFolder);

                // return value
                return productFolder;
            }
            #endregion
            
            #region GetShipmentsFolder()
            /// <summary>
            /// This method returns the Shipments Folder
            /// </summary>
            public string GetShipmentsFolder()
            {
                // initial value
                string shipmentsFolder = "";

                // get the productFolder
                string productFolder = GetProductFolder();

                // If the productFolder string exists
                if (TextHelper.Exists(productFolder))
                {
                    // set the return value
                    shipmentsFolder = Path.Combine(productFolder, "Shipments");
                }
                
                // return value
                return shipmentsFolder;
            }
            #endregion
            
            #region Init()
            /// <summary>
            /// This method  This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Create a new instance of a 'ShipManager' object.
                this.ShipManager = new ShipManager();

                // Used for testing to fill in the form until Save and Load are working
                // AutoFill();
            }
            #endregion
            
            #region LoadDoNotCopyContentFolders()
            /// <summary>
            /// This method returns a list of Do Not Copy Content Folders
            /// </summary>
            public List<Folder> LoadDoNotCopyContentFolders()
            {
                // initial value
                List<Folder> doNotCopyContentFolders = new List<Folder>();

                // iterate the items in the list box
                foreach (object item in this.IgnoreFoldersListBox.Items)
                {
                    // iterate the folders
                    Folder folder = item as Folder;

                    // if the folder exists
                    if (NullHelper.Exists(folder))
                    {
                        // add this folder
                        doNotCopyContentFolders.Add(folder);
                    }
                }
                
                // return value
                return doNotCopyContentFolders;
            }
            #endregion
            
            #region SaveShipment()
            /// <summary>
            /// This method Save Shipment
            /// </summary>
            public void SaveShipment()
            {
                // Capture the current shipment
                Shipment shipment = this.CaptureShipment();
                
                // Get the Shipments Folders
                string shipmentsFolder = GetShipmentsFolder();

                // Get the fileName
                string fileName = Path.Combine(shipmentsFolder, shipment.Name + ".shp");

                // If the file exists
                if (File.Exists(fileName))
                {
                    // Delete the existing file before saving
                    File.Delete(fileName);
                }

                // Export the shipment to Xml text
                string xml = ExportShipment(shipment);

                // Ensure the folders exist
                EnsureFoldersExist(shipmentsFolder);

                // Write out the contents of the file
                File.AppendAllText(fileName, xml);

                // Show the user a message
                MessageBoxHelper.ShowMessage("The shipment has been saved", "Success");
            }
            #endregion
            
        #endregion

        #region Properties

            #region HasSelectedShipment
            /// <summary>
            /// This property returns true if this object has a 'SelectedShipment'.
            /// </summary>
            public bool HasSelectedShipment
            {
                get
                {
                    // initial value
                    bool hasSelectedShipment = (this.SelectedShipment != null);
                    
                    // return value
                    return hasSelectedShipment;
                }
            }
            #endregion
            
            #region HasShipManager
            /// <summary>
            /// This property returns true if this object has a 'ShipManager'.
            /// </summary>
            public bool HasShipManager
            {
                get
                {
                    // initial value
                    bool hasShipManager = (this.ShipManager != null);
                    
                    // return value
                    return hasShipManager;
                }
            }
            #endregion
            
            #region SelectedShipment
            /// <summary>
            /// This property gets or sets the value for 'SelectedShipment'.
            /// </summary>
            public Shipment SelectedShipment
            {
                get { return selectedShipment; }
                set { selectedShipment = value; }
            }
            #endregion
            
            #region ShipManager
            /// <summary>
            /// This property gets or sets the value for 'ShipManager'.
            /// </summary>
            public ShipManager ShipManager
            {
                get { return shipManager; }
                set { shipManager = value; }
            }
        #endregion

        #endregion
            
    }
    #endregion

}
