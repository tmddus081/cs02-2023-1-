﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_bmi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight, height;

            Console.Write("키(cm): ");
            height = double.Parse(Console.ReadLine());

            Console.Write("체중(kg): ");
            weight = double.Parse(Console.ReadLine());

            double bmi = weight / (height / 100 * height / 100);
            Console.Write("BMI = " + bmi);
        }
    }
}
