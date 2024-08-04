using OOP6;

class Program
{
    public static void Main(string[] args)
    {
        //Base class'a bağlı türemiş sınıfı işaret ederek sınıfı tanımlıyorum ve parametresini tanımlarken "{}" işaretlerini kullanarak veriyorum
        AreaCalculation kare = new Square { Width = 5};
        //display methodu calculate methodunu çalıştırdıgı için otomatik hesaplayıp sonucu ekrana yazıyor.Calculate methodu türemiş sınıflarda override edilerek kendi özgü işlem modellerini alabiliyor
        kare.Display();
        Console.WriteLine("*********************");

        AreaCalculation dikdortgen = new Rectangle { Width = 4, Height = 5 };
        dikdortgen.Display();
        Console.WriteLine("**********************");

        AreaCalculation dikUcgen = new TriAngle { Width = 4, Height = 5 };
        dikUcgen.Display();
        Console.WriteLine("**********************");
    }
}