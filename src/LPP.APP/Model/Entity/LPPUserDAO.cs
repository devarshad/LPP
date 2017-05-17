using LPP.APP.Model.Abstract;
using LPP.APP.Model.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LPP.APP.Model.Entity
{
    public class LPPUserDAO : ILPPUser
    {
        public async Task<bool> SignInAsync(string username, string password)
        {
            using (var _ent = new LPPEntities())
            {
                return await Task.FromResult<bool>(_ent.tblProfiles.Any(x => x.UserName == username));
            }
        }
    }
}