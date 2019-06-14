using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using modelo;
using Servicios;

namespace practica2.Controllers
{
    [Route("[controller]")]
    public class studentcontroller : ControllerBase
    {
        private readonly IStudentService _EstudianteDb;

        public StudentController(IStudentService EstudianteDb)
        {
            _EstudianteDb = EstudianteDb;
        }

        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(
                _EstudianteDb.GetAll()
            );
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(
                _EstudianteDb.Get(id)
            );
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Estudiante modelo)
        {
            return Ok(
                _EstudianteDb.Add(modelo)
            );
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody]  Estudiante modelo)
        {
            return Ok(
                _EstudianteDb.Add(modelo)
            );
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok(
                _EstudianteDb.Delete(id)
            );
        }
    }
}
