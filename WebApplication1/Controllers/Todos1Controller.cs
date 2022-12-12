//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using WebApplication1.Models;

//namespace WebApplication1.Controllers
//{
//    //[Route("api/[controller]")]
//    //[ApiController]
//    [ApiController]
//    [Route("[controller]")]
//    public class Todos1Controller : ControllerBase
//    {
//        private readonly TodoContext _context;

//        public Todos1Controller(TodoContext context) => _context = context;

//        // GET: api/<TodosController>
//        //[HttpGet]
//        //[HttpGet(Name = "GetWeatherForecast")]


//        //[HttpGet(Name = "GetTodos")]

//        //public async Task<ActionResult<IEnumerable<Todo>>> GetTodos()
//        //{
//        //    if (_context.Todos == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return await _context.Todos.ToListAsync<Todo>();
//        //}

//        // GET api/<TodosController>/5
//        //[HttpGet("{id}")]
//        //public async Task<ActionResult<Todo>> GetTodo(int id)
//        //{
//        //    if (_context.Todos == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    var todo = await _context.Todos.FindAsync(id);
//        //    if (todo == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    return todo;
//        //}

//        //// POST api/<TodosController>
//        //[HttpPost]
//        //public async Task<ActionResult<Todo>> PostTodo(Todo todo)
//        //{
//        //    if (_context.Todos == null)
//        //    {
//        //        return Problem("Entity set 'TodoContext.Todos' is null");
//        //    }
//        //    _context.Todos.Add(todo);
//        //    await _context.SaveChangesAsync();
//        //    return CreatedAtAction(nameof(GetTodo), new { id = todo.Id }, todo);
//        //}

//        //// PUT api/<TodosController>/5
//        //[HttpPut("{id}")]
//        //public async Task<ActionResult<Todo>> PutTodo(int id, Todo todo)
//        ////public async Task<IActionResult> PutTodo(int id, Todo todo)
//        //{
//        //    if (id != todo.Id)
//        //    {
//        //        return BadRequest();
//        //    }
//        //    _context.Entry(todo).State = EntityState.Modified;
//        //    try
//        //    {
//        //        await _context.SaveChangesAsync();
//        //    }
//        //    catch (DbUpdateConcurrencyException)
//        //    {
//        //        if (!TodoExist(id))
//        //        {
//        //            return NotFound();
//        //        }
//        //        else
//        //        {
//        //            throw;
//        //        }
//        //    }
//        //    return todo;
//        //    //return NoContent();
//        //}

//        //// DELETE api/<TodosController>/5
//        //[HttpDelete("{id}")]
//        //public async Task<IActionResult> DeleteTodo(int id)
//        //{
//        //    if (_context.Todos == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    var todo = await _context.Todos.FindAsync(id);
//        //    if (todo == null)
//        //    {
//        //        return NotFound();
//        //    }
//        //    _context.Remove(todo);
//        //    await _context.SaveChangesAsync();
//        //    return NoContent();
//        //}
//        //private bool TodoExist(int id)
//        //{
//        //    return (_context.Todos?.Any(e => e.Id == id)).GetValueOrDefault();
//        //}
//    }
//}
