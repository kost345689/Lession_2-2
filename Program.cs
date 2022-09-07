// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

        
        Console.WriteLine("Введите числа");

        int number = Convert.ToInt32(Console.ReadLine());
         
         string numberText = Convert.ToString(number);

            if(numberText.Length > 2)
         
               {

                Console.WriteLine("третье число - >" + numberText[2]);

               }

            else 
              
              {

               Console.WriteLine("третье число нет");


              }





       
