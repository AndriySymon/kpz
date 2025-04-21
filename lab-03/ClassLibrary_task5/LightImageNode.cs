using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task5
{
    public class LightImageNode : LightNode
    {
        public string Source { get; }
        public IImageLoadingStrategy LoaderStrategy { get; }

        public LightImageNode(string source, IImageLoadingStrategy loaderStrategy)
        {
            Source = source;
            LoaderStrategy = loaderStrategy;
        }

        public override string OuterHTML => $"<img src=\"{Source}\" />";
        public override string InnerHTML => LoaderStrategy.Load(Source);
    }
}
