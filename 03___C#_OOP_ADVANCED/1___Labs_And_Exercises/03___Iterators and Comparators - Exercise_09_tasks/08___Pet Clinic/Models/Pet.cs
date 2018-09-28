
namespace _08___Pet_Clinic.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Pet
    {
        private string name;
        private int age;
        private string kind;

        public Pet(string name, int age, string kind)
        {
            this.Name = name;
            this.age = age;
            this.kind = kind;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }
        public override string ToString()
        {
            return $"{this.Name} {this.age} {this.kind}";
        }
    }
}
