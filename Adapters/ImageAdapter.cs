using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Adapters
{
    public class ImageAdapter: IImageAdapter
    {
        public string GenerateDog()
        {
            return "https://images.dog.ceo/breeds/hound-afghan/n02088094_2458.jpg";
        }
    }
}
            