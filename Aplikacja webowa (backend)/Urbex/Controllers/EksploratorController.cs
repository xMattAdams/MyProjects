using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using FluentValidation;
using Urbex.BindingModels;
using Urbex.Data.Sql.DAO;
using Urbex.Validation;
using Urbex.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Urbex.Data.Sql;


namespace Urbex.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/eksplorator")]
    public class EksploratorController : Controller
    {
        private readonly UrbexDbContext _context;

        /// <inheritdoc />
        public EksploratorController(UrbexDbContext context)
        {
            _context = context;
        }

        [Route("{EksploratorId:min(1)}", Name = "GetEksploratorById")]
        [HttpGet]
        public async Task<IActionResult> GetEksploratorById(int EksploratorId)
        {
            var eksplorator = await _context.Eksploratorzy.FirstOrDefaultAsync(x => x.OsobaId == EksploratorId);

            if (eksplorator != null)
            {
                return Ok(new UserViewModel
                {
                    OsobaId = eksplorator.OsobaId,
                    OsobaTelefon = eksplorator.OsobaTelefon,
                    OsobaImie = eksplorator.OsobaImie,
                    OsobaNazwisko = eksplorator.OsobaNazwisko                    
                });
            }
            return NotFound();
        }

        [Route("name/{EksploratorName}", Name = "GetEksploratorByEksploratorName")]
        [HttpGet]
        public async Task<IActionResult> GetEksploratorByEksploratorName(string eksploratorName)
        {
            var eksplorator = await _context.Eksploratorzy.FirstOrDefaultAsync(x => x.OsobaImie == eksploratorName);

            if (eksplorator != null)
            {
                return Ok(new UserViewModel
                {
                    OsobaId = eksplorator.OsobaId,
                    OsobaTelefon = eksplorator.OsobaTelefon,
                    OsobaImie = eksplorator.OsobaImie,
                    OsobaNazwisko = eksplorator.OsobaNazwisko
                });
            }
            return NotFound(); 
        }

        [Route("delete/{EksploratorId:min(1)}", Name  = "DeleteEksplorator")]
        [HttpDelete]
        public async Task<IActionResult> DeleteEksplorator(int EksploratorId)
        {
            var eksplorator = await _context.Eksploratorzy.FirstOrDefaultAsync(x => x.OsobaId == EksploratorId);

            

            if (EksploratorId >0)
            {
                _context.Remove(eksplorator);
                await _context.SaveChangesAsync();
            }

            return BadRequest("Not a valid Eksplorator id");

        }








        
        [ValidateModel]
        
        public async Task<IActionResult> Post([FromBody] CreateUser createEksplorator)
        {
            var eksplorator = new Eksploratorzy
            {
                OsobaTelefon = createEksplorator.Telefon,
                OsobaImie = createEksplorator.Imie,
                OsobaNazwisko = createEksplorator.Nazwisko   
            };
            await _context.AddAsync(eksplorator);
            await _context.SaveChangesAsync();

            return Created(eksplorator.OsobaId.ToString(), new UserViewModel
            {
                OsobaId = eksplorator.OsobaId,
                OsobaTelefon = eksplorator.OsobaTelefon,
                OsobaNazwisko = eksplorator.OsobaNazwisko,
                OsobaImie = eksplorator.OsobaImie              
            });
        }

        [Route("edit/{eksploratorId:min(1)}", Name = "EditEksplorator")]
        [ValidateModel]
        [HttpPatch]
        //        public async Task<IActionResult> EditUser([FromBody] EditUser editUser,[FromQuery] int userId)
        public async Task<IActionResult> EditEksplorator([FromBody] EditEksplorator editEksplorator, int eksploratorId)
        {
            var eksplorator = await _context.Eksploratorzy.FirstOrDefaultAsync(x => x.OsobaId == eksploratorId);
            eksplorator.OsobaImie = editEksplorator.Imie;
            eksplorator.OsobaTelefon = editEksplorator.Telefon;
            eksplorator.OsobaNazwisko = editEksplorator.Nazwisko;
            await _context.SaveChangesAsync();
            return NoContent();
            return Ok(new UserViewModel
            {
                OsobaId = eksplorator.OsobaId,
                OsobaTelefon = eksplorator.OsobaTelefon,
                OsobaNazwisko = eksplorator.OsobaNazwisko,
                OsobaImie = eksplorator.OsobaImie
            });
        }
    }
}