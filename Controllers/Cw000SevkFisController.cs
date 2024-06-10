using Crud.Models;
using Crud.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Cw000SevkFisController(DataContext dataContexta) : Controller
    {
        private readonly DataContext dataContext = dataContexta;

        //Tum kaydi getir
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var items = await dataContext.Cw000SevkFis.ToListAsync();
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

    }
}