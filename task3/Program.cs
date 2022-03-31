// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

    
    
        Console.WriteLine("введите номер дня недели: ");
       
        int number = int.Parse(Console.ReadLine());

           if (number == 6 || number == 7) Console.WriteLine("Выходной");
       
           else Console.WriteLine("Будний день");

