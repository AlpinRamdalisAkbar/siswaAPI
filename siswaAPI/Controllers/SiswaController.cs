//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using siswaAPI.Data;
using siswaAPI.Models;

namespace siswaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiswaController : ControllerBase
    {
        private readonly DbContextSiswa _contextSiswa;

        public SiswaController(DbContextSiswa contextSiswa)
        {
            _contextSiswa = contextSiswa;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            var allDatas = _contextSiswa.SISWA.ToList();

            return Ok(allDatas);
        }

        [HttpPost]
        public IActionResult PostData([FromBody] Siswa siswaRequest)
        {
            siswaRequest.ID = Guid.NewGuid();

            _contextSiswa.SISWA.Add(siswaRequest);

            _contextSiswa.SaveChanges();
            
            return Ok(siswaRequest);
        }

        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetData([FromRoute] Guid id)
        {
            var data = _contextSiswa.SISWA.FirstOrDefault(s => s.ID == id);

            if (data == null)
            {
                return NotFound();
            }

            return Ok(data);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        public IActionResult UpdateData([FromRoute] Guid id, Siswa updateData)
        {
            var data = _contextSiswa.SISWA.Find(id);

            if (data == null)
            {
                return NotFound();
            }

            data.NAME = updateData.NAME;
            data.GENDER = updateData.GENDER;
            data.RELIGION = updateData.RELIGION;
            data.ADDRESS = updateData.ADDRESS;
            data.CLASS = updateData.CLASS;
            data.STUDY = updateData.STUDY;

            _contextSiswa.SaveChanges();
            
            return Ok(data);
        }
    }
}
