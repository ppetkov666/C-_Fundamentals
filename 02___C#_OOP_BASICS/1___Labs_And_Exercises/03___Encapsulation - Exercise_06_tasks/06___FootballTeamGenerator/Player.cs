using System;
class Player
{
    private const int MinStatsValue = 0;
    private const int MaxStatsValue = 100;

    private string name;
    private double endurance;
    private double sprint;
    private double dribble;
    private double passing;
    private double shooting;
    private double skillLevel;

    public Player(string name, double endurance, double sprint, 
                  double dribble, double passing, double shooting)
    {
        this.Name = name;
        this.Endurance = endurance;
        this.Sprint = sprint;
        this.Dribble = dribble;
        this.Passing = passing;
        this.Shooting = shooting;
        this.skillLevel = (endurance + sprint + dribble + passing + shooting) / 5;
    }
    public string Name
    {
        get
        {
            return this.name;
        }

        private set
        {
            if (string.IsNullOrWhiteSpace(value) || value == string.Empty)
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    } 

    private double Shooting
    {
        set
        {
            this.ValidateData(value, nameof(this.Shooting));
            this.shooting = value;
        }
    }

    private double Passing
    {
        set
        {
            this.ValidateData(value, nameof(this.Passing));
            this.passing = value;
        }
    }

    private double Dribble
    {
        set
        {
            this.ValidateData(value, nameof(dribble));
            this.dribble = value;
        }
    }

    private double Sprint
    {
        set
        {
            this.ValidateData(value, nameof(this.Sprint));
            this.sprint = value;
        }
    }

    private double Endurance
    {
        set
        {
            this.ValidateData(value, nameof(this.Endurance));
            this.endurance = value;
        }
    }
    public double SkillLevel => this.skillLevel;

    private void ValidateData(double value, string statparameter)
    {
        if (value < MinStatsValue || value > MaxStatsValue)
        {
            throw new ArgumentException($"{statparameter} should be between 0 and 100.");
        }
    }
}

