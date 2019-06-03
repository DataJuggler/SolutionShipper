

#region using statements

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace SolutionShipper.Enumerations
{


    #region enum IgnoreFolderExceptionTypeEnum : int
    /// <summary>
    /// This enumeration is for the type of exception to make in handling folder content.
    /// </summary>
    public enum IgnoreFolderExceptionTypeEnum : int
    {
        Do_Not_Add_Matching_Names = - 3,
        Do_Not_Add_Matching_Extensions = -2,
        Do_Not_Add_Any_Content = -1,    
        Do_Not_Copy_The_Folder = 0,
        Add_Matching_Extensions = 1,
        Add_Matching_Names = 2
    }
    #endregion

}
