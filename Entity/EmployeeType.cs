using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// Inherities ReferenceDataActive and uses its properties 
    /// </summary>
	public class EmployeeType : ReferenceDataActive
	{
		#region Constructors

		public EmployeeType() : base()
		{
		}

		public EmployeeType(int id, string description, bool isActive, string createdBy, string createdDate,
							string lastUpdatedBy, string lastUpdatedDate) :
			base(id, description, isActive, createdBy, createdDate, lastUpdatedBy, lastUpdatedDate)
		{
		}

		#endregion

	}
}
