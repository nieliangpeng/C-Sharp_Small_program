using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TESTCSHARP3
{
   
        public static class TS
        {
            public static float Trunk_Size = 5f;
            public static double Trunk_Length = 100d;

            public static int Branch_Num = 10; //递归次数
            public static double Branch_Angle = 25 * Math.PI / 180; //弧度;
            public static double Coff_Len = 1d; //两子树的长度差系数
            public static double Coff_Ang = 1d;
            public static double Coff_Pos = 1d; //两子树的位置的系数K
            public static double Coff_SubT = 0.8d; //主干

            public static Color Color;
            public static int Color_Mode = 1;
            public static int Color_R = 111;
            public static int Color_G = 222;
            public static int Color_B = 111;
            public static bool R;
            public static bool G;
            public static bool B;

            public static bool Random = true;
        }
    }
