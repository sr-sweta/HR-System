using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	public class EmployeeType : ReferenceDataActive
	{
		
		public EmployeeType() : base()
		{
		}

		public EmployeeType(int id, string description, bool isActive, string createdBy, string createdDate,
							string lastUpdatedBy, string lastUpdatedDate):
			base (id, description, isActive, createdBy, createdDate, lastUpdatedBy, lastUpdatedDate)
		{

		}
	}
}
