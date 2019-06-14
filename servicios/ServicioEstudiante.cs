

using modelo;
using Persistencia;
using System.Collections.Generic;

namespace Servicios
{
    public interface IStudentService
    {
        IEnumerable<Estudiante> GetAll(Estudiante modelo);
        bool Add(Estudiante modelo);
        bool delete(int id);
        bool Update(Estudiante modelo);
        

    }

    public class ServicioEstudiante : IStudentService
    {

        private readonly EstudianteDb _EstudianteDb;

        public StudentService(
            EstudianteDb EstudianteDb
        )
        {
            _EstudianteDb = EstudianteDb;
        }
        public IEnumerable<Estudiante> GetAll(Estudiante modelo)
        {
            var result = new List<Estudiante>();

            try
            {
                result = _EstudianteDb.Estudiante.ToList();
            }
            catch (System.Exception)
            {

            }

            return result;
        }

        public bool Add(Estudiante modelo)
        {
            try
            {
                _EstudianteDb.Add(modelo);
                _EstudianteDb.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
        public bool Update(Estudiante modelo)
        {
            try
            {
                var originalModel = _EstudianteDb.Estudiante.Single(x =>
                    x.IDestudiante == modelo.IDestudiante
                );

                originalModel.nombre = modelo.nombre;
                originalModel.apellido = modelo.apellido;
                originalModel.Bio = modelo.Bio;

                _EstudianteDb.Update(originalModel);
                _EstudianteDb.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }
        public bool delete(int id)
        {
            try
            {
                
                _EstudianteDb.Entry(new Estudiante { IDestudiante = id }).State = Microsoft.EntityFrameworkCore.EntityState.Deleted; ;
                _EstudianteDb.SaveChanges();
            }
            catch (System.Exception)
            {
                return false;
            }

            return true;
        }




    }
}
