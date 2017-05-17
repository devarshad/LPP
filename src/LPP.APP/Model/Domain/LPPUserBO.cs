using LPP.APP.Model.Abstract;
using LPP.APP.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LPP.APP.Model.Domain
{
    public class LPPUserBO
    {
        //Abstract object for LPP User
        private ILPPUser _user = null;
        
        /// <summary>
        /// This is for automation testing(Unit & integration)
        /// </summary>
        /// <param name="obj"></param>
        public LPPUserBO(ILPPUser user)
        {
            this._user = user;
        }

        /// <summary>
        /// 
        /// </summary>
        public LPPUserBO()
        {
            _user = new LPPUserDAO();
        }

        /// <summary>
        /// Sign In LPP User
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public async Task<SignInStatus> SignInAsync(string username, string password)
        {
            //check if UserName and Password is Empty
            if (String.IsNullOrWhiteSpace(username) && String.IsNullOrWhiteSpace(password))
                return SignInStatus.EmptyUserNameAndPassword;

            //check if UserName is valid
            if (String.IsNullOrWhiteSpace(username))
                return SignInStatus.EmptyUserName;

            //check if Password is valid
            if (String.IsNullOrWhiteSpace(password))
                return SignInStatus.EmptyPassword;

            //calling Data Service Layer
            if (await _user.SignInAsync(username, password) == true)
                return SignInStatus.Success;
            else
                return SignInStatus.Failure;
        }
    }
}