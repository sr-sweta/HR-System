using System;
using System.Collections;
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
        private ArrayList employeeDocument;
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

        /// <summary>
        /// isDirty initialised whether data is changed or not is accordingly set true or false
        /// </summary>
        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        /// <summary>
        /// isActive is set true or false as employee is active or not
        /// </summary>
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; IsDirty = true; }
        }

        /// <summary>
        /// isActiveText is Yes or No as isActive is set true or false
        /// </summary>
        public string IsActiveText
        {
            get { return isActive == true ? "YES" : "NO"; }
        }

        /// <summary>
        /// id of employee is assigned to id variable
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; IsDirty = true; }
        }

        /// <summary>
        /// All documents of a particular employee it gives
        /// </summary>
        public ArrayList EmployeeDocument
        {
            get { return employeeDocument; }
            set { employeeDocument = value; IsDirty = true; }
        }

        /// <summary>
        /// firstName of employee is assigned value 
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; IsDirty = true; }
        }

        /// <summary>
        /// middleName of employee is assigned value
        /// </summary>
        public string MiddleName
        {
            get { return middleName; }
            set { middleName = value; IsDirty = true; }
        }

        /// <summary>
        /// lastName of employee is assigned value
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; IsDirty = true; }
        }

        /// <summary>
        /// DOB of employee is assigned value
        /// </summary>
        public DateTime DateOfBirth
        {
            get { return dateOfBirth; }
            set { dateOfBirth = value; IsDirty = true; }
        }

        /// <summary>
        /// Employee's date of joining the college is added
        /// </summary>
        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; IsDirty = true; }
        }

        /// <summary>
        /// Employee category of employee is assigned value
        /// </summary>
        public EmployeeCategory Category
        {
            get { return category; }
            set { category = value; IsDirty = true; }
        }

        /// <summary>
        /// Employee type of employee is assigned value
        /// </summary>
        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; IsDirty = true; }
        }

        /// <summary>
        /// Name of the user who created the employee data is assigned to createdBy
        /// </summary>
        public string CreatedBy
        {
            get { return createdBy; }
        }

        /// <summary>
        /// Date of employee's data creation is addded to createdDate variable
        /// </summary>
        public string CreatedDate
        {
            get { return createdDate; }
        }

        /// <summary>
        /// Name of the user who did last update in employee info is assigned to lastUpdatedBy
        /// </summary>
        public string LastUpdatedBy
        {
            get { return lastUpdatedBy; }
        }

        /// <summary>
        /// Date of last updation done in emplyee data is assigned to lastUpdatedDate
        /// </summary>
        public string LastUpdatedDate
        {
            get { return lastUpdatedDate; }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor and initialise employeeDocument arraylist
        /// </summary>
        public Employee()
        {
            employeeDocument = new ArrayList();
        }

        /// <summary>
        /// initialising following parameters of Employee class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="category"></param>
        /// <param name="employeeType"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="lastUpdatedDate"></param>
        /// <param name="isActive"></param>
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
            employeeDocument = new ArrayList();
        }

        /// <summary>
        /// initialising following parameters of Employee class
        /// </summary>
        /// <param name="id"></param>
        /// <param name="firstName"></param>
        /// <param name="middleName"></param>
        /// <param name="lastName"></param>
        /// <param name="employeeDocument"></param>
        /// <param name="category"></param>
        /// <param name="employeeType"></param>
        /// <param name="dateOfJoining"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="lastUpdatedDate"></param>
        /// <param name="isActive"></param>
        public Employee(int id, string firstName, string middleName, string lastName,ArrayList employeeDocument, EmployeeCategory category, EmployeeType employeeType, DateTime dateOfJoining, DateTime dateOfBirth,
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
            this.employeeDocument = employeeDocument;
        }
        #endregion

    }
}
