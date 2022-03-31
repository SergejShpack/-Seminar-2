// Показать числа от -N до N

Console.WriteLine("Введите число: ");
       
        int number = int.Parse(Console.ReadLine());
       
        int i = -number;

        while (i <= number) Console.Write(i++ + " ");
    