using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrractInterface
{

    //Özetle soyutlama işlemidir.Diğer classlar bu classı base alırlar 
    //Örneğin alan hesabı yapan bir abs.sınıf düşünürsek üçgen kare vb şekiller bu classı
    //kullanacaklardır
    //Ancak alan hesaplamaları farklı olacağı için çektikleri metodu ezmeleri gerekmektedir.
  
    public abstract class Ses
    {
        //Örneğin Ses abstract classımı ve içerisindeki abstract metodu Her hayvan 
        //Farklı şekilde ezerek kullanır.
        public abstract void Voice();

    }

    public class Kedi : Ses
    {
        public override void Voice()
        {
            Console.WriteLine("MİYAV");
        }
    }

    public class Kopek : Ses
    {
        public override void Voice()
        {
            Console.WriteLine("HAV HAV");
        }


       
    }


  

}
