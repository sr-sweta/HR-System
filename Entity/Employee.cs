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
        private string middleName = string.Empty;
        private string lastName = string.Empty;
        private EmployeeCategory category;
        private EmployeeType employeeType;
        private DateTime dateOfBirth;
        private DateTime dateOfJoining;
        private bool isDirty = false;
        private bool isActive = true;
        private string createdBy = string.Empty;
        private string createdDate = string.Empty;
        private string lastUpdatedBy = string.Empty;
        private string lastUpdatedDate = string.Empty;
        private string isActiveText = string.Empty;

        #endregion

        #region Properties

        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; IsDirty = true; }
        }

        public string IsActiveText
        {
            get { return isActive == true ? "YES" : "NO"; }
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

        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; IsDirty = true; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; IsDirty = true; }
        }

        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; IsDirty = true; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; IsDirty = true; }
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

        public string CreatedBy
        {
            get { return createdBy; }
        }

        public string CreatedDate
        {
            get { return createdDate; }
        }

        public string LastUpdatedBy
        {
            get { return lastUpdatedBy; }
        }

        public string LastUpdatedDate
        {
            get { return lastUpdatedDate; }
        }


        #endregion

        #region Constructors

        public Employee()
        {
        }
        public Employee( int id, string firstName,string middleName, string lastName, EmployeeCategory category, EmployeeType employeeType, DateTime dateOfJoining, DateTime dateOfBirth, 
        string createdBy, string createdDate, string lastUpdatedBy, string lastUpdatedDate, bool isActive)
        {
            this.id = id;
            this.firstName = firstName;
            this.middleName = middleName;
            this.lastName = lastName;
            this.category = category;
            this.employeeType = employeeType;
            this.dateOfBirth = dateOfBirth;
            this.dateOfJoining = dateOfJoining;
            this.isActive = isActive;
            this.createdBy = createdBy;
            this.createdDate = createdDate;
            this.lastUpdatedBy = lastUpdatedBy;
            this.lastUpdatedDate = lastUpdatedDate;
    }
        #endregion

    }
}
