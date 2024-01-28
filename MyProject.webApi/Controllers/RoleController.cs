using Microsoft.AspNetCore.Mvc;
using MyProject.Common.Models;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyProject.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IService<RoleModel> roleService;
        public RoleController(IService<RoleModel> roleService)
        {
            this.roleService = roleService;
        }
        // GET: api/<RoleController>
        [HttpGet]
        public async Task<List<RoleModel>> Get()
        {
            return await roleService.getAllAsync();
        }

        // GET api/<RoleController>/5
        [HttpGet("{id}")]
        public async Task<RoleModel> Get(int id)
        {
            return await roleService.getByIdAsync(id);
        }

        // POST api/<RoleController>
        [HttpPost]
        public async  Task Post([FromBody] RoleModel role)
        {
           await roleService.AddAsync(role);
        }

        // PUT api/<RoleController>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] RoleModel roleModel)
        {
            await roleService.UpdateAsync(roleModel);
        }

        // DELETE api/<RoleController>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await roleService.DeleteAsync(id);
        }
    }
}
