﻿using System;

namespace SquareEquationLib;

public class SquareEquation
{
    public static double[] Solve(double a, double b, double c)
    {
        double positive = double.PositiveInfinity;
        double negative = double.NegativeInfinity;
        double NaN = 0.0/0.0;
        if ((a==0) || (a==positive) || (a==negative) || (a==NaN))
        {
            throw new System.ArgumentException();
        }
        else if ((b==positive) || (b==negative) || (b==NaN))
        {
            throw new System.ArgumentException();
        }
        else if ((c==positive) || (c==negative) || (c==NaN))
        {
            throw new System.ArgumentException();
        }
        else
        {
            double D = Math.Sqrt(Math.Pow(b,2)-4*a*c);
            if(D>=0)
            {
                double x1 = -(b + Math.Sign(b)*D)/2;
                double x2 = c/x1;
                if(x1!=x2)
                {
                    double[] ans = new double[2]{x1,x2};
                    return ans;
                }
                else
                {
                    double[] ans = new double[1]{x1};
                    return ans;
                }
            }
            else
            {
                double[] ans = new double[]{};
                return ans;
            }
        }
    }
}
