using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using MVCCore.Models;
using System.Threading.Tasks;

namespace MVCCore.BL
{
    public interface IRole
    {
       public Task<bool> CreateRole(CreateRoleModel crm);

    }
}
