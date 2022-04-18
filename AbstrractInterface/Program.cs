using System;

namespace AbstrractInterface
{
    class Program
    {
        static void Main(string[] args)
        {  //Sınıflara interfaceler üzerinden implement ettiğim metodları kullandım
            /*Car car1 = new Car();
            car1.go();
            car1.stop();

            Bike bike1 = new Bike();
            bike1.ride(); */

            
            //ABSTRACT KISMIN ÖRNEĞİ
            Kopek kopek1 = new Kopek();
            kopek1.Voice();
            Console.Read();






        }
    }
}
