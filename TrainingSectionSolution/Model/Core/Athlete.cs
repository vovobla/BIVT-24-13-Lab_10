using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class Athlete : Person
    {
        public Athlete(string fullName, int age, Gender gender) : base(fullName, age, gender) { }

        public override string GenerateReport()
            => $"Спортсмен: {FullName}, возраст: {Age}, пол: {Gender}";
    }
}
