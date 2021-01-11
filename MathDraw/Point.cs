﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDraw
{
    class Point
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Point()
        {
            new Point(0.0f, 0.0f, 0.0f);
        }

        public Point(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
