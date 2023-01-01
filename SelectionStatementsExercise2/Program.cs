namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject?");
            String subject = Console.ReadLine();
            {


                switch (subject.ToLower())
                {
                    case "math":
                    case "Math":
                    case "mathmatics":
                    case "Mathmatics":
                        Console.WriteLine("Math is not my favorite subject!");
                        break;
                    case "science":
                    case "Science":
                        Console.WriteLine("Science is Cool!!");
                        break;
                    case "pe":
                    case "PE":
                    case "physical education":
                    case "Physical Education":
                    case "Physical education":
                        Console.WriteLine("Everyone enjoys PE!!!");
                        break;
                    case "history":
                        Console.WriteLine("History is also my favorite subject!!!!");
                        break;
                    case "english":
                        Console.WriteLine("English papers can be fun to write!");
                        break;
                    default:
                        Console.WriteLine("I do not know that subject...");
                        break;
                }

            }
        }

    }


}   