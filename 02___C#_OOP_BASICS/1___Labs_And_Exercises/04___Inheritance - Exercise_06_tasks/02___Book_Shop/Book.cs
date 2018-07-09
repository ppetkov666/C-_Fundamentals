﻿using System;
using System.Text;

public class Book
{
    private string title;
    private string author;
    private decimal price;

    public Book(string author, string title, decimal price)
    {
        this.Author = author;
        this.Title = title;
        this.Price = price;

    }
    public string Title
    {
        get { return title; }
        set
        {
            if (value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }
            title = value;
        }
    }
    public string Author
    {
        get { return author; }
        set
        {
            string[] authorNames = value.Split();
            if (authorNames.Length == 2 && char.IsDigit(authorNames[1][0]))
            {
                throw new ArgumentException("Author not valid!");
            }
            author = value;
        }
    }
    public virtual decimal Price
    {
        get { return price; }
        set
        {
            if (value <= 0 )
            {
                throw new ArgumentException("Price not valid!");
            }
            price = value;
        }
    }
    public override string ToString()
    {
        StringBuilder builder = new StringBuilder();
        builder.AppendLine($"Type: {GetType().Name}")
               .AppendLine($"Title: {this.Title}")
               .AppendLine($"Author: {this.Author}")
               .AppendLine($"Price: {this.Price:f2}");
        string result = builder.ToString().TrimEnd();
        return result; 
    }
}

