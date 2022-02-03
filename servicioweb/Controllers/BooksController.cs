using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using servicioweb.Models.Response;
using servicioweb.Models;
using System.Linq;
using System;
using servicioweb.Models.Resquest;
using System.Collections.Generic;

namespace servicioweb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        //
        [HttpGet]
        public IActionResult GetBooks()
        {
            RespuestaAPI<List<Books>> reaction = new RespuestaAPI<List<Books>>();

            //Try catch para manejar excepciones
            try
            {
                using (BooksContext dbBooks = new BooksContext())
                {
                    //Obtener Datos
                    var list = dbBooks.Books.ToList();

                    //Aviso de exito
                    reaction.Congragulation = 1;
                    reaction.CongragulationData = list;
                }
            }
            catch (Exception error) {
                reaction.CongragulationMessage = error.Message;
                return NotFound();
            }

            return Ok(reaction);

            
            
        }

        //Funcion que trae solo un libro
        [HttpGet("{Id_Book}")]
        public IActionResult GetBooks(int Id_Book)
        {
            RespuestaAPI<Books> reaction = new RespuestaAPI<Books>();

            //Try catch para manejar excepciones
            try
            {
                using (BooksContext dbBooks = new BooksContext())
                {
                    //Obtener Datos
                    var list = dbBooks.Books.Find(Id_Book);

                    //Aviso de exito
                    reaction.Congragulation = 1;
                    reaction.CongragulationData = list;
                }
            }
            catch (Exception error)
            {
                reaction.CongragulationMessage = error.Message;
            }

            return Ok(reaction);
        }

        //Funcion para añadir libros
        [HttpPost]
        public IActionResult AddBooks(BooksRequestData requestData)
        {
            RespuestaAPI<object> reaction = new RespuestaAPI<object>();

            //Try catch para manejar excepciones
            try
            {
                using (BooksContext dbBooks = new BooksContext())
                {
                    Books books = new Books();
                    books.Title = requestData.Title;
                    books.Category = requestData.Category;
                    books.Synopsis = requestData.Synopsis;
                    dbBooks.Books.Add(books);
                    dbBooks.SaveChanges();
                    reaction.Congragulation = 1;
                }
            }
            catch (Exception error)
            {
                reaction.CongragulationMessage = error.Message;
            }

            return Ok(reaction);
        }

        //Funcion para editar libros
        [HttpPut]
        public IActionResult EditBooks(BooksRequestData requestData)
        {
            RespuestaAPI<object> reaction = new RespuestaAPI<object>();

            //Try catch para manejar excepciones
            try
            {
                using (BooksContext dbBooks = new BooksContext())
                {
                    Books books = dbBooks.Books.Find(requestData.Id_Book);
                    books.Title = requestData.Title;
                    books.Category = requestData.Category;
                    books.Synopsis = requestData.Synopsis;
                    dbBooks.Entry(books).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    dbBooks.SaveChanges();
                    reaction.Congragulation = 1;
                }
            }
            catch (Exception error)
            {
                reaction.CongragulationMessage = error.Message;
                Console.WriteLine(error);
            }

            return Ok(reaction);
        }

        //Funcion para borrar libros
        [HttpDelete("{Id_Book}")]
        public IActionResult DeleteBooks(int Id_Book)
        {
            RespuestaAPI<object> reaction = new RespuestaAPI<object>();

            //Try catch para manejar excepciones
            try
            {
                using (BooksContext dbBooks = new BooksContext())
                {
                    Books books = dbBooks.Books.Find(Id_Book); 
                    dbBooks.Remove(books);
                    dbBooks.SaveChanges();
                    reaction.Congragulation = 1;
                }
            }
            catch (Exception error)
            {
                reaction.CongragulationMessage = error.Message;
            }

            return Ok(reaction);
        }
    }
}
