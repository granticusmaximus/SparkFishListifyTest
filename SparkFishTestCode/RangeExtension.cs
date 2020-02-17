﻿using System;
using System.Collections.Generic;

namespace SparkFishTestCode
{
    public static class EnumerableHelpers
    {
        public static void AddRange<T>(this IList<T> collection, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                collection.Add(item);
            }
        }
    }
}
