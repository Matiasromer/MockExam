using MockExamBoxVolume;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxVolumeConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 client = new Service1();
            string line = Console.ReadLine();
            string myline = Console.ReadLine();

            while (!line.Trim().ToLower().Equals("stop"))
            {
                Console.WriteLine("Choose Option: get volume, get side ");
                myline = Console.ReadLine().Trim() ?? "";
                if (myline.ToLower().Equals("get volume"))
                {
                    double length;
                    double height;
                    double width;

                    Console.WriteLine("length");
                    string templength = Console.ReadLine();
                    length = Double.Parse(templength);

                    Console.WriteLine("height");
                    string tempheight = Console.ReadLine();
                    height = Double.Parse(tempheight);

                    Console.WriteLine("width");
                    string tempwidth = Console.ReadLine();
                    width = Double.Parse(tempwidth);

                    Console.WriteLine("Resulatet er " + client.GetVolume( length, height, width));

                    

                }
                if (myline.ToLower().Equals("get side"))
                {

                    double volume;
                    double side1;
                    double side2;

                    Console.WriteLine("volume");
                    string tempvolume = Console.ReadLine();
                    volume = Double.Parse(tempvolume);

                    Console.WriteLine("side1");
                    string tempside1 = Console.ReadLine();
                    side1 = Double.Parse(tempside1);

                    Console.WriteLine("side2");
                    string tempside2 = Console.ReadLine();
                    side2 = Double.Parse(tempside2);

                    Console.WriteLine("Resulatet er " + client.GetSide(volume, side1, side2));

                }
            }
        }
    }
}
