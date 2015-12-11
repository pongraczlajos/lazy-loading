using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading.VirtualProxy
{
    public class VirtualProxyImage : Image
    {
        private string filename;
        private RealImage image;

        public VirtualProxyImage(string filename)
        {
            Console.WriteLine("Image virtual proxy created.");
            this.filename = filename;
        }

        public void Display()
        {
            Console.WriteLine("Virtual proxy image display.");

            if (image == null)
            {
                image = new RealImage(filename);
            }

            image.Display();
        }
    }
}
