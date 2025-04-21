using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class FileImageLoader : IImageLoadingStrategy
    {
        public string Load(string source)
        {
            return $"[Локальне зображення: {source}]";
        }
    }
}
