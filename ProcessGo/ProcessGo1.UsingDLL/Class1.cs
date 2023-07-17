using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcessGo1.UsingDLL
{
    public class Class1
    {
        public void UnsortedText()
        {
            string path = "C:\\Users\\Prince\\Desktop\\ProcessGo\\ProcessGo\\ProcessGo\\bin\\Debug\\UnsortedFile.txt";
            Process.Start(path);
        }
        public void SortedText()
        {
            string path2 = "C:\\Users\\Prince\\Desktop\\ProcessGo\\ProcessGo\\ProcessGo\\bin\\Debug\\SortedFile.txt";
            Process.Start(path2);
        }
    }
}
