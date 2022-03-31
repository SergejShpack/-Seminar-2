//  Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


        Console.WriteLine("Введите X координату, X ≠ 0: ");
        int X = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите  Y координату, Y ≠ 0: ");
        int Y = int.Parse(Console.ReadLine());
        
          if (X > 0 && Y > 0) Console.WriteLine("<I> четверть");
          else if (X < 0 && Y > 0) Console.WriteLine("<II> четверть");
          else if (X < 0 && Y < 0) Console.WriteLine("<III> четверть");
          else if (X > 0 && Y < 0) Console.WriteLine("<IV> четверть");        
    