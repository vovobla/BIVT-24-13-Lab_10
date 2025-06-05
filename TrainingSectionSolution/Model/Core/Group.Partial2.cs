using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class Group
    {
        public void SortByFullName()
            => Athletes = Athletes.OrderBy(a => a.FullName).ToList();

        public List<Athlete> FilterByGender(Gender gender)
            => Athletes.Where(a => a.Gender == gender).ToList();

        public List<Athlete> FilterByAge(int min, int max)
            => Athletes.Where(a => a.Age >= min && a.Age <= max).ToList();
    }
}
