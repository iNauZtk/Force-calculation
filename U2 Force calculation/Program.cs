//Force calculation
using System;

class PhysicsCalculator
{
    static void Main()
    {
        // Get user input for mass
        Console.Write("Enter mass (in kilograms): ");
        double mass = Convert.ToDouble(Console.ReadLine());

        // Get user input for acceleration
        Console.Write("Enter acceleration (in meters per second squared): ");
        double acceleration = Convert.ToDouble(Console.ReadLine());

        // Calculate force using the formula: force = mass * acceleration
        double force = CalculateForce(mass, acceleration);

        // Display the calculated force
        Console.WriteLine($"The force applied is: {force} Newtons");
    }

    // Method to calculate force
    // Formula: force = mass * acceleration
    static double CalculateForce(double mass, double acceleration)
    {
        return mass * acceleration;
    }
}
//Newton second law
