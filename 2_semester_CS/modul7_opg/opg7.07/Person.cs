using System;
using System.Collections.Generic;

namespace _7._07
{
    public class Person
    {
        private string name;
        private Int32 point;
        private Stack<Card> kort;

        public Person(string name, Int32 point, Stack<Card> kort)
        {
            this.name = name;
            this.point = point;
            this.kort = kort;
        }

        public string Navn { get { return name; } set { name = value; } }
        public Int32 Antalpoint { get { return point; } set { point = value; } }
        public Stack<Card> Kort { get { return kort; } set { kort = value; } }
    }
}
