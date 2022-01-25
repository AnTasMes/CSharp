using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotoStudio
{
    class imageInfo
    {
        private static string[] comment = new string[237476]; //Ovo je nasumican broj izveden kako bi bio veci od moguceg broja fotografija za niz

        public static string[] Comment { get => comment; set => comment = value; }
    }
}
