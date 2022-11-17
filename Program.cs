





using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encrypt
{
    class Program
    {

        static void Main(string[] args)
        {
            //aqui guardamos la variable del usario 
            int chair  = 0;
            //ciclo que no se dejara de ver hasta que ingrese una opcion
            while (chair  != 3)
               
            {
                Console.WriteLine("welcome to  Deciphering messages from NASA");
                Console.WriteLine("1 encrypt text");
                Console.WriteLine("2 decrypt text ");
                Console.WriteLine("3 return ");
                Console.WriteLine("enter an option");
                // si el usuario ingresa un valor invlalido
                try
                {
                    //validacion de la opcion ingresada 
                    
                    chair  = Convert.ToInt32(Console.ReadLine());
                    switch (chair )
                    {
                        case 1:
                            //encriptacion 
                            Encriptar();
                            break;
                        case 2:
                            //desencriptar
                            Desencriptar();
                            break;
                        case 3:
                            // salida
                            Console.WriteLine("congratulations message hacked successfully");
                            break;
                        default:
                            //mensaje de error si  ingresan una opcion eeronea
                            Console.WriteLine("sintax error ");
                            break;

                    }
                }
                catch (Exception)
                {
                    //mensaje de error si el usuario ingresan un valor incorrecto 
                    Console.WriteLine("tas tonto o que");
                }
            }
            // para evitar que se cierre la pantalla 
            Console.ReadKey();

            // encriptar 
            async static void Encriptar()
            {
                // EL ABECEDARIO 
                char[] abecedario = new char[26];
                char letters;
                int posicion = 0;
                //llenar el arreglo con el abecedario
                for (int R = 0; R < abecedario.Length; R++)
                {
                    letters = Convert.ToChar(R + 65);
                    abecedario [R] = letters;
                }
                //texto a encriptar
                Console.WriteLine("Ingrese el texto a encriptar");
                string text = Console.ReadLine();
                // texto a mayusculas
                text = text.ToUpper();
                //recorrer  letra por letra
                for (int R = 0; R < text.Length; R++)
                {
                    // la posicion de cada letra en el arreglo
                    for (int G = 0; G < abecedario .Length; G++)
                    {
                        if (text[G] == abecedario[G])
                        {
                            posicion = G + 1;
                            break;
                        }
                    }
                    //matriz auxiliar con la que se va multuplicar la matriz generada por el usuario
                    int[] grj = new int[] { 1, 3, 5, 7, 9 };
                    //multiplicar la matriz generada por el usuario por la matriz auxiliar
                    int resultado = posicion * grj [R % 5];
                    //guardar el resultado en un arreglo
                    int[] rj = new int[5];
                    rj[R % 5] = resultado;
                    //mostrar el resultado
                    Console.WriteLine(rj[R % 5] + " ");

                }
            }
            //Metodo de encriptar 
            async static void Desencriptar()
            {
                // digito  que va a ingresar
                Console.WriteLine("ewscrtiba el digito para desencriptar");
                //Variable para guardar los de numeros
                int numbers = 0;
                //si el usuario ingresa un valor invlalido
                try
                {
                    numbers  = Convert.ToInt32(Console.ReadLine());
                    //guardar los numeros que ingresa 
                    int[] numberstwo = new int[numbers ];
                    for (int G = 0; G < numberstwo.Length; G++)
                    {
                        Console.WriteLine("Ingrese el numero " + (G + 1));
                        numberstwo[G] = Convert.ToInt32(Console.ReadLine());
                    }
                    //desencriptar los numeros con la misma matriz 
                    int[] R = new int[] { 1, 3, 5, 7, 9 };
                    int ubicacion = 0;
                    for (int G = 0; G < numberstwo.Length; G++)
                    {
                        ubicacion = numberstwo[G] / R [G % 5];
                        Console.WriteLine(Convert.ToChar(ubicacion  + 64));
                    }
                }
                //mensaje de error
                catch (Exception)
                {
                    Console.WriteLine("sintax error");
                }
            }
        }
    }
}