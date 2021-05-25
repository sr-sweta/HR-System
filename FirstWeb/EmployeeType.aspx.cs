using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace FirstWeb
{
    public partial class EmployeeType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ArrayList list = MasterLogic.GetAllEmployeeType();
                GridViewEmployeeType.DataSource = list;
                GridViewEmployeeType.DataBind();
            }
        }
    }
}