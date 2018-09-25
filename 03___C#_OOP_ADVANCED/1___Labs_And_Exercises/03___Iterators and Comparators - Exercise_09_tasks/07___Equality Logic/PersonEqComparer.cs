

namespace _07___Equality_Logic
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class PersonEqComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person first, Person second)
        {
            return first.CompareTo(second) == 0;
        }

        public int GetHashCode(Person person)
        {
            return $"{person.Name} {person.Age}".GetHashCode();
        }
    }
}
