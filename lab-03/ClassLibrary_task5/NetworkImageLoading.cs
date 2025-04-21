using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class NetworkImageLoader : IImageLoadingStrategy
    {
        public string Load(string source)
        {
            return $"[Зображення з мережі: {source}]";
        }
    }
}
