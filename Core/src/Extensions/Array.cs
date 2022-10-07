﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFusion.Extensions
{
    public static partial class ArrayExtensions {
        public static void EnsureLength<T>(ref T[] array, int length) where T : struct {
            if (array.Length < length)
                Array.Resize(ref array, length);
        }
    }
}
