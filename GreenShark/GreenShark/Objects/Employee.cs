using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class Employee
    {
        public Employee(int id, string name, FunctionEmployee function)
        {
            this.ID = id;
            this.Name = name;
            this.Function = function;
        }

        public int ID { get; set; }


        public string Name { get; set; }


        public FunctionEmployee Function { get; set; }

    }
}
