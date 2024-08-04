using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace OOP6
{
    //Base class
    public abstract class AreaCalculation
    {
        public double Width { get; set; }
        public double Height { get; set; }


        public virtual double Calculate()
        {
            return 0;
        }
        //Sonucu Yazdırmak için Ana Method
        public void Display()
        {
            Console.WriteLine($"Alan Sonucu : {Calculate()}");
        }

    }
    //Türemiş Sınıf
    //derived class
    public class Square : AreaCalculation
    {
        public override double Calculate()
        {
            return Width * Width;
        }
       
    }//End Class Square

    //Türemiş Sınıf
    //derived class
    public class Rectangle : AreaCalculation
    {
        public override double Calculate()
        {
            return Width * Height;
        }
    }//End Class Rectangle

    //Türemiş Sınıf
    //derived class
    public class TriAngle : AreaCalculation
    {
        public override double Calculate()
        {
            return (Width * Height) / 2;
        }
    }//End Class TriAngle
}
