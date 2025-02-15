﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationsWithStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            NonStaticClass instance1 = new NonStaticClass(1);
            NonStaticClass instance2 = new NonStaticClass(2);

            instance1.Method();
            instance2.Method();

            NonStaticClass.field = 1;

            instance1.Method();
            instance2.Method();

            Console.WriteLine(StaticConstructor.field);

            AbstractClass instance = AbstractClass.CreateObject();
            instance.Method();

        }
    }
}
