using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExtentionRepetition.Models
{
   public class Car
    {
        public static int Speed;    //= 360;
        
        public static int count = 0;
        static  Car()
        {
            // Speed = 500;
           //  Console.WriteLine(Speed);
        }

        public Car()
        {
            count++;
           
        }
      

        

        //public static void ShowSpeed()
        //{
        //    Console.WriteLine(Speed);
        //}


    }
}
