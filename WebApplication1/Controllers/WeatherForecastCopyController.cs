//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using Models;
//using WebApplication1.Models;

//namespace WebApplication1.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class WeatherForecastController : ControllerBase
//    {
//        private static readonly string[] Summaries = new[]
//        {
//        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
//    };
//        private readonly TodoContext _context;


//        private readonly ILogger<WeatherForecastController> _logger;

//        public WeatherForecastController(ILogger<WeatherForecastController> logger, TodoContext context)
//        {
//            _logger = logger;
//            _context = context;
//        }

//        //[HttpGet(Name = "GetWeatherForecast")]
//        //public IEnumerable<WeatherForecast> Get()
//        //{
//        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
//        //    {
//        //        Date = DateTime.Now.AddDays(index),
//        //        TemperatureC = Random.Shared.Next(-20, 55),
//        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
//        //    })
//        //    .ToArray();
//        //}
//        //[HttpGet(Name = "GetTodos")]
//        [HttpGet(Name = "GetWeatherForecast")]

//        public async Task<ActionResult<IEnumerable<Todo>>> Get()
//        {
//            if (_context.Todos == null)
//            {
//                return NotFound();
//            }
//            return await _context.Todos.ToListAsync<Todo>();
//        }

//        // GET api/<TodosController>/5
//        //[HttpGet(Name = "GetWeatherForecast/{id}")]
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
//        //[HttpPost(Name = "PostWeatherForecast")]
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
//        //[HttpPut("PutWeatherForecast/{id}")]
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

//        ////// DELETE api/<TodosController>/5
//        //[HttpDelete("DeleteWeatherForecast/{id}")]
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