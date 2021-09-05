namespace ACPFirstNuget
{
    /// <summary>
    /// Sample Calculator Class to test ACP's first nuget package
    /// </summary>
    public class Calculator : ICalculator
    {
        /// <summary>
        /// Adds two numbers
        /// </summary>
        public double Add(double a, double b)
        {
            return a + b;
        }

        /// <summary>
        /// Subtracts 2 numbers
        /// </summary>
        public double Subtract(double a, double b)
        {
            return a - b;
        }
    }
}
