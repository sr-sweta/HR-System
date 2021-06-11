using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entity
{
    /// <summary>
    /// Contains all properties related to employee document
    /// </summary>
	public class EmployeeDocument
	{
        #region Private Variables

        private int id = -1;
        private string fileName = string.Empty;
        private DocumentType document;
        private string documetTypeText = string.Empty;
        private bool isActive = true;
        private bool isDirty = false;
        private string createdBy = string.Empty;
        private string createdDate = string.Empty;
        private string lastUpdatedBy = string.Empty;
        private string lastUpdatedDate = string.Empty;
        private string isActiveText = string.Empty;
        private HttpPostedFile postedFile;

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
        /// isActive is set true or false as employee document is active or not
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
        /// id of employee document is assigned to id variable
        /// </summary>
        public int Id
        {
            get { return id; }
            set { id = value; IsDirty = true; }
        }

        /// <summary>
        /// All files of employee are accessed using it so postedFile
        /// </summary>
        public HttpPostedFile PostedFile
        {
            get { return postedFile; }
            set { postedFile = value; IsDirty = true; }
        }

        /// <summary>
        /// Document type of employee document file is set here
        /// </summary>
        public DocumentType Document
        {
            get { return document; }
            set { document = value; IsDirty = true; }
        }

        /// <summary>
        /// Description of document type is assigned to documentTypeText
        /// </summary>
        public string DocumentTypeText
        {
            get { return Document.Description; }
        }

        /// <summary>
        /// Name of file is store to fileName variable
        /// </summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; IsDirty = true; }
        }

        /// <summary>
        /// Name of the user who uploaded the employee document is assigned to createdBy
        /// </summary>
        public string CreatedBy
        {
            get { return createdBy; }
        }

        /// <summary>
        /// Date of employee's document creation is addded to createdDate variable
        /// </summary>
        public string CreatedDate
        {
            get { return createdDate; }
        }

        /// <summary>
        /// Name of the user who did last update in employee document info is assigned to lastUpdatedBy
        /// </summary>
        public string LastUpdatedBy
        {
            get { return lastUpdatedBy; }
        }

        /// <summary>
        /// Date of last updation done in emplyee document is assigned to lastUpdatedDate
        /// </summary>
        public string LastUpdatedDate
        {
            get { return lastUpdatedDate; }
        }
        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public EmployeeDocument()
        {
        }

        /// <summary>
        /// Initialising values of all following parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileName"></param>
        /// <param name="document"></param>
        /// <param name="createdBy"></param>
        /// <param name="createdDate"></param>
        /// <param name="lastUpdatedBy"></param>
        /// <param name="lastUpdatedDate"></param>
        /// <param name="isActive"></param>
        public EmployeeDocument(int id, string fileName, DocumentType document, string createdBy, string createdDate, string lastUpdatedBy,
            string lastUpdatedDate, bool isActive)
        {

            this.id = id;
            this.fileName = fileName;
            this.document = document;
            this.isActive = isActive;
            this.createdBy = createdBy;
            this.createdDate = createdDate;
            this.lastUpdatedBy = lastUpdatedBy;
            this.lastUpdatedDate = lastUpdatedDate;
    }

        /// <summary>
        /// Initialising values of all following parameters
        /// </summary>
        /// <param name="id"></param>
        /// <param name="fileName"></param>
        /// <param name="document"></param>
        /// <param name="postedFile"></param>
        /// <param name="isActive"></param>
        public EmployeeDocument(int id, string fileName, DocumentType document, HttpPostedFile postedFile, bool isActive)
        {

            this.id = id;
            this.fileName = fileName;
            this.document = document;
            this.isActive = isActive;
            this.postedFile = postedFile;
        }

        #endregion
    }
}
