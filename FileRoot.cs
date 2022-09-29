using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class FileRoot
    {
        public static string fileRoot = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.ToString();
    }
}