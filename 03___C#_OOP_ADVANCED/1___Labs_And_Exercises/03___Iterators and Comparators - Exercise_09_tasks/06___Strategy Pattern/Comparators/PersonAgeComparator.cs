using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Strategy_Pattern.Comparators
{
    using Models;
    using System.Collections.Generic;

    public class PersonAgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age - y.Age;
        }
    }
}
