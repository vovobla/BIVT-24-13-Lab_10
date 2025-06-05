using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public abstract class Person : IPerson, IReportable
    {
        public string FullName { get; protected set; }
        public int Age { get; protected set; }
        public Gender Gender { get; protected set; }

        protected Person(string fullName, int age, Gender gender)
        {
            FullName = fullName;
            Age = age;
            Gender = gender;
        }

        public abstract string GenerateReport();
    }
}
