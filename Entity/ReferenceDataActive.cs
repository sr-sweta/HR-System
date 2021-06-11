using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// Contains common properties of EmployeeType, EmployeeCategory and DocumentType
    /// </summary>
    public  abstract class ReferenceDataActive
    {

        #region Private Variables

        private int id = -1;
        private string description = string.Empty;
        private bool isActive = true;
        private bool isDirty = false;
        private string createdBy = string.Empty;
        private string createdDate = string.Empty;
        private string lastUpdatedBy = string.Empty;
        private string lastUpdatedDate = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// isActiveText is Yes or No as isActive is set true or false
        /// </summary>
        public string IsActiveText
        {
            get { return isActive == true ? "YES" : "NO"; }
        }

        /// <summary>
        /// isDirty is set true or false as any data is changed
        /// </summary>
        public bool IsDirty
        {
            get { return isDirty; }
            set { isDirty = value; }
        }

        /// <summary>
        /// id of entity is assigned to id variable
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; IsDirty = true; }
        }

        /// <summary>
        /// Description of entity is assigned to description variable
        /// </summary>
        public string Description
        {
            get { return description; }
            set { description = value; IsDirty = true; }
        }

        /// <summary>
        /// isActive is set true or false as entity is active or not
        /// </summary>
        public bool IsActive
        {
            get { return isActive; }
            set { isActive = value; IsDirty = true; }
        }

        /// <summary>
        /// Name of the user who created the entity data is assigned to createdBy
        /// </summary>
        public string CreatedBy
        {
            get { return createdBy; }
        }

        /// <summary>
        /// Date of entity's data creation is addded to createdDate variable
        /// </summary>
        public string CreatedDate
        {
            get { return createdDate; }
        }

        /// <summary>
        /// Name of the user who did last update in entity info is assigned to lastUpdatedBy
        /// </summary>
        public string LastUpdatedBy
        {
            get { return lastUpdatedBy; }
        }

        /// <summary>
        /// Date of last updation done in entity data is assigned to lastUpdatedDate
        /// </summary>
        public string LastUpdatedDate
        {
            get { return lastUpdatedDate; }
        }


        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor of entity
        /// </summary>
        public ReferenceDataActive()
        {
        }

        /// <summary>
        /// Values are assigned to following parameters of the entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        /// <param name="isActive"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="lastUpdatedDate"></param>
        public ReferenceDataActive(int id, string description, bool isActive, string createdBy, string createdDate,
                            string lastUpdatedBy, string lastUpdatedDate)
        {
            this.id = id;
            this.description = description;
            this.isActive = isActive;
            this.createdBy = createdBy;
            this.createdDate = createdDate;
            this.lastUpdatedBy = lastUpdatedBy;
            this.lastUpdatedDate = lastUpdatedDate;

        }

        /// <summary>
        /// Values are assigned to following parameters of the entity
        /// </summary>
        /// <param name="id"></param>
        /// <param name="description"></param>
        public ReferenceDataActive(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        #endregion

    }
}
