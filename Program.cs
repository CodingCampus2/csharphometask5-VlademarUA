using System;
using CodingCampusCSharpHomework;

namespace HomeworkTemplate
{
    class SuperVirus : Task5.Virus
    {
        public SuperVirus() : base(false) 
        {
            DateTimeOfCreation = DateTime.UtcNow;
        }
        public override float KillProbability
        {
            get => m_KillProbability;
            set
            {
                float doubleChance = value * 2.0f;
                m_KillProbability = MathF.Min(doubleChance, 1.0f);
            }
        }
        public override string Name
        {
            get => m_Name;
            set 
            {
                m_Name = value.Replace("virus", "supervirus");
            }
        }

        public override string VictimName { get; set; }
        public override DateTime DateTimeOfCreation { get; }

        private float m_KillProbability;
        private string m_Name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Func<Task5, Task5.Virus> TaskSolver = task =>
            {
                Task5.Virus virus = new SuperVirus();
                return virus;
            };
            Task5.CheckSolver(TaskSolver);
        }
    }
}
