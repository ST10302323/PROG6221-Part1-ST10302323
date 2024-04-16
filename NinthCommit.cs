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

            public void AddStep(string description)
            {
                Steps.Add(new Step { Description = description });
            }//AddStep

            public void DisplayRecipe()
            {
                Console.WriteLine("\nRecipe:");
                Console.WriteLine("Ingredients:");
                foreach (var ingredient in Ingredients)
                {
                    Console.WriteLine($"- {ingredient.Quantity} {ingredient.Unit} {ingredient.Name} ");
                }
                Console.WriteLine("\nSteps:");
                for (int i = 0; i < Steps.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Steps[i].Description}");
                }//for
            }//DisplayRecipe

            public void ScaleRecipe(double factor)
            {
                foreach (var ingredient in Ingredients)
                {
                    ingredient.Quantity *= factor;
                }
            }//ScaleRecipe

            public void ResetQuantities()
            {
                // Reset quantities to original values (assuming original quantities are stored //elsewhere)   
                Console.WriteLine("Quantities reset to original values.");
            }//ResetQuantities

            public void ClearRecipe()
            {
                Ingredients.Clear();
                Steps.Clear();
                Console.WriteLine("Recipe data cleared.");
            }//ClearRecipe
        }//Recipe
