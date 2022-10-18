namespace SyntaxAndSyntaxSugarExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
			var answer = 4;
			string response;

			response = answer < 9 ? $"{answer} is less than nine" : 
									$"{answer} is greater than or equal to nine";

			Console.WriteLine(response);
		}
    }
}
