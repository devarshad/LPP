using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LPP.APP.Model.Domain
{
    // Summary:
    //     Possible results from sign in attempt
    public enum SignInStatus
    {
        /// <summary>
        /// UserName and Password is empty
        /// </summary>
        EmptyUserNameAndPassword = 0,
        /// <summary>
        /// UserName is empty
        /// </summary>
        EmptyUserName,
        /// <summary>
        /// Password is empty
        /// </summary>
        EmptyPassword,
        // Summary:
        //     Sign in was successful
        Success,
        //
        // Summary:
        //     Password at AD expires.
        PasswordExpired,
        //
        // Summary:
        //     Account removed from AD but exist in LPP database.
        AccountRemoved,
        //
        // Summary:
        //     Sign in failed
        Failure,
    }
}
