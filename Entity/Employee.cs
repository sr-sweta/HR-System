using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// Contains all properties related to Employee
    /// </summary>
    public class Employee
    {
        #region Private Variables

        private int id = -1;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private EmployeeCategory category;
        private EmployeeType employeeType;
        private bool isDirty = false;
        private string createdBy = string.Empty;
        private string createdDate = string.Empty;
        private string lastUpdatedBy = string.Empty;
        private string lastUpdatedDate = string.Empty;

        #endregion

        #region Properties

        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; IsDirty = true; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; IsDirty = true; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; IsDirty = true; }
        }

        public EmployeeCategory Category
        {
            get { return category; }
            set { category = value; IsDirty = true; }
        }

        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; IsDirty = true; }
        }

        #endregion

    }
}
