using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Abstractıon_
{
    abstract class Animal
    {

        protected String name;
        protected double weight;

        public Animal()
        {
            Console.WriteLine("Varsayılan hayvan");
        }

        public void Eat()
        {
            Console.WriteLine("Tüm hayvanlar yemek yiyebilir.");
        }

        public void Breath()
        {
            Console.WriteLine(" Tüm hayvanlar nefes alabilir.");
        }

        public /*abstract*/ void Growth()
        {
            Console.WriteLine("Tüm hayvanlar büyüme yeteneğine sahiptir.");
        }
    }

    abstract class Mammal : Animal       // Kalıtım
    {

        protected int teeth;
        protected String diafragma;
        protected int age;

        public Mammal()
        {
            Console.WriteLine("Varsayılan yapıcı");
        }

        public void Suckle()
        {
            Console.WriteLine("Memeli hayvanlar sütle beslenebilir.");
        }
    }

    abstract class Cat : Mammal     // Bir üst sınıftan kalıtım
    {

        protected String breed; 

        public Cat()
        {
            Console.WriteLine("Varsayılan kedi yapıcısı");
        }

        public virtual void About()
        {
            Console.WriteLine("Adlı kedi " + name);
            Console.WriteLine("Yaş: " + age);
        }
    }

    class Small : Cat
    {

        protected short height;

        public Small()
        {
            Console.WriteLine("Varsayılan yapıcı");
        }

        public override void About()       // Alt sınıflarda, üstteki soyut metotlar örtülür(overriding).
        {
            base.About();
            Console.WriteLine("Yüksklik: " + height + "см");
        }
    }



    public class Program
    {

        public static void Main(String[] args)
        {
            // Animal a = new Animal();
            // Animal a = new Mammal();
            // Animal a = new Cat();        //Kedi soyuttur somutlaştırılamaz.

            Animal a = new Small();
            a.Breath();
            a.Eat();
            a.Growth();
            // a.about();
        }

    }
};


