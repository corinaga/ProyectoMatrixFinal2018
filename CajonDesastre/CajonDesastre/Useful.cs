﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajonDesastre
{
    class Useful
    {
        private static readonly Random r = new Random();
        private static readonly object syncLock = new object();

        public static int random_Number(int min, int max)
        {

            lock (syncLock)
            {
                return r.Next(min, max + 1);
            }
        }
    }
}