using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GreenShark
{
    public class FunctionEmployee
    {
        public FunctionEmployee(string function, int id)
        {
            this.Function = function;
            this.ID = id;
        }

        public string Function { get; set; }


        public int ID { get; set; }

    }
}
