namespace Calculadora;

public class Calculo
{
    //Métodos para o calculo das operações
    public static void Soma(){
        
        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1-num2;
        
        Console.Clear();
        System.Console.Write("CALCULANDO.");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"{num1} - {num2} = {result}");
    }

    public static void Subtracao(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1-num2;
        
        Console.Clear();
        System.Console.Write("CALCULANDO.");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"{num1} - {num2} = {result}");
    }

    public static void Multiplicacao(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1*num2;
        
        Console.Clear();
        System.Console.Write("CALCULANDO.");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"{num1} * {num2} = {result}");
    }

    public static void Divisao(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1/num2;
        
        Console.Clear();
        System.Console.Write("CALCULANDO.");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        System.Console.WriteLine(" ");
        System.Console.WriteLine($"{num1} / {num2} = {result}");
    }
}
