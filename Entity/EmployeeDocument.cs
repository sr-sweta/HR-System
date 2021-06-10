using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Entity
{
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
        private HttpPostedFile postedFile;

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

        public int Id
        {
            get { return id; }
            set { id = value; IsDirty = true; }
        }

        public HttpPostedFile PostedFile
        {
            get { return postedFile; }
            set { postedFile = value; IsDirty = true; }
        }

        public DocumentType Document
        {
            get { return document; }
            set { document = value; IsDirty = true; }
        }

        public string DocumentTypeText
        {
            get { return Document.Description; }
        }

        public string FileName
        {
            get { return fileName; }
            set { fileName = value; IsDirty = true; }
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

        public EmployeeDocument()
        {
        }
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
