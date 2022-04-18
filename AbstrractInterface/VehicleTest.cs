using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrractInterface
{
    /*
     -interfaceler arayüzlerdir ve içerisinde sözleşme benzeri yapılar barındırırlar
     -Banka örneğini verecek olursak Hesap açmak için belirli bir miktar para koymanız gereklidir
   ancak işlem detaylarını burada belirtemezsiniz
     -Araç örneği üzerinden gidecek olursak;
    *Gitme Durma
    *Uçabilme
    *Binilebilme 
     Gibi durumlar benim sözleşmelerimdir İçerisindeki metodların tamamını
     bu interfacei secen her class sağlamak zorundadır.Sözleşmeler içerisinde kod barındıramaz
    ancak implement eden classda işlemler gerçekleştirebilir.
   
     */


   public interface IVehicleTest
    {
        void go();
        void stop();
     }



    public interface IRideable
    {
        void ride();

     }

    public interface Iflyable
    {
        void soar();

    }

    //Araba sınıfı taşıt arayüzünü implement ederek içerisndeki bütün metodlara(sözleşmelere)
    //ulaşıp kullanabilir
    //!!!İmplement edilen sözleşmelerin tamamını karşılamak zorundadır.
    public class Car : IVehicleTest
    {
        public void go()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }
    }
    //Bisiklet sınıfı bu arayüzlerden birden fazlasına uymaktadır
    public class Bike : IVehicleTest, IRideable
    {
        public void go()
        {
            throw new NotImplementedException();
        }

        public void ride()
        {
            throw new NotImplementedException();
        }

        public void stop()
        {
            throw new NotImplementedException();
        }

        //Porche'un bir sınıf olduğunu düşünürsek birçok farklı interfacei 
        //ve bu interfaceler içindeki sayısız metodu tek ve hızlı bir seferde gereksiz
        //kod kullanımlarından da kaçınarak kullanabilmemize olanak sağlar 
    }

}
