using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Source.Category
{
    class Category
    {
        public Guid id { get; }
        public string Name { get; }


        Category(Guid id, string name)
        {
            this.Name = name;
            this.id = id;
        }
    }
}
