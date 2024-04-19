
using Calculadora;

public class Program
{
    
    public static void Main()
    {

    try
    {
        Menu();

    }
    //Tratamento de exceção caso o usuario insira um valor inválido.
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
        }
       
    }

    // Menu de Opções 
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
                    Calculo.Soma();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 2: 
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO SUBTRAÇÃO.......");
                    System.Console.WriteLine(" ");
                    Calculo.Subtracao();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 3: 
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO MULTIPLICAÇÃO.......");
                    System.Console.WriteLine(" ");
                    Calculo.Multiplicacao();
                    System.Console.WriteLine(" ");
                    System.Console.WriteLine("Digite qualquer tecla para voltar ao menu");
                    Console.ReadLine();
                    Menu();
                    break;

                    case 4: 
                    Console.Clear();
                    System.Console.WriteLine("CALCULANDO DIVISÃO.......");
                    System.Console.WriteLine(" ");
                    Calculo.Divisao();
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
}

    
