using System;
using System.Collections.Generic;

namespace ST10302323_POE_Part1
{
    internal class Program
    {
        class Ingredient
        {
            public string Name { get; set; }
            public double Quantity { get; set; }
            public string Unit { get; set; }
        }//Ingredient

        class Step
        {
            public string Description { get; set; }
        }//Step

        class Recipe
        {
            public List<Ingredient> Ingredients { get; private set; }
            public List<Step> Steps { get; private set; }

            public Recipe()
            {
                Ingredients = new List<Ingredient>();
                Steps = new List<Step>();
            }//Recipe

            public void AddIngredient(string name, double quantity, string unit)
            {
                Ingredients.Add(new Ingredient { Name = name, Quantity = quantity, Unit = unit });
            }//AddIngredient
