using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace PracticeWork
{
    public class ModelIDKeeper
    {
        public static int Keeper = 0;
        public static int QK = 0;
        public static int RK = 0;
        public static Dictionary <string,int> d =new Dictionary<string,int>();
        public static int cs = 0;
        public static GridView gridview = new GridView();
        public static void func() { }
    }
}