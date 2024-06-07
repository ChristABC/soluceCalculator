using System;
class MainProgram
{
    public static void Main()
    {
        float number1;
        float number2;
        string response;
        float result;
        bool calcul = false;

        while (calcul = true)
        {
            Console.WriteLine("Quelle est votre premier nombre? ");
            number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Quelle est votre second nombre? ");
            number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Quelle opération souhaitez vous réaliser entre : addition, soustraction, multiplication, division ou modulo? ");
            response = Console.ReadLine();

            if (response == "addition")
            {
                result = add(number1, number2);
                Console.WriteLine("Votre résultat est : " + result);
            }
            else if (response == "soustraction")
            {
                result = subtract(number1, number2);
                Console.WriteLine("Votre résultat est : " + result);
            }

            else if (response == "multiplication")
            {
                result = multiply(number1, number2);
                Console.WriteLine("Votre résultat est : " + result);
            }

            else if (response == "division")
            {
                result = divide(number1, number2);
                Console.WriteLine("Votre résultat est : " + result);
            }
            else if (response == "modulo")
            {
                result = modulo(number1, number2);
                Console.WriteLine("Votre résultat est : " + result);
            }
            else
            {
                Console.WriteLine("Votre réponse n'est pas reconnu. Veuillez recommencer. ");
            }
            calcul = true;
        }
    }

    public static float add(float x, float y)
    { 
        return x + y; 
    }

    public static float subtract(float x, float y)
    {
        return x - y;
    }

    public static float multiply(float x, float y)
    {
        return x * y;
    }

    public static float divide(float x, float y)
    {
        return x / y;
    }

    public static float modulo(float x, float y)
    {
        return x % y;
    }
}