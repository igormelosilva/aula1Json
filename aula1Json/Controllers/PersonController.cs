using Microsoft.AspNetCore.Mvc;
using aula1Json.Models;

namespace aula1Json.Controllers
{
    [ApiController]
    [Route("api/Person")]
    public class PersonController : Controller
    {
        [HttpGet]
        [Route("GetPersonName")]
        public JsonResult GetPersonName(int id)
        {
            try
            {
                if(id == 1)
                {
                    return new JsonResult("João");
                }
                else if(id == 2)
                {
                    return new JsonResult("Maria");
                }
                else 
                    return new JsonResult("Id não encontrado");
            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
        }
        [HttpGet]
        [Route("GetPerson")]
        public JsonResult GetPerson(int id) 
        {
            Person person = new Person();
            try
            {
                if (id == 1)
                {
                    person.id = 1;
                    person.name = "João";
                }
                else if (id == 2)
                {
                    person.id = 1;
                    person.name = "Maria";
                }
                
            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            return new JsonResult(person);
        }
        [HttpGet]
        [Route("GetAllPerson")]
        public JsonResult GetAllPerson()
        {
            List<Person> listPerson = new List<Person>();
            try
            {
                Person person = new Person();
                person.id = 1;
                person.name = "João";
                listPerson.Add(person);

                person = new Person();
                person.id = 2;
                person.name = "Maria";
                listPerson.Add(person);
            }
            catch (Exception ex)
            {

                return new JsonResult(ex.Message);
            }
            return new JsonResult(listPerson);
        }
        #region Retorno Json de objetos

        [HttpGet]
        [Route("Validate")]
        public JsonResult Validate() 
        {
            Result result = new Result();
            try
            {
                result.success = true;
                result.message = "Validação feita com sucesso";

            }
            catch (Exception ex)
            {

                result.success=false;
                result.message="Erro: " + ex.Message;
            }
            return new JsonResult(new {result = result, 
                data = DateTime.Now.ToString("dd/MM/yyyy"),
                hora = DateTime.Now.ToString("HH:mm")});
                
        
        }
        public JsonResult GetAllPerson2()
        {
            Result result = new Result();
            List<Person> listPerson = new List<Person>();
            try
            {
                result.success = true;
                result.message = "Requisição feita com sucesso";

                Person person = new Person();
                person.id = 1;
                person.name = "João";
                listPerson.Add(person);

                person = new Person();
                person.id = 2;
                person.name = "Maria";
                listPerson.Add(person);

            }
            catch (Exception ex)
            {
            }
            return new JsonResult(new { result = result, listPerson = listPerson });
        }

        #endregion
    }
}
