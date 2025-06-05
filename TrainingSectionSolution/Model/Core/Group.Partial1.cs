using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class Group : IReportable
    {
        public string Name { get; set; }
        public Trainer Trainer { get; set; }
        public List<Athlete> Athletes { get; set; } = [];

        public Group(string name, Trainer trainer)
        {
            Name = name;
            Trainer = trainer;
            trainer.Groups.Add(this);
        }

        public void AddAthlete(Athlete athlete)
        {
            if (!Athletes.Contains(athlete))
                Athletes.Add(athlete);
        }

        public void RemoveAthlete(Athlete athlete)
            => Athletes.Remove(athlete);

        public string GenerateReport()
            => $"Группа: {Name}, Тренер: {Trainer.FullName}, Количество участников: {Athletes.Count}";

        public static Group operator +(Group g1, Group g2)
        {
            var result = new Group(g1.Name + "+" + g2.Name, g1.Trainer);
            result.Athletes.AddRange(g1.Athletes);
            result.Athletes.AddRange(g2.Athletes);
            return result;
        }
    }
}
