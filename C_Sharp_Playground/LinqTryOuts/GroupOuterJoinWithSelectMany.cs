using System;
using System.Collections.Generic;
using System.Linq;

using C_Sharp_Playground.LinqTryOuts.Classes;

namespace C_Sharp_Playground.LinqTryOuts
{
    public class GroupOuterJoinWithSelectMany
    {

        public GroupOuterJoinWithSelectMany()
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = terry };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            // Create two lists.
            List<Person> people = new List<Person> { magnus, terry, charlotte, arlene };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var query = people
                            .GroupJoin(pets, x => x, y => y.Owner, (x, y) => new { x.FirstName, Pets = y }) // Create a nested list of pets per owner
                            .SelectMany(xy => xy.Pets.DefaultIfEmpty(), (x, y) => new { x.FirstName, PetName = y?.Name ?? String.Empty }); // Flattens and projects

            foreach (var v in query)
            {
                Console.WriteLine($"{v.FirstName + ":",-15}{v.PetName}");
            }
        }
    }
}
