using System.Linq;
using System.Threading.Tasks;
using BasicEntityFrameworkCoreApp.Classes;
using BasicEntityFrameworkCoreApp.Contexts;
using static System.Console;


await DisplayPeopleTask();

ReadLine();

#region Methods

static async Task DisplayPeopleTask()
{
    await using var context = new SchoolContext();

    if (await context.TestConnectionTask())
    {
        var people = context.People.ToList();

        foreach (var person in people)
        {

            WriteLine(person.HireDate != null ?
                $"{person.PersonId,-4}{person.FirstName,-12}{person.LastName,-20}{person.HireDate.Value.Date:d}" :
                $"{person.PersonId,-4}{person.FirstName,-12}{person.LastName,-20}Unknown");
        }

    }
    else
    {
        WriteLine("Connection will fail");
    }
}

#endregion