using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LazyLoading.VirtualProxy
{
    public class RealImage : Image
    {
        private string filename;

        public RealImage(string filename)
        {
            this.filename = filename;

            Console.WriteLine("Creating very expensive object (real image: {0}).", filename);
            Thread.Sleep(8000);
            Console.WriteLine("Expensive object created in 8 seconds.");
        }

        public void Display()
        {
            Console.WriteLine("Image {0} displayed.", filename);
        }
    }
}
