namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the person's age: ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    throw new AgeCategoryException("Age cannot be empty.");
                }

                if (!int.TryParse(input, out int age))
                {
                    throw new AgeCategoryException("Invalid age format. Age must be a positive integer.");
                }

                string category = Age.AgeCategory(age);
                Console.WriteLine($"Category: {category}");
            }
            catch (AgeCategoryException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
}