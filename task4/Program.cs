// По двум заданным числам проверять является ли одно квадратом другого

   
    
        Console.WriteLine("Введите 2 числа: ");
        int num1 = int.Parse(Console.ReadLine());
        
        int num2 = int.Parse(Console.ReadLine());

           if (num1 == num2 * num2) Console.WriteLine(num1 + " является " + num2 + " в квадрате");
           else if (num2 == num1 * num1) Console.WriteLine(num2 + " является " + num1 + " в квадрате");
           else Console.WriteLine("Не является");
    
