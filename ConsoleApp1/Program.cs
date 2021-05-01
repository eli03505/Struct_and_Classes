using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_and_Classes
{
    #region TASK1
    //class Field
    //{
    //    public int X { get; set; }
    //    public int Y { get; set; }

    //    public void Show()
    //    {
    //        Console.WriteLine($"X: {X}\nY: {Y}");
    //    }
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Field field = new Field
    //        {
    //            X = 50,
    //            Y = 80
    //        };
    //        field.Show();
    //    }
    //}
    #endregion

    #region
    class Meter
    {
        public int min { get; set; }
        public int max { get; set; }
        public int current_data { get; set; }
        public void Incerement()
        {
            if (current_data == max)
            {
                current_data = 0;
                current_data++;
            }
            else
            {
                current_data++;
            }
        }
        public void Show()
        {
            Console.Clear();
            Console.WriteLine($"Current data : {current_data}");
            System.Threading.Thread.Sleep(100);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Meter meter = new Meter
            {
                min = 0,
                current_data = 99,
                max = 101
            };
            while (true)
            {
                meter.Incerement();
                meter.Show();
            }
        }
    }
    #endregion
}