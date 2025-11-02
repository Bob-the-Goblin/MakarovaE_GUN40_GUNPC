class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Please, Enter the first number: ");
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Error");
            return;
        }
        
        Console.Write("Please, enter next number: ");
        if (!int.TryParse(Console.ReadLine(), out int b))
        {
            Console.WriteLine("Error");
            return;
        }

        Console.Write($"Choose a sing: & | or ^ \nThe sing: ");
        var operation = Console.ReadLine();
        var boolVar = true;
        if (operation.Length == 0 || operation.Length > 1 && !boolVar)
        {
            Console.WriteLine("Wrong sign!");
            return;
        }

       

       switch (operation)
        {
          case "&":
                var result_t = a & b;
                Console.WriteLine($"The result of operation {a} & {b}:\n -In decimal: {result_t} \n -In binary: {Convert.ToString(result_t, 2)} \n -In hexadecimal: {Convert.ToString(result_t, 16)}");
                break;

            case "|":
                var result_plus = a | b;
                Console.WriteLine($"The result of {a} | {b}:\n -In decimal: {result_plus} \n -In binary: {Convert.ToString(result_plus, 2)} \n -In hexadecimal: {Convert.ToString(result_plus, 16)}");
                break;

            case "^":
                var result_or = a ^ b;
                Console.WriteLine($"The result of {a} ^ {b}:\n -In decimal: {result_or} \n -In binary: {Convert.ToString(result_or, 2)} \n -In hexadecimal: {Convert.ToString(result_or, 16)}");
                break;
            
        }
    
    }
}
