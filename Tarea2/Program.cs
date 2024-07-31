using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.- Escriba un programa que a partir de tres valores enteros pedidos al usuario calcule su suma y su media
            
            // Da la indicación al usuario
            Console.WriteLine("Ingrese 3 numeros");
            // Solicita que ingrese un numero el usuario
            Console.Write("Ingrese 1er numero: ");
            // Usuario puede ingresar un número
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese 2do numero: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese 3er numero: ");
            int num3 = int.Parse(Console.ReadLine());

            // Se realiza la operación de suma
            int suma = num1 + num2 + num3;
            // Se realiza la operacion para calcular la media
            float media = suma / 3f;

            // Se imprime el resultado de la suma y la media
            Console.Write($"La suma es: {suma}; Y su media es: {media}");

            //  Pausa para ver resultados
            Console.ReadKey();
            */

            /*
             * 2.- Escriba un programa que calcule las raíces de una ecuación de segundo grado cuyos coeficientes son a, b y c. 
             * Utilice el método matemático Sqrt de la clase Math del espacio de nombres System, que calcula la raíz cuadrada 
             * de un número que no puede ser negativo y aplicable sobre un tipo de dato double
            
            // Indicaciones al usuario
            Console.WriteLine("Por favor ingrese los valores de los coeficientes");
            // Se le indica al usuario que ingrese el valor de un coeficiente
            Console.Write("Ingrese el valor del coeficiente a: ");
            // Usuario ingresa valor
            double a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del coeficiente b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor del coeficiente c: ");
            double c = double.Parse(Console.ReadLine());

            // Formula para calcular el discriminante
            double discriminante = Math.Pow(b, 2) - 4 * (a * c);

            // Condición si el discriminante es positivo se realiza el calculo de la ecuación
            if (discriminante > 0) {
                double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"El resultado de la ecuacion es: x1 = {x1} y x2 = {x2}");
            } 
            // Si no cumple la condición, se imprime "La raiz es negativa"
            else
            {
                Console.WriteLine("La raiz es negativa");
            }
            // Pausa para ver resultados
            Console.ReadKey();
            */

            /*
             * 3.- Escriba un programa que represente una pequeña calculadora. Para ello, el programa pedirá dos números 
             * enteros y una operación aritmética (que debe ser +, -, * o /) y mostrará el resultado correspondiente 
            
            // Se solicita 1er número al usuario
            Console.Write("Ingrese el 1er número: ");
            // Usuario puede ingresar 1er valor
            int num1 = int.Parse(Console.ReadLine());
            // Se solicita 2do número al usuario
            Console.Write("Ingrese el 2do número: ");
            // Usuario puede ingresar 2do valor
            int num2 = int.Parse(Console.ReadLine());

            // Se le indica al usuario que operació puede escoger; \n: salto de linea
            Console.WriteLine(" Escoja una operación: \n" +
                " Suma \n" +
                " Resta \n" +
                " Multiplicacion \n" +
                " Division");
            // Se le indica al usaurio que ya colocar la operación escogida
            Console.Write("Coloque su operación: ");
            // Usuario coloca la operación
            string opcion = Console.ReadLine();

            // Variable para almacenar el resultado
            double resultado = 0;

            // Ejecuta la operación basada en los valores en la entrada del usuario
            switch (opcion.ToLower()) {

                case "suma":
                    resultado = num1 + num2;
                    Console.WriteLine($"El resultado de la suma es {resultado}");
                    break;

                case "resta":
                    resultado = num1 - num2;
                    Console.WriteLine($"El resultado de la resta es {resultado}");
                    break;

                case "multiplicacion":
                    resultado = num1 * num2;
                    Console.WriteLine($"El resultado de la multiplicación es {resultado}");
                    break;

                case "division":
                    // Condiciona si el denominador en este caso num2 = 0, imprime error
                    if (num2 != 0)
                    {
                        resultado = (double)num1 / num2;
                        Console.WriteLine($"El resultado de la división es {resultado}");
                    }
                    else {
                        Console.WriteLine("Error no se puede dividir para cero");
                    }
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Console.ReadLine();
            */

            /*
             * 4.- Desarrolla un programa que solicite al usuario su peso y altura, y luego calcule 
             * su índice de masa corporal (IMC) para clasificar su estado de peso 
            
            // Indica al usuario que se va a calcular el IMC
            Console.WriteLine("Calculo de la masa corporal");
            // Solicita al usuario que ingrese los valores de peso y altura
            Console.Write("Ingrese su peso en kilogramos: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Ingrese su altura en metros: ");
            double altura = double.Parse(Console.ReadLine());

            // Formula para calcular la IMC
            double IMC = peso / Math.Pow(altura, 2);

            // Condición para que el usuario coloque numeros positivos
            if (peso > 0 && altura > 0)
            {
                // Condición para que el programa le indique su IMC y su descripción
                if (IMC < 18.5) 
                {
                    Console.WriteLine($"Su IMC es {IMC}. Tiene bajo peso");            
                }
                else if (IMC >= 18.5 && IMC < 25) 
                {
                    Console.WriteLine($"Su IMC es {IMC}. Tiene peso adecuado");
                }
                else if (IMC >= 25 && IMC < 30)
                {
                    Console.WriteLine($"Su IMC es {IMC}. Tiene sobrepeso");
                }
                else if (IMC >= 30 && IMC < 35)
                {
                    Console.WriteLine($"Su IMC es {IMC}. Tiene obesidad grado 1");
                }
                else if (IMC >= 35 && IMC < 40)
                {
                    Console.WriteLine($"Su IMC es {IMC}. Tiene obesidad grado 2");
                }
                else
                {
                    Console.WriteLine($"Su IMC es {IMC}. Tiene obesidad grado 3");
                }
            }
            else {
                Console.WriteLine("Ingrese valores positivos");
            }
            Console.ReadLine();
            */

            /*
             * 5.- Crea un programa que reciba la calificación numérica de un estudiante y muestre la letra 
             * equivalente de la calificación (A, B, C, D, F) utilizando sentencias if.
            
            // Indicación al usuario de su letra equivalente
            Console.WriteLine("Calificación númerica = Su letra equivalente\n" +
                "De 100 a 90 = A\n" +
                "Menor de 90 a 80  = B\n" +
                "Menor de 80 a 70 = C\n" +
                "Menor de 70 a 60 = D\n" +
                "Menor de 60 = F");
            // Solicitud al usaurio que ingrese su califiación
            Console.WriteLine("Por favor ingrese su calificación: ");
            float calificacion = float.Parse(Console.ReadLine());

            // Condición al usuario que la califación de estar en los valores de 0 a 100
            if (calificacion >= 0 && calificacion <= 100)
            {
                // Condición que indica al usuario cual es su letra equivalente
                if (calificacion >= 90 && calificacion <= 100) {
                    Console.WriteLine("Su letra equivalente es A");
                }
                else if (calificacion >= 80 && calificacion < 90)
                {
                    Console.WriteLine("Su letra equivalente es B");
                }
                else if (calificacion >= 70 && calificacion < 80)
                {
                    Console.WriteLine("Su letra equivalente es C");
                }
                else if (calificacion >= 60 && calificacion < 70)
                {
                    Console.WriteLine("Su letra equivalente es D");
                }
                else
                {
                    Console.WriteLine("Su letra equivalente es F");
                }
            }
            else
            {
                Console.WriteLine("Ingrese valores del 0 al 100");
            }
            Console.ReadLine();
            */

            /*
             * 6.- Escribe un programa que solicite al usuario un número que represente un día de la semana 
             * (1 para lunes, 2 para martes, etc.) y muestre el nombre completo del día correspondiente
             
            // Información para el usuario
            Console.WriteLine("Número = Día\n" +
                " 1 = Lunes\n" +
                " 2 = Martes\n" +
                " 3 = Miercoles\n" +
                " 4 = Jueves\n" +
                " 5 = Viernes\n" +
                " 6 = Sabado\n" +
                " 7 = Domigo");
            // Se solicita al usuario que ingrese un valor
            Console.Write("Ingrese un número del 1 al 7: ");
            int dia = int.Parse(Console.ReadLine());

            // Condición al usuario que solo puede ingresar valores del 1 al 7
            if (dia >= 1 && dia <= 7)
            {
                // Condición para que se imprima el día que el usuario escogio
                if (dia == 1)
                {
                    Console.WriteLine("Lunes");
                }
                else if (dia == 2)
                {
                    Console.WriteLine("Martes");
                }
                else if (dia == 3)
                {
                    Console.WriteLine("Miercoles");
                }
                else if (dia == 4)
                {
                    Console.WriteLine("Jueves");
                }
                else if (dia == 5)
                {
                    Console.WriteLine("Viernes");
                }
                else if (dia == 6)
                {
                    Console.WriteLine("Sabado");
                }
                else
                {
                    Console.WriteLine("Domingo");
                }
            }
            else {
                Console.WriteLine("Error debe ingresar un número del 1 al 7");
            }
            Console.ReadKey();
            */

            /*
             * 7.- Crea un programa que simule un cajero automático. El programa debe solicitar al usuario 
             * la cantidad de dinero que desea retirar y verificar si tiene saldo suficiente. Si tiene 
             * saldo suficiente, se debe realizar la operación y actualizar el saldo. 
            
            Console.WriteLine("Cajero Automatico");
            // Se define el saldo inicial del usuario
            int saldoInicial = 1000;
            // Se solicita al usuario que ingrese el valor a retira
            Console.Write("Ingrese el valor a retirar: $");
            int retiro = int.Parse(Console.ReadLine());

            // Se define una variable para almacenar el nuevo saldo despues de retiro
            int nuevoSaldo = 0;

            // Condiciona si el saldo inicial es suficiente para realizar el retiro
            if (saldoInicial >= retiro) {
                // Se calcula el valor del nuevo saldo
                nuevoSaldo = saldoInicial - retiro;
                Console.WriteLine($"Su saldo inicial es: ${saldoInicial}\n" + 
                    $"Su retiro es: ${retiro}\n" + 
                    $"Su saldo actual es: ${nuevoSaldo}\n" +
                    $"Gracias por su visita :)");
            }
            // Si el saldo es insuficiente, se muestra el mensaje
            else
            {
                Console.WriteLine("Saldo insuficiente para realizar el retiro");
            }
            Console.ReadKey();
            */

            /*
             * 8.- Escribe un programa que genere un número aleatorio entre 1 y 100 y le pida al usuario 
             * que adivine el número. El programa debe dar pistas al usuario (mayor que, menor que, igual) 
             * hasta que logre adivinar el número correcto. 

            // Se genera una instancia de la clase Random para generar números aleatorios
            Random random = new Random();

            // Genera números aleatorios de 1 a 100
            int numSecreto = random.Next(1, 101);

            // Variable para almacernar la suposición del usaurio
            int suposicion = 0;

            // Mensaje inicial para el usuario
            Console.WriteLine("Adivina el número que he generado del 1 al 100");

            // Bucle para solicitar la adivinanza hasta que el usuario acierte
            while (suposicion != numSecreto) {
                // Se solicita al usuario que ingrese el numero
                Console.WriteLine("Ingresa el número que crees que genere: ");
                suposicion = int.Parse(Console.ReadLine());

                // Comparar la suposición del usuario con el número secreto
                if (suposicion > numSecreto)
                {
                    Console.WriteLine("El número secreto es menor que " + suposicion);
                }
                else if (suposicion < numSecreto)
                {
                    Console.WriteLine("El numero secreto es mayor que " + suposicion);
                }
                else
                {
                    Console.WriteLine("Felicidades, has adivinado! El número secreto es: " + suposicion);
                }
            }
            Console.ReadKey();
            */

            /*
             * 9.- Escribe un programa que solicite al usuario su edad y determine si tiene la edad suficiente para votar 
             * utilizando sentencias if. El programa debe mostrar un mensaje indicando si el usuario puede votar o no.
             
            // Mensaje al usuario
            Console.WriteLine("Averigua si tienes edad para botar? :o");
            // Se solicita al usuario que ingrese su edad
            Console.WriteLine("Por favor ingresa tu edad");
            int edad = int.Parse(Console.ReadLine());
            // Condicion para saber si el usuario puede votar
            if (edad >= 18)
            {
                Console.WriteLine("Felicidades puedes votar :)");
            }
            else
            {
                Console.WriteLine("Lo siento todavia no puedes votar :(");
            }
            Console.ReadKey();
            */

        } // fin static void Main
    }
}
