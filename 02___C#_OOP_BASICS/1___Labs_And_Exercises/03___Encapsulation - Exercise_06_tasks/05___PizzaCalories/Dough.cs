using System;
using System.Collections.Generic;
using System.Linq;

public class Dough
{
    private const int MIN_WEIGHT = 1;
    private const int MAX_WEIGHT = 200;
    private const int CALORIES_Multipler = 2;
    Dictionary<string,double> validFlourTypes = new Dictionary<string, double>
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1.0,
    };
    Dictionary<string, double> validBakingTechnique = new Dictionary<string, double>
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0,
    };
    private double weight;
    private string flowerType;
    private string bakingTechnique;
    public Dough(string flowerType, string bakingTechnique, double weight)
    {
        this.FlowerType = flowerType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight; 
    }

    private double FlowerTypeMultiply => validFlourTypes[this.flowerType];
    private double BakingTechniqueMultiply => validBakingTechnique[this.bakingTechnique];
    public double TotalCalories => CALORIES_Multipler * Weight
        * FlowerTypeMultiply * BakingTechniqueMultiply;

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < MIN_WEIGHT || value > MAX_WEIGHT)
            {
                throw new ArgumentException
                    ($"Dough weight should be in the range [{MIN_WEIGHT}..{MAX_WEIGHT}].");
            }
            weight = value;
        }
    }
    public string FlowerType
    {
        get { return flowerType; }
        set
        {
            ValidTypes(value, validFlourTypes);
            flowerType = value.ToLower();
        }
    }
    public string BakingTechnique
    {
        get { return bakingTechnique; }
        set
        {
            ValidTypes(value, validBakingTechnique);
            bakingTechnique = value.ToLower();
        }
    }
    private static void ValidTypes(string value , Dictionary<string,double> dictionary )
    {
        if (!dictionary.Any(p=>p.Key == value.ToLower()))
        {
            throw new ArgumentException("Invalid type of dough.");
            
        }
    }

}

