

using SOLID.OCP.Before;

namespace SOLID.OCP.After
{
    abstract class Question
    {
        public string Title { get; set; }

        public int Mark { get; set; }

        public abstract void print();
    }
}
