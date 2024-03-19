namespace ejercicio4Fichero
{
    class program
    {
        public static void Main(String[] args) 
        {
            string ruta = "C:\\Users\\csi23-dmunnco\\Desktop\\doc.txt";

            Console.WriteLine("Introduzca el numero de una linea donde quiere insertar el texto");
            int numLinea = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca la posicion donde quiere insertar el texto");
            int posicion = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduzca el texto");
            string texto = Console.ReadLine();

            try
            {
                string [] leerTexto = File.ReadAllLines(ruta);

                if(numLinea >= 0 && numLinea <=  leerTexto.Length)
                {
                    string linea = leerTexto[numLinea -1];

                    if(posicion >= 0 && posicion <= leerTexto.Length)
                    {
                        string nuevaLinea = linea.Insert(posicion, texto);

                        leerTexto[numLinea - 1] = nuevaLinea;

                        File.WriteAllLines(ruta , leerTexto );

                        Console.WriteLine("El texto se ha escrito correctamente en la linea y posicion");

                    }
                    else
                    {
                        Console.WriteLine("La posicion especificada esta fuera de rango");
                    }
                }
                else
                {
                    Console.WriteLine("El numero de linea especificada esta fuera de rango");
                }



            }catch (Exception ex)
            {
                Console.WriteLine("Error al leer escribir el archivo: " +  ex.Message);
            }
            
        }
    }
}