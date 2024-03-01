using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

internal class Employee
{
    public int IdEmployee { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Role { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime? DateOfEnroll { get; set; }
    public int Age { get; set; }
    public int Experience { get; set; }
}
