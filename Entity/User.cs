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

        public bool IsDirty
        {
            get { return isDirty; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; isDirty = true; }
        }

        public string Username
        {
            get { return userName; }
            set { userName = value; isDirty = true; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; isDirty = true; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; isDirty = true; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; isDirty = true; }
        }

        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; isDirty = true; }
        }

        //public string Email
        //{
        //    get { return email; }
        //    set { email = value; isDirty = true; }
        //}

        //public string Address
        //{
        //    get { return address; }
        //    set { address = value; isDirty = true; }
        //}

        //public string PhoneNumber
        //{
        //    get { return phoneNumber; }
        //    set { phoneNumber = value; isDirty = true; }
        //}

        #endregion

        #region Constructors

        public User()
        {
        }

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
