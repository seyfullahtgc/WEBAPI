using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Configuration;
using WEBAPI.Model;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonelController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PersonelController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            IEnumerable<Personel> personeller = await _unitOfWork.Personel.GetirHepsi();
            return Ok(personeller);


        }
        [HttpPost]
        public async Task<IActionResult> CreatePersonel(Personel personel)
        {
            if (ModelState.IsValid)
            {
                personel.Id = Guid.NewGuid();

                await _unitOfWork.Personel.Ekle(personel);
                await _unitOfWork.CompleteAsync();

                return CreatedAtAction("Get Employee", new { personel.Id }, personel);

            }

            return new JsonResult("Hata Oluştu") { StatusCode = 500 };

        }








    }
}
