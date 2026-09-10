namespace AdivinaNumero
{
    public class AdivinaNumero
    {
        public static int Numero {get;set;}
        public static int Contador {get;set;}
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int NumeroAleatorio = rnd.Next(1,101);
            Contador = 10;
            Console.WriteLine("ADIVINA EL NÚMERO");
            Console.WriteLine("-----------------");

            while(Contador > 0)
            {
                try
                {
                    Console.Write("Numero: ");
                    Numero = Convert.ToInt32(Console.ReadLine());
                    if(Numero > NumeroAleatorio)
                    {
                        Console.WriteLine("El número es MENOR");
                        Contador --;
                        Console.WriteLine($"Vida: {Contador} \n");
                    }

                    else if(Numero < NumeroAleatorio)
                    {
                        Console.WriteLine("El número es MAYOR");
                        Contador --;
                        Console.WriteLine($"Vida: {Contador} \n");
                    }

                    else
                    {
                        Console.WriteLine("¡LE ATINASTE!");
                        break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("ERROR: Escoge un número válido \n");
                }
            }

            if(Contador == 0)
            {
                Console.WriteLine($"PERDISTE JAJAJA el número era {NumeroAleatorio}");
            }

        }
    }
}