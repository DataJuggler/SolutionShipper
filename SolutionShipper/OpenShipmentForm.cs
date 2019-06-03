

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
using SolutionShipper.Objects;
using DataJuggler.Core.UltimateHelper;
using System.IO;

#endregion

namespace SolutionShipper
{

    #region class OpenShipmentForm
    /// <summary>
    /// This class is used to open Shipments
    /// </summary>
    public partial class OpenShipmentForm : Form
    {
        
        #region Private Variables
        private string shipmentsFolder;
        private string selectedShipmentPath;
        private bool userCancelled;
        #endregion

        #region Constructor(string shipmentsFolder)
        /// <summary>
        /// Create a new instance of a 'OpenShipmentForm' object.
        /// </summary>
        public OpenShipmentForm(string shipmentsFolder)
        {
            // Create Controls
            InitializeComponent();

            // store the argument
            this.ShipmentsFolder = shipmentsFolder;

            // Perform initializations for this object
            Init();
        }
        #endregion
        
        #region Events
            
            #region ShipmentsListBox_DoubleClick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Shipments List Box _ Double Click
            /// </summary>
            private void ShipmentsListBox_DoubleClick(object sender, EventArgs e)
            {
                // If the ShipmentsFolder object exists
                if ((this.HasShipmentsFolder) && (this.ShipmentsListBox.SelectedItem != null))
                {
                    // get the selected item from the list box
                    string shipmentName = this.ShipmentsListBox.SelectedItem as string;
                    
                    // if the shipmentName string exists
                    if (NullHelper.Exists(shipmentName))
                    {
                        // Get the path
                        this.SelectedShipmentPath = Path.Combine(this.ShipmentsFolder, shipmentName + ".shp");

                        // the user did not cancel
                        this.UserCancelled = false;

                        // unload this form
                        this.Close();
                    }
                }
            }
            #endregion
            
            #region ShipmentsListBox_KeyDown(object sender, KeyEventArgs e)
            /// <summary>
            /// event is fired when Shipments List Box _ Key Down
            /// </summary>
            private void ShipmentsListBox_KeyDown(object sender, KeyEventArgs e)
            {
                // if the delete key was pressed and there is a selected item
                if ((e.KeyCode == Keys.Delete) && (this.ShipmentsListBox.SelectedItem != null))
                {
                    // cast the selected item as a Shipment
                    string shipmentName = this.ShipmentsListBox.SelectedItem as string;

                    // If the shipmentName object exists
                    if (NullHelper.Exists(shipmentName))
                    {
                        // Get the users confirmation before deleting
                        DialogResult result = MessageBox.Show("Are you sure you wish to delete the shipment '" + shipmentName + "'?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        // if Yes was chosen
                        if (result == DialogResult.Yes)
                        {
                            // get the fileName
                            string fileName = Path.Combine(this.ShipmentsFolder, shipmentName + ".shp");

                            // if the file exists
                            if (File.Exists(fileName))
                            {
                                // Delete this shipment
                                File.Delete(fileName);

                                // Reload the Shipments box
                                LoadShipments();
                            }
                        }
                    }
                }
            }
        #endregion

        #endregion

        #region Methods

            #region Init()
            /// <summary>
            /// This method performs initializations for this object.
            /// </summary>
            public void Init()
            {
                // Default to true
                this.UserCancelled = true;

                // Load the shipments
                LoadShipments();
            }
            #endregion
            
            #region LoadShipments()
            /// <summary>
            /// This method Load Shipments
            /// </summary>
            public void LoadShipments()
            {
                // Clear the list
                this.ShipmentsListBox.Items.Clear();

                // If the ShipmentsFolder object exists
                if (this.HasShipmentsFolder)
                {
                    // Get the files
                    string[] files = Directory.GetFiles(this.ShipmentsFolder);

                    // convert the string array to a List<string>
                    List<string> shipmentNames = files.ToList();

                    // If the shipmentNames collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(shipmentNames))
                    {
                        // Iterate the collection of string objects
                        foreach (string shipmentName in shipmentNames)
                        {
                            // create a fileInfo
                            FileInfo fileInfo = new FileInfo(shipmentName);

                            // remove the extension
                            string name = fileInfo.Name.Replace(".shp", "");

                            // Add this shipment
                            this.ShipmentsListBox.Items.Add(name);
                        }
                    }
                }
            }
            #endregion
            
        #endregion

        #region Properties

            #region HasSelectedShipmentPath
            /// <summary>
            /// This property returns true if the 'SelectedShipmentPath' exists.
            /// </summary>
            public bool HasSelectedShipmentPath
            {
                get
                {
                    // initial value
                    bool hasSelectedShipmentPath = (!String.IsNullOrEmpty(this.SelectedShipmentPath));
                    
                    // return value
                    return hasSelectedShipmentPath;
                }
            }
            #endregion
            
            #region HasShipmentsFolder
            /// <summary>
            /// This property returns true if the 'ShipmentsFolder' exists.
            /// </summary>
            public bool HasShipmentsFolder
            {
                get
                {
                    // initial value
                    bool hasShipmentsFolder = (!String.IsNullOrEmpty(this.ShipmentsFolder));
                    
                    // return value
                    return hasShipmentsFolder;
                }
            }
            #endregion
            
            #region SelectedShipmentPath
            /// <summary>
            /// This property gets or sets the value for 'SelectedShipmentPath'.
            /// </summary>
            public string SelectedShipmentPath
            {
                get { return selectedShipmentPath; }
                set { selectedShipmentPath = value; }
            }
            #endregion
            
            #region ShipmentsFolder
            /// <summary>
            /// This property gets or sets the value for 'ShipmentsFolder'.
            /// </summary>
            public string ShipmentsFolder
            {
                get { return shipmentsFolder; }
                set { shipmentsFolder = value; }
            }
            #endregion
            
            #region UserCancelled
            /// <summary>
            /// This property gets or sets the value for 'UserCancelled'.
            /// </summary>
            public bool UserCancelled
            {
                get { return userCancelled; }
                set { userCancelled = value; }
            }
        #endregion

        #endregion
            
    }
    #endregion

}
