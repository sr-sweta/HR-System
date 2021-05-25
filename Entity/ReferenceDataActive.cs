using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class ReferenceDataActive
    {
		private int id = -1;
		private string description = string.Empty;
		private bool isActive = true;
		private bool isDirty = false;
		private string createdBy = string.Empty;
		private string createdDate = string.Empty;
		private string lastUpdatedBy = string.Empty;
		private string lastUpdatedDate = string.Empty;

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

		public string Description
		{
			get { return description; }
			set { description = value; IsDirty = true; }
		}

		public bool IsActive
		{
			get { return isActive; }
			set { isActive = value; IsDirty = true; }
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

		public ReferenceDataActive()
		{
		}

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
	}
}
