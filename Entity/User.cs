using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// Contains all properties related to User
    /// </summary>
    public class User
    {
        #region PrivateVariables
        private int id = -1;
        private string userName = string.Empty;
        private string firstName = string.Empty;
        private string lastName = string.Empty;
        private string password = string.Empty;
        //private string phoneNumber = string.Empty;
        //private string email = string.Empty;
        //private string address = string.Empty;
        private bool isActive = true;
        private bool isDirty = false;
        #endregion

        #region Properties

        /// <summary>
        /// isDirty is true or false indicating user data is changed or not
        /// </summary>
        public bool IsDirty
        {
            get { return isDirty; }
        }

        /// <summary>
        /// id of user is stored in id variable
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; isDirty = true; }
        }

        /// <summary>
        /// username of user is assigned to username variable
        /// </summary>
        public string Username
        {
            get { return userName; }
            set { userName = value; isDirty = true; }
        }

        /// <summary>
        /// First name of user is assigned to firstName variable
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; isDirty = true; }
        }

        /// <summary>
        /// Last name of user is assigned to lastName variable
        /// </summary>
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; isDirty = true; }
        }

        /// <summary>
        /// Password of user is stored in password variable
        /// </summary>
        public string Password
        {
            get { return password; }
            set { password = value; isDirty = true; }
        }

        /// <summary>
        /// isActive value is set true or false indicating wheather user is active or not in institute
        /// </summary>
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; isDirty = true; }
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public User()
        {
        }

        /// <summary>
        /// Constructor assigning values to following parameters of the user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="userName"></param>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="password"></param>
        /// <param name="isActive"></param>
        public User(int id, string userName, string firstName, string lastName, string password, bool isActive)
        {
            this.id = id;
            this.userName = userName;
            this.firstName = firstName;
            this.lastName = lastName;
            this.password = password;
            this.isActive = isActive;

        }
        #endregion
    }
}
