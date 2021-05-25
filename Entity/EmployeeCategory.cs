using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class EmployeeCategory : ReferenceDataActive
	{

		public EmployeeCategory() : base()
		{
		}

		public EmployeeCategory(int id, string description, bool isActive, bool isDirty, string createdBy, string createdDate,
							string lastUpdatedBy, string lastUpdatedDate) :
			base(id, description, isActive, createdBy, createdDate, lastUpdatedBy, lastUpdatedDate)
		{

		}
	}
}
