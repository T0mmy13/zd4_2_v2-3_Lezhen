using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zd4_2_v2_3_Lezhen;

namespace Quest3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] cord = FunctionalClassQuest3.ReadCoordinatesFromFile("input.txt");

            if (cord != null)
            {
                Console.WriteLine("dasda");
            }

            int x1m = cord[0], y1m = cord[1], x2m = cord[2], y2m = cord[3];
            int x1g = cord[4], y1g = cord[5], x2g = cord[6], y2g = cord[7];

            int leftM = Math.Min(x1m, x2m);
            int rightM = Math.Max(x1m, x2m);
            int bottomM = Math.Min(y1m, y2m);
            int topM = Math.Max(y1m, y2m);

            int leftD = Math.Min(x1g, x2g);
            int rightD = Math.Max(x1g, x2g);
            int bottomD = Math.Min(y1g, y2g);
            int topD = Math.Max(y1g, y2g);

            int areaM = (rightM - leftM) * (topM - bottomM);
            int areaG = (rightD - leftD) * (topD - bottomD);

            int intersectLeft = Math.Max(leftM, leftD);
            int intersectRight = Math.Min(rightM, rightD);
            int intersectBottom = Math.Max(bottomM, bottomD);
            int intersectTop = Math.Min(topM, topD);

            int intersectArea = 0;
            if (intersectRight > intersectLeft && intersectTop > intersectBottom)
            {
                intersectArea = (intersectRight - intersectLeft) * (intersectTop - intersectBottom);
            }

            int totalArea = areaM + areaG - intersectArea;

            File.WriteAllText("output.txt", totalArea.ToString());
            Console.ReadKey();
        }
    }
}
