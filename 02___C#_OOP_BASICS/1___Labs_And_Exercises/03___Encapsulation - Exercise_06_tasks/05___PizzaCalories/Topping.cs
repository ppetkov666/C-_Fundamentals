using System;
using System.Collections.Generic;
using System.Linq;

public class Topping
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 50;
    private const int CALORIES_Multipler = 2;
    private const string TYPE_MESSAGE = "Cannot place {0} on top of your pizza.";
    Dictionary<string, double> validTypes = new Dictionary<string, double>
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9,
    };
    public Topping(string type , double weight)
    {
        this.Type = type;
        ValidateWeight(type,weight);
        this.Weight = weight;
    }

    private void ValidateWeight(string type , double weight)
    {
        if (weight < MIN_WEIGHT || weight > MAX_WEIGHT)
        {
            throw new ArgumentException
                ($"{type} weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
        }
    }
    private double TypeMultiplier => validTypes[this.Type];
    public double TotalCalories => TypeMultiplier * CALORIES_Multipler * this.weight;

    private string type;
    private double weight;
    public string Type
    {
        get { return this.type; }
        set
        {
            if (!validTypes.Any(t=>t.Key == value.ToLower()))
            {
                throw new ArgumentException
                    (string.Format(TYPE_MESSAGE,value));
            }
            type = value.ToLower();
        }
    } 
    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }
}

