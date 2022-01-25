using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fotoStudio
{
    class infoTransfer
    {
        public static string picturePath;
        public static string username;
        public static string comm;
        public static string info;
        public static float price;
        public static float length;
        private static string _photoComment;
        private static string[] _fullComm = new string[100];
        public static bool isSelected;
        public static int slcCount = 0;
        public static string table = "";

        public static string PhotoComment { get => _photoComment; set => _photoComment = value; }
        public static string[] FullComm { get => _fullComm; set => _fullComm = value; }
    }
}
