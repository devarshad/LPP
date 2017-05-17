using LPP.APP.Model.Abstract;
using LPP.APP.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LPP.APP
{
    public partial class SignIn : System.Web.UI.Page
    {
        //Abstract object for LPP User
        private LPPUserBO _user = null;

        /// <summary>
        /// Default page Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            _user = new LPPUserBO();
        }

        /// <summary>
        /// SignIn Action from User
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected async void btnSignIn_Click(object sender, EventArgs e)
        {
            await _user.SignInAsync(txtUserID.Text, txtPassword.Text);
        }
    }
}