using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    public class CustomerClass
    {
        public int a, b;
        public int Id { get; set; }
        public string Name { get; set; }
        public CustomerClass()
        {
            Id = 1;
            Name = "Amit";
        }
        public CustomerClass(int id)
        {
            Id = id;
        }
        public void Display()
        {

        }
        public void Show(int d)
        {

        }
    }
}
