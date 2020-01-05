using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIAutomationExecise.Utils
{
    public class CommonMethods
    {
        private static readonly string path =
           Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.FullName;

        public static String GetFolderPath(String foldername)
        {
            return path + "//" + foldername;
        } 
    }
}
