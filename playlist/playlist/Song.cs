using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace playlist
{
    public class Song
    {
        public string Title { get; set; }
        public string FilePath { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
