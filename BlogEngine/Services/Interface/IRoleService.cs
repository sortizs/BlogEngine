using BlogEngine.Models;

namespace BlogEngine.Services.Interface
{
    public interface IRoleService
    {
        IEnumerable<Role> GetRoles();
        Role GetRole(int id);
        Role CreateRole(Role role);
    }
}
