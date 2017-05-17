using LPP.APP.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPP.APP.Model.Abstract
{
    public interface ILPPUser
    {
        Task<bool> SignInAsync(string username, string password);
    }
}