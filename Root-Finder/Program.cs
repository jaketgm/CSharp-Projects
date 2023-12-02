﻿namespace RootFinder
{
    class Program
    {
        public static void Main()
        {
            Console.Write("Input value of alpha: ");
            int alpha = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input value of beta: ");
            int beta = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input value of gamma: ");
            int gamma = Convert.ToInt32(Console.ReadLine());

            double discriminant = beta * beta - 4 * alpha * gamma;

            if (discriminant > 0)
            {
                double sqrtDiscriminant = Math.Sqrt(discriminant);
                double root1 = (-beta + sqrtDiscriminant) / (2 * alpha);
                double root2 = (-beta - sqrtDiscriminant) / (2 * alpha);
                Console.WriteLine("Both roots are real.");
                Console.WriteLine("First root is = {0}", root1);
                Console.WriteLine("Second root is = {0}", root2);
            }
            else if (discriminant == 0)
            {
                double root = -beta / (2.0 * alpha);
                Console.WriteLine("Both roots are equal.");
                Console.WriteLine("Root is = {0}", root);
            }
            else
            {
                Console.WriteLine("Root is imaginary; No Real Solution.");
            }
        }
    }
}