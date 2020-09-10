using MediatR;
using Microsoft.AspNetCore.Identity;
using MVCCore.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MVCCore.BL
{
    public class Role : IRole , IRequest<bool>
    {

        private readonly RoleManager<IdentityRole> _rolemanager; 
        public Role(RoleManager<IdentityRole> rolemanager)
        {
            _rolemanager = rolemanager;
        }

        public async Task<bool> CreateRole(CreateRoleModel crm)
        {
            IdentityRole identityRole = new IdentityRole {
                Name = crm.RoleName
            };

            IdentityResult result = await _rolemanager.CreateAsync(identityRole);
            return result.Succeeded;
        }
                
    }
}
