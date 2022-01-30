using System;

namespace CalcTrian {
    class Triangle {
        public double A;
        public double B;
        public double C;

        public double Area() {
            double p = (A + B + C) / 2.0;
            double raiz = Math.Sqrt(p * (A - p) * (B - p) * (C - p));
            return raiz;
        }

    }
}
