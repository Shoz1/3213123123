using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3
{
    class Vector
    {
        double ax;
        double ay;
        double az;

        double bx;
        double by;
        double bz;

        double cx;
        double cy;
        double cz;

        public double GetLA()
        {
            double LA = Math.Abs(Ax) + Math.Abs(Ay) + Math.Abs(Az);

            return LA;
        }

        public double GetLB()
        {
            double LB = Math.Abs(Bx) + Math.Abs(By) + Math.Abs(Bz);

            return LB;
        }       

        public string GetScalar()
        {
            double SumX = Ax + Bx;

            double SumY = Ay + By;

            double SumZ = Az + Bz;

            return Convert.ToString(SumX) + " " + Convert.ToString(SumY) + " " + Convert.ToString(SumZ);          
        }

        public string GetVector()
        {
            double SumX = Ax * Bx;

            double SumY = Ay * By;

            double SumZ = Az * Bz;

            return Convert.ToString(SumX) + " " + Convert.ToString(SumY) + " " + Convert.ToString(SumZ);
        }

        public string GetD()
        {
      

            double ResultX = Ax * Bx;
            double ResultY = Ay * By;
            double ResultZ = Az * Bz;


            return "\n Вектор d = " + Convert.ToString(ResultX) + " "
                + Convert.ToString(ResultY) + " "
                + Convert.ToString(ResultZ) + " ";
        }

        public string GetC()
        {

            double SumX = Ax + Bx;

            double SumY = Ay + By;

            double SumZ = Az + Bz;

            double ResultX = SumX * Ax;
            double ResultY = SumY * Ay;
            double ResultZ = SumZ * Az;



            return "\n Вектор C = " + Convert.ToString(ResultX) + " "
                + Convert.ToString(ResultY) + " "
                + Convert.ToString(ResultZ) + " ";
        }

        public string ToString()        
        {
            return "\nДлина а : " + this.GetLA() + " " 
                + "\nДлина b : " + this.GetLB() + " ";
        }

        public string ToStringPlus()
        {
            return "\nСумма : " + this.GetScalar();
        }

        public string ToStringYmn()
        {
            return "\nСумма : " + this.GetVector();
        }
        
       

        public double Ax { get => ax; set => ax = value >= 0 ? value : 0; }
        public double Ay { get => ay; set => ay = value >= 0 ? value : 0; }
        public double Az { get => az; set => az = value >= 0 ? value : 0; }

        public double Bx { get => bx; set => bx = value >= 0 ? value : 0; }
        public double By { get => by; set => by = value >= 0 ? value : 0; }
        public double Bz { get => bz; set => bz = value >= 0 ? value : 0; }

        public double Cx { get => cx; set => cx = value >= 0 ? value : 0; }
        public double Cy { get => cy; set => cy = value >= 0 ? value : 0; }
        public double Cz { get => cz; set => cz = value >= 0 ? value : 0; }

    }
}
