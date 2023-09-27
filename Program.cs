using PROCESSOR;
using VGA;
using LAPTOP;

class Program
{
    static void Main(string[] args)
    {
        Laptop laptop1 = new Laptop();
        laptop1 = new Vivobook();
        laptop1.vga = new Vga.Nvidia();
        laptop1.processor = new CoreI5();

        Laptop laptop2 = new Laptop();
        laptop2 = new IdeaPad();
        laptop2.vga = new Vga.AMD();
        laptop2.processor = new Ryzen();

        Predator predator = new Predator();
        predator = new Predator();
        predator.vga = new Vga.AMD();
        predator.processor = new CoreI7();

        //no1
        laptop2.LaptopDinyalakan();
        laptop2.LaptopDimatikan();

        //no2
        laptop1.Ngoding();
        Console.WriteLine("Ctak Ctak Ctak, error lagi!!");

        //no3
        Console.WriteLine(laptop1.vga.merk);
        Console.WriteLine(laptop1.processor.merk);
        Console.WriteLine(laptop1.processor.tipe);

        //no4
        predator.BermainGame();

        //no5
        ACER acer = new ACER();
        acer = new Predator();
        acer.BermainGame();
    }
}

//processor
namespace PROCESSOR
{
    public class Processor
    {
        public string merk;
        public string tipe;

        public Processor(string merk, string tipe)
        {
            this.merk = merk;
            this.tipe = tipe;
        }
    }

    public class Intel : Processor
    {
        public Intel(string tipe) : base("Intel",tipe)
        { }
    }

    public class AMD : Processor
    {
        public AMD(string tipe) : base("AMD", tipe)
        { }
    }

    public class CoreI3 : Intel
    {
        public CoreI3() : base("Core i3")
        { }
    }

    public class CoreI5 : Intel
    {
        public CoreI5() : base("Core i5")
        { }
    }

    public class CoreI7 : Intel
    {
        public CoreI7() : base("Core i7")
        { }
    }

    public class Ryzen : AMD
    {
        public Ryzen() : base("RAYZEN")
        { }
    }

    public class Athlon : AMD
    {
        public Athlon() : base("ATHLON")
        { }
    }
}

//vga
namespace VGA
{
    public class Vga
    {
        public string merk;
    
       public class Nvidia : Vga
        {
            public Nvidia()
            {
                merk = "Nvidia";
            }
        }

        public class AMD : Vga
        {
            public AMD()
            {
                merk = "AMD";
            }
        }
    }
}

//laptop
namespace LAPTOP
{
    public class Laptop
    {
        public string merk;
        public string tipe;
        public Vga vga;
        public Processor processor;

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {merk} {tipe} mati");
        }
    }

    public class ASUS : Laptop
    {
        public ASUS()
        {
            merk = "ASUS";
        }
    }

    public class ACER : Laptop
    {
        public ACER()
        {
            merk = "ACER";
        }
    }

    public class Lenovo : Laptop
    {
        public Lenovo()
        {
            merk = "Lenovo";
        }
    }

    public class ROG : ASUS
    {
        public ROG()
        {
            tipe = "ROG";
        }
    }

    public class Vivobook : ASUS
    {
        public Vivobook()
        {
            tipe = "Vivobook";
        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, error lagi!!");
        }
    }

    public class Swift : ACER
    {
        public Swift()
        {
            tipe = "Swift";
        }
    }

    public class Predator : ACER
    {
        public Predator()
        {
            tipe = "Predator";
        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
        }
    }

    public class IdeaPad : Lenovo
    {
        public IdeaPad()
        {
            tipe = "IdeaPad";
        }
    }

    public class Legion : Lenovo
    {
        public Legion()
        {
            tipe = "Legion";
        }
    }
}