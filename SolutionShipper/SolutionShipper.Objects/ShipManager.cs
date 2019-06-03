

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataJuggler.Core.UltimateHelper;
using System.IO;
using System.Windows.Forms;
using SolutionShipper.Enumerations;
using DataJuggler.Core.UltimateHelper.Objects;

#endregion

namespace SolutionShipper.Objects
{

    #region class ShipManager
    /// <summary>
    /// This class performs the actual shipping
    /// </summary>
    public class ShipManager
    {

        #region Methods
        
            #region GetExtensions(string text)
            /// <summary>
            /// This method returns the Extensions
            /// </summary>
            public static List<string> GetExtensions(string text)
            {
                // initial value
                List<string> extensions = new List<string>();
                
                // If the text string exists
                if (TextHelper.Exists(text))
                {
                    // only use commas or semicolons
                    char[] delimiterChars = { ',', ';' };

                    // Parse the words
                    List<Word> words = WordParser.GetWords(text, delimiterChars);

                    // if there are one or more words
                    if (ListHelper.HasOneOrMoreItems(words))
                    {   
                        // Iterate the collection of Word objects
                        foreach (Word word in words)
                        {
                            // Add this extension
                            extensions.Add(word.Text);
                        }
                    }
                }

                // return value
                return extensions;
            }
            #endregion
            
            #region GetFolderStatus(string folderPath, FolderStatus folderStatus)
            /// <summary>
            /// This method returns the Files Count
            /// </summary>
            public static FolderStatus GetFolderStatus(string folderPath, FolderStatus folderStatus)
            {
                // if the folderPath string exists and the folderStatus object exists
                if ((TextHelper.Exists(folderPath)) && (NullHelper.Exists(folderStatus)))
                {
                    // get the files
                    string[] filesArray = Directory.GetFiles(folderPath);
                    List<string> files = filesArray.ToList();

                    // If the files collection exists and has one or more items
                    if (ListHelper.HasOneOrMoreItems(files))
                    {
                        // Add the current files count
                        folderStatus.FilesCount += files.Count;

                        // Iterate the collection of string objects
                        foreach (string file in files)
                        {
                            // Create a new instance of a 'FileInfo' object.
                            FileInfo fileInfo = new FileInfo(file);

                            // Add to the size
                            folderStatus.Size += fileInfo.Length;
                        }
                    }

                    // Now get any subdirectories
                    string[] directories = Directory.GetDirectories(folderPath);
                    List<string> folderList = directories.ToList();

                    // if there are any subFolders
                    if (ListHelper.HasOneOrMoreItems(folderList))
                    {
                        // Add to the FolderCount
                        folderStatus.FolderCount += folderList.Count;

                        // iterate the subFolders
                        foreach (string subFolder in folderList)
                        {
                            // Get the files in the subFolders (recursively)
                            folderStatus = GetFolderStatus(subFolder, folderStatus);
                        }
                    }
                }
                
                // return value
                return folderStatus;
            }
            #endregion
            
            #region GetTimeStamp()
            /// <summary>
            /// This method returns the Time Stamp
            /// </summary>
            public static string GetTimeStamp()
            {
                // initial value
                string timeStamp = "";

                // locals
                string year = "";
                string month = "";
                string day = "";
                string hour = "";
                string minute = "";
                string second = "";

                // Create a new instance of a 'StringBuilder' object.
                StringBuilder sb = new StringBuilder();

                // get a reference to now
                DateTime now = DateTime.Now;

                // Set the value for year, month, day, hour, min, second
                year = now.Year.ToString();
                month = now.Month.ToString();
                day = now.Day.ToString();
                hour = now.Hour.ToString();
                minute = now.Minute.ToString();
                second = now.Second.ToString();

                // Ensure values are two digits
                if (month.Length < 2)
                {
                    // make a two digit month
                    month = "0" + month;
                }

                // Ensure values are two digits
                if (day.Length < 2)
                {
                    // make a two digit day
                    day = "0" + day;
                }

                // Ensure values are two digits
                if (hour.Length < 2)
                {
                    // make a two digit hour
                    hour = "0" + hour;
                }

                // Ensure values are two digits
                if (minute.Length < 2)
                {
                    // make a two digit minute
                    minute = "0" + minute;
                }

                // Ensure values are two digits
                if (second.Length < 2)
                {
                    // make a two digit second
                    second = "0" + second;
                }

                // Append the year, month, day, hour, min, second
                sb.Append(year);
                sb.Append(month);
                sb.Append(day);
                sb.Append(hour);
                sb.Append(minute);
                sb.Append(second);

                // set the return value
                timeStamp = sb.ToString();

                // return value
                return timeStamp;
            }
            #endregion
            
            #region RecursiveCopy(string sourceFolder, string outputFolder, Shipment shipment, ProgressBar graph)
            /// <summary>
            /// This method Recursive Copy
            /// </summary>
            public static void RecursiveCopy(string sourceFolder, string outputFolder, Shipment shipment, ProgressBar graph)
            {
                // locals
                bool skipFile = false;
                bool skipContent = false;
                bool skipFolder = false;
                Folder doNotCopyContentFolder = null;
                List<string> allowedExtensions = new List<string>();
                List<string> allowedNames = new List<string>();
                List<string> bannedExtensions = new List<string>();
                List<string> bannedNames = new List<string>();
                
                // for now copy everything, the ignore folders and exceptions will come later
                if ((TextHelper.Exists(sourceFolder, outputFolder)) && (NullHelper.Exists(shipment)))
                {
                    // Handle exceptions here

                    // Get the directory name
                    DirectoryInfo directoryInfo = new DirectoryInfo(sourceFolder);
                    
                    // If the bin folder should be skipped
                    if (shipment.Options.DeleteBinFolder)
                    {
                        // if the sourceFolder is bin
                        if (TextHelper.IsEqual(directoryInfo.Name, "bin"))
                        {
                            // Set to true, this aborts copying this folder
                            skipFolder = true;
                        }
                    }

                    // If Obj folder should be skipped
                    if (shipment.Options.DeleteObjFolder)
                    {
                        // if the sourceFolder is obj
                        if (TextHelper.IsEqual(directoryInfo.Name, "obj"))
                        {
                            // Set to true, this aborts copying this folder
                            skipFolder = true;
                        }
                    }
                    
                    // If packages folder should be skipped
                    if (shipment.Options.DeletePackagesFolder)
                    {
                        // if this is a packages folder
                        if (TextHelper.IsEqual(directoryInfo.Name, "packages"))
                        {
                            // Set to true, this aborts copying this folder
                            skipFolder = true;
                        }
                    }

                    // if the DoNotCopyContentFolders collection exists
                    if (shipment.Options.HasDoNotCopyContentFolders)
                    {
                        // iterate the folders
                        foreach (Folder folder in shipment.Options.DoNotCopyContentFolders)
                        {
                            // if this string is in the do not copy content folders
                            if (TextHelper.IsEqual(sourceFolder, folder.Path))
                            {
                                // set the doNotCopyContentFolder
                                doNotCopyContentFolder = folder;

                                // if there are ignoreExceptions
                                if (folder.HasIgnoreExceptions)
                                {
                                    // iterate the exceptions
                                    foreach (IgnoreFolderException exception in folder.IgnoreExceptions)
                                    {
                                        // if Do Not Copy The Folder is selected
                                        if (exception.IgnoreExceptionType == IgnoreFolderExceptionTypeEnum.Do_Not_Copy_The_Folder)
                                        {
                                            // Problaby won't be set this way, but it could
                                            skipFolder = true;
                                        }
                                        else if (exception.IgnoreExceptionType == IgnoreFolderExceptionTypeEnum.Do_Not_Add_Any_Content)
                                        {
                                            // Set skipContent to true so SubFolders and Files are not copied
                                            skipContent = true;
                                        }
                                    }
                                }
                                else
                                {
                                    // We must skip this folder since there is not an exception
                                    skipFolder = true;
                                }

                                // break out of loop
                                break;
                            }
                        }
                    }

                    // if the folder should not be skipped
                    if (!skipFolder)
                    {
                        // First copy the sourceFolder (by creating the outputFolder)
                        Directory.CreateDirectory(outputFolder);

                        // if the content should not be skipped
                        if (!skipContent)
                        {
                            // Now copy the files for this folder
                            string[] filesList =Directory.GetFiles(sourceFolder);
                            List<string> files = filesList.ToList();
                    
                            // if there are one or more files
                            if (ListHelper.HasOneOrMoreItems(files))
                            {
                                // iterate the files
                                foreach (string file in files)
                                {
                                    // reset the value
                                    skipFile = false;

                                    // Create a fileInfo
                                    FileInfo fileInfo = new FileInfo(file);
                                    
                                    // set the extension and name
                                    string extension = fileInfo.Extension;
                                    string name = fileInfo.Name;
                                    
                                    // If the doNotCopyContentFolder object exists
                                    if (NullHelper.Exists(doNotCopyContentFolder))
                                    {
                                        // if there are exceptions to handle
                                        if (doNotCopyContentFolder.HasIgnoreExceptions)
                                        {
                                            // iterate the exceptions
                                            foreach (IgnoreFolderException exception in doNotCopyContentFolder.IgnoreExceptions)
                                            {
                                                // if AddMatchingExtensions is the type
                                                if (exception.IgnoreExceptionType == IgnoreFolderExceptionTypeEnum.Add_Matching_Extensions)
                                                {
                                                    // get the allowedExtensions
                                                    allowedExtensions = GetExtensions(exception.Text);

                                                    // find the index of this extension in the allowed extensions
                                                    int index = allowedExtensions.IndexOf(extension);

                                                    // if the index was NOT found
                                                    if (index < 0)
                                                    {
                                                        // set skipFile to true
                                                        skipFile = true;

                                                        // break out of the exceptions parsing
                                                        break;
                                                    }
                                                }
                                                else if (exception.IgnoreExceptionType == IgnoreFolderExceptionTypeEnum.Add_Matching_Names)
                                                {
                                                    // if the names are not equal
                                                    if (!TextHelper.IsEqual(name, exception.Text))
                                                    {
                                                        // set skipFile to true
                                                        skipFile = true;

                                                        // break out of the exceptions parsing
                                                        break;
                                                    }
                                                }
                                                else if (exception.IgnoreExceptionType == IgnoreFolderExceptionTypeEnum.Do_Not_Add_Matching_Extensions)
                                                {
                                                    // get the bannedExtensions
                                                    bannedExtensions = GetExtensions(exception.Text);

                                                    // find the index of this extension in the bannedExtensions
                                                    int index = bannedExtensions.IndexOf(extension);

                                                    // if the index was found
                                                    if (index >= 0)
                                                    {
                                                        // skip this file
                                                        skipFile = true;

                                                        // break out of the exceptions parsing
                                                        break;
                                                    }
                                                }
                                                else if (exception.IgnoreExceptionType == IgnoreFolderExceptionTypeEnum.Do_Not_Add_Matching_Names)
                                                {
                                                     // if the names are equal
                                                    if (TextHelper.IsEqual(name, exception.Text))
                                                    {
                                                        // set skipFile to true
                                                        skipFile = true;

                                                        // break out of the exceptions parsing
                                                        break;
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    // if the file should not be skipped
                                    if (!skipFile)
                                    {
                                        // Now create the outputFileName
                                        string outputFileName = Path.Combine(outputFolder, fileInfo.Name);
                            
                                        // Copy this file
                                        File.Copy(file, outputFileName);
                                    }

                                    // Increment the graph
                                    graph.Value++;
                                }
                            }

                            // now find the sub directories of the sourceFolder
                            string[] directories = Directory.GetDirectories(sourceFolder);

                            // get a list of subFolders
                            List<string> subFolders = directories.ToList();

                            // If the subFolders collection exists and has one or more items
                            if (ListHelper.HasOneOrMoreItems(subFolders))
                            {
                                // Iterate the collection of string objects
                                foreach (string subFolder in subFolders)
                                {
                                    // create the fullpath for this subFolder
                                    DirectoryInfo directoryInfo2 = new DirectoryInfo(subFolder);

                                    // Create the Output folder
                                    string outputSubFolderPath = Path.Combine(outputFolder, directoryInfo2.Name);

                                    // Call this method recursively until there are no more children
                                    RecursiveCopy(subFolder, outputSubFolderPath, shipment, graph);
                                }
                            }
                        }
                    }
                }
            }
            #endregion
            
            #region Ship(Shipment shipment, ProgressBar graph)
            /// <summary>
            /// This method Ships the solution and strips out all the garbage you do not want.
            /// </summary>
            public static SolutionStatus Ship(Shipment shipment, ProgressBar graph)
            {
                // initial value
                SolutionStatus status = new SolutionStatus();

                 // Finally: Let the shipping begin!
                if (NullHelper.Exists(shipment))
                {
                    // verify both folders exist
                    if ((Directory.Exists(shipment.SourceFolderPath)) && (Directory.Exists(shipment.OutputFolderPath)))
                    {  
                        // Create a folderStatus object
                        FolderStatus sourceFolderStatus = new FolderStatus();

                        // SetupProgressBar
                        sourceFolderStatus = GetFolderStatus(shipment.SourceFolderPath, sourceFolderStatus);

                        // Set the SourceFolderStatus
                        status.SourceFolderStatus = sourceFolderStatus;

                        // If the graph object exists
                        if (NullHelper.Exists(graph))
                        {
                            // Set the maximum, reset to 0 and show the graph
                            graph.Maximum = sourceFolderStatus.FilesCount;
                            graph.Value = 0;
                            graph.Visible = true;
                        }

                        // Create the folders
                        shipment.SourceFolder = new Folder();
                        shipment.OutputFolder = new Folder();

                        // Set the Path
                        shipment.SourceFolder.Path = shipment.SourceFolderPath;
                        shipment.OutputFolder.Path = shipment.OutputFolderPath;

                        // if a TimeStamp should be added before we start
                        if (shipment.Options.AddTimestamp)
                        {
                            // Get the current timestamp
                            string timeStamp = GetTimeStamp();
                            
                            // Create the outputPath
                            string outputPath = Path.Combine(shipment.OutputFolderPath, timeStamp);

                            // Update the outputFolder (do not change the Shipment, that stays the same)
                            shipment.OutputFolder.Path = outputPath;

                            // Create the Directory
                            Directory.CreateDirectory(outputPath);
                        }

                        // Create a DirectoryInfo
                        DirectoryInfo directoryInfo = new DirectoryInfo(shipment.SourceFolderPath);

                        // Now create the folder for the Solution
                        string destinationFolder = Path.Combine(shipment.OutputFolder.Path, directoryInfo.Name);

                        // Create the toplevel folder
                        Directory.CreateDirectory(destinationFolder);

                        // Begin Recursive Copy
                        RecursiveCopy(shipment.SourceFolder.Path, destinationFolder, shipment, graph);

                        // Create a folderStatus object
                        FolderStatus outputFolderStatus = new FolderStatus();

                        // SetupProgressBar
                        outputFolderStatus = GetFolderStatus(shipment.OutputFolder.Path, outputFolderStatus);

                        // Set the OutputFolderStatus
                        status.OutputFolderStatus = outputFolderStatus;

                        // To Do: Display Stats

                        // Show user a message import has finished
                        MessageBoxHelper.ShowMessage("The solution has been shipped.", "Solution Shipped");
                    }
                    else if (!Directory.Exists(shipment.SourceFolderPath))
                    {
                        // Show the user a message
                        MessageBoxHelper.ShowMessage("The 'Source Folder' path does not exist.", "Folder Not Found");
                    }
                    else if (!Directory.Exists(shipment.OutputFolderPath))
                    {
                        // Show the user a message
                        MessageBoxHelper.ShowMessage("The 'Output Folder' path does not exist.", "Folder Not Found");
                    }
                }

                // return value
                return status;
            }
            #endregion
            
        #endregion

        #region Properties
            
        #endregion

    }
    #endregion

}
