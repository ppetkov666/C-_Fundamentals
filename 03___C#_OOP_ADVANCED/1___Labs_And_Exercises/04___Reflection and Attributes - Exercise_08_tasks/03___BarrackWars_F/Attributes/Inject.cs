using System;
using System.Collections.Generic;
using System.Text;

namespace _03___BarrackWars_Factory.Attributes
{
    class Inject
    {
        [AttributeUsage(AttributeTargets.Field)]
        public class InjectAttribute : Attribute
        {
        }
    }
}
