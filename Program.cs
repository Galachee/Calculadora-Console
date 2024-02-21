using System.Data;
using System.Globalization;

public class Program
{
    
    public static void Main()
    {

    try
    {

        Menu();

    }

     catch(FormatException ex){

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;

            System.Console.WriteLine("Digite uma das opções disponíveis!");
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Main();

        }

        catch(Exception ex){

            System.Console.WriteLine($"{ex.Message}");
            Console.ReadLine();
            Main();
            
        }
       
    }

    public static void Menu(){
            int option = 0;
            
            
            Console.ForegroundColor = ConsoleColor.Cyan;    
            Console.Clear();
            System.Console.WriteLine("1 - ADIÇÃO");
            System.Console.WriteLine("");
            System.Console.WriteLine("2 - SUBTRAÇÃO");
            System.Console.WriteLine("");
            System.Console.WriteLine("3 - MULTIPLICAÇÃO");
            System.Console.WriteLine("");
            System.Console.WriteLine("4 - DIVISÃO");
            System.Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Console.WriteLine("5 - FECHAR CALCULADORA");
            System.Console.WriteLine("   ");
            
            Console.ForegroundColor = ConsoleColor.Cyan; 
            System.Console.WriteLine("Digite sua opção: ");
            option = Convert.ToInt32(Console.ReadLine());
        
            switch(option){


                    case 1:
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO ADIÇÃO.......");
                    System.Console.WriteLine(" ");
                    Soma();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 2: 
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO SUBTRAÇÃO.......");
                    System.Console.WriteLine(" ");
                    Subtracao();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 3: 
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO MULTIPLICAÇÃO.......");
                    System.Console.WriteLine(" ");
                    Multiplicacao();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 4: 
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO DIVISÃO.......");
                    System.Console.WriteLine(" ");
                    Divisao();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 5:
                    Console.Clear();
                    System.Console.WriteLine("Calculadora fechada");
                    Environment.Exit(0);
                    break;

                    default :
                    Console.Clear();
                    System.Console.WriteLine("Valor inválido");
                    System.Console.WriteLine("Pressione qualquer tecla para voltar ao menu");
                    Console.ReadKey();
                    Menu();
                    break;


            }
        
       
    }

    public static void Soma(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1+num2;
        
        System.Console.WriteLine($"{num1} + {num2} = {result}");
    }

    public static void Subtracao(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1-num2;
        
        System.Console.WriteLine($"{num1} - {num2} = {result}");
    }

    public static void Multiplicacao(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1*num2;
        
        System.Console.WriteLine($"{num1} * {num2} = {result}");
    }

    public static void Divisao(){

        System.Console.WriteLine("Digite o primeiro valor:");
        float num1 = Convert.ToSingle(Console.ReadLine());

        System.Console.WriteLine("Digite o segundo valor");
        float num2 = Convert.ToSingle(Console.ReadLine());
    
        float result = num1/num2;
        
        System.Console.WriteLine($"{num1} / {num2} = {result}");
    }

}

    
