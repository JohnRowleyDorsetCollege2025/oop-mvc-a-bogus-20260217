using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBogus.Domain.Services
{
    public class FakeDataService
    {
        private readonly List<PersonRow> _people;
        public FakeDataService()
        {
            _people = GenerateFakePeople(100);
        }

        public IReadOnlyList<PersonRow> GetPeople() => _people;

        private static List<PersonRow> GenerateFakePeople(int count)
        {
            var faker = new Bogus.Faker<PersonRow>()
                .RuleFor(p => p.Id, f => f.IndexFaker + 1)
                .RuleFor(p => p.FullName, f => f.Name.FullName())
                .RuleFor(p => p.Email, f => f.Internet.Email())
                .RuleFor(p => p.City, f => f.Address.City())
                .RuleFor(p => p.DateOfBirth, f => f.Date.Past(50, DateTime.Now.AddYears(-18)));

            return faker.Generate(count);
        }
    }
}
