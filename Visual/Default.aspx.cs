using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Visual
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            imgBanner1.ImageUrl = "./img/1.png";
            imgBanner2.ImageUrl = "./img/2.png";
            imgBanner3.ImageUrl = "./img/3.png";

        }
    }
}