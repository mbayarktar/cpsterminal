using Crud.Models;
using Crud.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Crud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CwUsersController(DataContext dataContexta) : Controller
    {
        //git test
        private readonly DataContext dataContext = dataContexta;

        //Tum kaydi getir
        [HttpGet("Get")]
        public async Task<IActionResult> Get()
        {
            try
            {
                var items = await dataContext.CwUsers.ToListAsync();
                return Ok(items);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }

        }

        [HttpGet("GetById/{Id}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                var item = await dataContext.CwUsers.FirstOrDefaultAsync(p => p.UsId == Id);
                return Ok(item);
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        //Kayit Ekle
        [HttpPost("Add")]
        public async Task<IActionResult> Add(CwUsers cwUsers)
        {
            try
            {
                await dataContext.CwUsers.AddAsync(cwUsers);
                await dataContext.SaveChangesAsync();
                return Ok("Kayit Eklendi");
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }

        //Kayit Guncelle
        [HttpPut("Upd")]
        public async Task<IActionResult> Upd(CwUsers cwUsers)
        {
            try
            {
                var item = await dataContext.CwUsers.FirstOrDefaultAsync(p => p.UsId == cwUsers.UsId);
                if (item == null) return BadRequest("Id bulunamadi");
                dataContext.Entry(item).CurrentValues.SetValues(cwUsers);
                await dataContext.SaveChangesAsync();
                return Ok("Kayit Guncellendi");
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }



        //Kayit Silme
        [HttpDelete("Del/{Id}")]
        public async Task<IActionResult> Del(int Id)
        {
            try
            {
                var item = await dataContext.CwUsers.FirstOrDefaultAsync(p => p.UsId == Id);
                if (item == null) return BadRequest("Id bulunamadi");

                dataContext.Remove(item);
                await dataContext.SaveChangesAsync();
                return Ok("Kayit Silind");
            }
            catch (Exception e)
            {
                return Problem(e.Message);
            }
        }
    }
}