
namespace _03___BarrackWars_Factory.Attributes
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    class Inject
    {
        [AttributeUsage(AttributeTargets.Field)]
        public class InjectAttribute : Attribute
        {
        }
    }
}
