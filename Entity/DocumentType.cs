using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
	/// <summary>
	/// Inherites ReferenceDataActive and uses its properties 
	/// </summary>
	public class DocumentType : ReferenceDataActive
	{
		/// <summary>
		/// All constructors of DocumentType 
		/// </summary>
		#region Constructors

		/// <summary>
		/// Default constructor
		/// </summary>
		public DocumentType() : base()
		{
		}

		 /// <summary>
		 /// Constructor intialising id and description
		 /// </summary>
		public DocumentType(int id, string description) : base(id, description)
		{
		}

		/// <summary>
		/// Constructor initialising all values
		/// </summary>
		/// <param name="id"></param>
		/// <param name="description"></param>
		/// <param name="isActive"></param>
		/// <param name="createdBy"></param>
		/// <param name="createdDate"></param>
		/// <param name="lastUpdatedBy"></param>
		/// <param name="lastUpdatedDate"></param>
		public DocumentType(int id, string description, bool isActive, string createdBy, string createdDate,
							string lastUpdatedBy, string lastUpdatedDate) :
			base(id, description, isActive, createdBy, createdDate, lastUpdatedBy, lastUpdatedDate)
		{
		}

		#endregion

	}
}
