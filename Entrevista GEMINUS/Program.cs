using System;

internal class Program
{
    private static void Main(string[] args)
    {

        //PrimerEjercicio();
        //SegundoEjercicio();

    }

    private static void SegundoEjercicio()
    {
        int[] myArray = new int[] { 1, 2, -1, 1, 0, 1, 2, -1, -1, -2 };
        char[,] tablero = new char[4, 4];
        int posicionX = 0;
        int posicionY = 0;
        
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                tablero[i, j] = 'O';
            }
        } 

        for (int i = 0; i < myArray.Length - 1; i += 2)
        {
            if (i > 0)
            {
                posicionX += myArray[i];
                posicionY += myArray[i + 1];
            }
            else
            {
                posicionX = myArray[i];
                posicionY = myArray[i + 1];
            }
        }

        // Seteamos el valor iniciales de la X que se dibuja.
        tablero[posicionX, posicionY] = 'X';

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(tablero[i, j]);
            }
            Console.WriteLine();
        }
    }

    private static void PrimerEjercicio()
    {
        int cellsNumber = 5;
        Console.WriteLine("Ingrese las cantidades de casillas");
        int input = Convert.ToInt32(Console.ReadLine());

        // Se evalua si el valor ingresado se encuentra entre 1 y 10, para setearle el nuevo valor a cellsNumber.
        if (input >= 1 && input <= 10)
            cellsNumber = input;

        for (int i = 1; i <= cellsNumber; i++)
        {
            for (int j = 1; j <= cellsNumber; j++)
            {
                string printValue = (i + j) % 2 == 0 ? "X" : "_";

                Console.Write(printValue);
            }
            Console.WriteLine();
        }
    }
}