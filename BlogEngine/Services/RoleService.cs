using BlogEngine.Models;
using BlogEngine.Services.Interface;

namespace BlogEngine.Services
{
    public class RoleService : IRoleService
    {
        public RoleService() { }

        public IEnumerable<Role> GetRoles() => throw new NotImplementedException();
        public Role GetRole(int role) => throw new NotImplementedException();
        public Role CreateRole(Role role) => throw new NotImplementedException();
    }
}
