using C__Cumulative_Part_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;

namespace C__Cumulative_Part_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherAPIController : ControllerBase
    {
        private readonly SchoolDbContext _context;
        // dependency injection of database context
        public TeacherAPIController(SchoolDbContext context)
        {
            _context = context;
        }


        /// <summary>
        /// Returns a list of Authors in the system
        /// </summary>
        /// <example>
        /// GET api/Author/ListAuthorNames -> ["Brian Smith","Jillian Montgomery",..]
        /// </example>
        /// <returns>
        /// A list of strings, formatted "{First Name} {Last Name}"
        /// </returns>
        [HttpGet]
        [Route(template: "ListAuthorNames")]
        public List<string> ListAuthorNames()
        {
            // Create an empty list of Author Names
            List<string> TeacherNames = new List<string>();

            // 'using' will close the connection after the code executes
            using (MySqlConnection Connection = _context.AccessDatabase())
            {
                Connection.Open();
                //Establish a new command (query) for our database
                MySqlCommand Command = Connection.CreateCommand();

                //SQL QUERY
                Command.CommandText = "select * from teachers";

                // Gather Result Set of Query into a variable
                using (MySqlDataReader ResultSet = Command.ExecuteReader())
                {
                    //Loop Through Each Row the Result Set
                    while (ResultSet.Read())
                    {
                        string TeacherFName = ResultSet["teacherfname"].ToString();
                        string TeacherLName = ResultSet["teacherlname"].ToString();
                        //Access Column information by the DB column name as an index
                        string TeacherName = $"{TeacherFName} {TeacherLName}";
                        //Add the Author Name to the List
                        TeacherNames.Add(TeacherName);
                    }
                }
            }


            //Return the final list of author names
            return TeacherNames;
        }
    }
}
