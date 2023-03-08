using Microsoft.AspNetCore.Mvc;
using BlogEngine.Services;
using BlogEngine.Models;
using BlogEngine.Services.Interface;

namespace BlogEngine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _service;

        public RoleController(IRoleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var roles = _service.GetRoles();
            return Ok(roles);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var role = _service.GetRole(id);
            return role == null ? NotFound() : Ok(role);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Role value)
        {
            var role = _service.CreateRole(value);
            return CreatedAtAction(nameof(Get), new { id = role.Id }, role);
        }
    }
}
