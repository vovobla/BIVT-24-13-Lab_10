using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Core
{
    public partial class Group
    {
        public int SessionCount { get; set; }
        private readonly Dictionary<Athlete, bool> feedbackGiven = [];

        public void AddSession() => SessionCount++;

        public bool CanLeaveFeedback(Athlete athlete)
            => !feedbackGiven.ContainsKey(athlete) || !feedbackGiven[athlete];

        public void LeaveFeedback(Athlete athlete, int rating)
        {
            if (!CanLeaveFeedback(athlete)) return;
            Trainer.AddRating(rating);
            feedbackGiven[athlete] = true;
        }
    }
}
