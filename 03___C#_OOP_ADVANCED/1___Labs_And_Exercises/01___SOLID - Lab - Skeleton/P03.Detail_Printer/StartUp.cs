using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class StartUp
    {
        static void Main()
        {
            var documents = new List<string>();
            documents.Add("ivanDoc");
            documents.Add("petkoDoc");
            documents.Add("georgiDoc");
            var manager = new Manager("petko",documents);
            var employee = new Employee("marian");

            var storage = new List<Employee>();
            storage.Add(manager);
            storage.Add(employee);
            var result = new DetailsPrinter(storage);
            result.PrintDetails();
            
            
        }
    }
}
