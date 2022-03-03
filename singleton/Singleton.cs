﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private static Singleton INSTANCE = new Singleton();

        public int Value = 0;

        private Singleton() { }

        public static Singleton Instance { get { return INSTANCE; } }
    }
}
