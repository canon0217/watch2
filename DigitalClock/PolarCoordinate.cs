using System;
using System.Drawing;

namespace DigitalClock
{
    class PolarCoordinate
    {
        private readonly double _radian;
        private readonly float _radius;

        public PolarCoordinate(double radian, float radius)
        {
            this._radian = radian;
            this._radius = radius;
        }

        private static PolarCoordinate _center = new PolarCoordinate(0, 0);
        public static PolarCoordinate Center => _center;

        internal PointF ToEuClid()
        {
            return new PointF((float)(_radius * Math.Cos(_radian)), -(float)(_radius * Math.Sin(_radian)));
        }
    }
}
