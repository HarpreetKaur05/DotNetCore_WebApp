using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVCCore.BL
{
   public interface IChangePassword
    {
        public Task<bool> ChangeUserPassword(MVCCore.Models.ChangePasswordModel changePasswordModel);
    }
}
