using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public class Trainer : Person
    {
        private readonly List<int> ratings = [];
        public double Rating => ratings.Count == 0 ? 0 : ratings.Average();
        public List<Group> Groups { get; } = [];

        public Trainer(string fullName, int age, Gender gender) : base(fullName, age, gender) { }

        public void AddRating(int rating)
        {
            if (rating is >= 1 and <= 5)
                ratings.Add(rating);
        }

        public override string GenerateReport()
            => $"{FullName}, рейтинг: {Rating:F2}, групп: {Groups.Count}";
    }
}
