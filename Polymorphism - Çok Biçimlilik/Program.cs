using System;

namespace Polymorphism___Çok_Biçimlilik
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Polymorphism - Çok Biçimlilik ne olduğunu tam anlaşılması zor gibi
             * burada olan kalıtım mantığı 
             * kalıtımda normalde base den türtilen class hem base hemde doğan class ın fonksiyonları kullanılır
             * fakat burada base den turetiken gene aynı türünden new ile oluşturuluyor 
             * biraz anlaşılması karışık 
             */
            BaseClass b = new BaseClass();
            TuretilmisClass t = new TuretilmisClass();
            b.yaz();
            b.oku();
            Console.WriteLine("-------------");
            t.oku();
            t.yaz();
            Console.WriteLine("-------------");
            /*buraya kadar heyşey normal
             * türetilem class ile base class içerisinde aynı fonksiyonlar var bunlarda isim hatası olduğundan 
             * virtual ve override kullanılarak hata ayıklaması yapılabilir yada new kullanılır
             * şimdi türetmeyi biraz daha değiştirelim
             */
            BaseClass x = new TuretilmisClass();
            x.oku();
            x.yaz();
            //Şimdi prob ile deneme yapalım
            Console.WriteLine("----------");
            A mx = new A();
            B nx = new B();
            mx.X = 10;
            nx.X = 15;
            nx.Y = 25;
            Console.WriteLine("----------");
            //Şimdi m referansı üzerinden hem X hem Y ulaşımı
            A m = new B();//Dikkat edilirse base class tipi ama oluşturulurken türetilen class türü ile oluşturuluyor 
            m.X = 30;
            ((B)m).Y = 35;//Bu şekilde tür değişimi ile ulaşılır


        }
        /*Burda fonlksiyonlaril deneme*/
        class BaseClass
        {
            virtual public void yaz()
            {
                Console.WriteLine("BaseClass Yaz Fonksiyonu");
            }
            virtual public void oku()
            {
                Console.WriteLine("BaseClass Oku Fonksiyonu");
            }
        }
        class TuretilmisClass : BaseClass
        {
            override public void yaz()
            {
                Console.WriteLine("TuretilmisClass Yaz Fonksiyonu");
            }
            override public void oku()
            {
                Console.WriteLine("TuretilmisClass Oku Fonksiyonu");
            }
        }
        /*Burada prob ile deneme*/
        class A
        {
            private int x;

            public int X
            {
                get { return x; }
                set
                {
                    Console.WriteLine("A class X={0}", value);
                    x = value;
                }
            }

        }
        class B : A
        {
            private int y;

            public int Y
            {
                get { return y; }
                set
                {
                    Console.WriteLine("B class Y={0}", value);
                    y = value;
                }
            }

        }
    }
}
