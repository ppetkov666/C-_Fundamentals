using System;
using System.Collections;
using System.Collections.Generic;

public class StartUp
{
    public static void Main(string[] args)
    {
       int firstNumTest = 123345346;
       int secondNumTest = 6789567;
       string nameTest = "petko";
       string nameAnotherTest = "petkopetkov";
       
       var myScale = new Scale<int>(firstNumTest, secondNumTest);
       Console.WriteLine(myScale.GetHeavier());
       var myScalesecond = new Scale<string>(nameTest, nameAnotherTest);
       Console.WriteLine(myScalesecond.GetHeavier());
    }

}


