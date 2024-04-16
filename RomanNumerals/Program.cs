using RomanNumerals.Converter;

public class Program
{
    private static void Main(string[] args)
    {
        string result = "";

        Console.WriteLine("Hello, Let's convert some numbers to Roman Numerals!");
        Console.WriteLine("Please enter a number between 1 and 3999");

        var input = Console.ReadLine();
        try
        {
            if (input != "")
            {
                var res = Convert.ToInt32(input);
                if (res < 0 || res > 3999)
                {
                    throw new IndexOutOfRangeException();
                }

                ConvertToRoman convertToRoman = new ConvertToRoman();
                result = convertToRoman.ConvertRoman(Convert.ToInt32(input));
                Console.WriteLine($"{input} became {result}");
            }
        }
        catch (FormatException fEx)
        {
            Console.WriteLine("Error! You didn't enter a number");
        }
        catch (IndexOutOfRangeException iEx)
        {
            Console.WriteLine("Error! You may have entered a number below 1, or above 3,999");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error! {ex.Message}");
        }

        Console.ReadLine();

    }
}