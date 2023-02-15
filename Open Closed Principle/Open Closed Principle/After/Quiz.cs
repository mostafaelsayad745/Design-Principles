﻿

namespace SOLID.OCP.After
{
    class Quiz
    {
        public List<Question> Questions { get; }

        public Quiz(List<Question> questions)
        {
            this.Questions = questions;
        }


        public void Print()
        {
            foreach (var q in Questions)
            {
                q.print();
                Console.WriteLine("\n\n");
            }

        }
    }
}