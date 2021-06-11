using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using DataAccess;

namespace BusinessLogic
{
    /// <summary>
    /// Handles all logics to show data in Representation Layer 
    /// </summary>
   
    public class MasterLogic
    {
        /// <summary>
        /// Logics to show Employee Type
        /// </summary>
        /// <param name="employeeType"></param>
        /// <param name="user"></param>

        #region EmployeeType

        ///<summary>
        /// Save new created Employee Type
        /// </summary>
        public static void SaveEmployeeType(EmployeeType employeeType, User user)
        {
            if (employeeType.Id < 0 && employeeType.IsActive)
            {
                MasterData.InsertEmployeeType(employeeType, user);
            }
            else if (employeeType.IsDirty && employeeType.Id > 0)
            {
                MasterData.UpdateEmployeeType(employeeType, user);
            }
        }

        /// <summary>
        /// Receives list of all Employee Type from Data Access Layer
        /// </summary>
        public static ArrayList GetAllEmployeeType()
        {
            return MasterData.GetAllEmployeeType();
        }

        /// <summary>
        ///  Receives list of all Active Employee Type from Data Access Layer
        /// </summary>
        public static ArrayList GetAllActiveEmployeeType()
        {
            return MasterData.GetAllActiveEmployeeType();
        }

        #endregion


        /// <summary>
        /// Logics to show Employee Category
        /// </summary>
        /// <param name="employeeCategory"></param>
        /// <param name="user"></param>

        #region EmployeeCategory

        ///<summary>
        /// Save new created Employee Category
        /// </summary>
        public static void SaveEmployeeCategory(EmployeeCategory employeeCategory, User user)
        {
            if (employeeCategory.Id < 0 && employeeCategory.IsActive)
            {
                MasterData.InsertEmployeeCategory(employeeCategory, user);
            }
            else if (employeeCategory.IsDirty && employeeCategory.Id > 0)
            {
                MasterData.UpdateEmployeeCategory(employeeCategory, user);
            }
        }

        /// <summary>
        /// Receives list of all Employee Category from Data Access Layer
        /// </summary>
        public static ArrayList GetAllEmployeeCategory()
        {
            return MasterData.GetAllEmployeeCategory();
        }

        /// <summary>
        /// Receives list of all Active Employee Category from Data Access Layer
        /// </summary>
        public static ArrayList GetAllActiveEmployeeCategory()
        {
            return MasterData.GetAllActiveEmployeeCategory();
        }

        #endregion


        /// <summary>
        /// Logics to show Document Type
        /// </summary>
        /// <param name="documentType"></param>
        /// <param name="user"></param>

        #region DocumentType

        ///<summary>
        /// Save new created Document Type
        /// </summary>
        public static void SaveDocumentType(DocumentType documentType, User user)
        {
            if (documentType.Id < 0 && documentType.IsActive)
            {
                MasterData.InsertDocumentType(documentType, user);
            }
            else if (documentType.IsDirty && documentType.Id > 0)
            {
                MasterData.UpdateDocumentType(documentType, user);
            }
        }

        /// <summary>
        /// Receives list of all Document Type from Data Access Layer
        /// </summary>
        public static ArrayList GetAllDocumentType()
        {
            return MasterData.GetAllDocumentType();
        }

        /// <summary>
        /// Receives list of all Active Document Type from Data Access Layer
        /// </summary>
        public static ArrayList GetAllActiveDocumentType()
        {
            return MasterData.GetAllActiveDocumentType();
        }

        #endregion


    }
}
