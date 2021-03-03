using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VermeerWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Category { get; set; }

        public decimal Price { get; set; }

    }

    public class Repositories : IEnumerable
    {
        public string name { get; set; }
        public string language { get; set; }
        public string owner { get; set; } //or login ?
        public string updated_at { get; set; }

        private List<Repositories> repositories;

        public List<Repositories> Repository { get => this.repositories; set => this.repositories = value; }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}

