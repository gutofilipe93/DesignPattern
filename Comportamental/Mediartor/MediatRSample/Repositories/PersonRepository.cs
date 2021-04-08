using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatRSample.Application.Models;

namespace MediatRSample.Repositories
{
    public class PersonRepository : IRepository<Person>
    {
        private static Dictionary<int, Person> people = new Dictionary<int, Person>();
        public Task Add(Person item)
        {
            people.Add(item.Id, item);
            return Task.CompletedTask;
        }

        public Task Delete(int id)
        {
            people.Remove(id);
            return Task.CompletedTask;
        }

        public Task Edit(Person item)
        {
            people.Remove(item.Id);
            people.Add(item.Id, item);
            return Task.CompletedTask;
        }

        public Task<Person> Get(int id)
        {
            return Task.FromResult(people.GetValueOrDefault(id));
        }

        public Task<List<Person>> GetAll()
        {
            return Task.FromResult(people.Values.ToList());
        }
    }
}