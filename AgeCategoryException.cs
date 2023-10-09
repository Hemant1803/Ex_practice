using System.Runtime.Serialization;

namespace Exception_Handling
{
    [Serializable]
    internal class AgeCategoryException : Exception
    {
        public AgeCategoryException(string? message) : base(message)
        {
        }
    }
    public class Age
    {
        public static string AgeCategory(int age)
        {
            if (age >= 1 && age <= 14)
            {
                return "Children";
            }
            else if (age >= 15 && age <= 24)
            {
                return "Youth";
            }
            else if (age >= 25 && age <= 64)
            {
                return "Adults";
            }
            else if (age >= 65)
            {
                return "Seniors";
            }
            else
            {
                throw new AgeCategoryException("Invalid age provided. Age must be a positive integer.");
            }
        }
    }
}