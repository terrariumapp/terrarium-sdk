//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

using System;

namespace Terrarium.Sdk.Classes.Helpers
{
    /// <summary>
    ///     Slimmed down copy of the Point structure from System.Drawing (so we don't have the SDK reference System.Drawing).
    ///     Represents an ordered pair of integer x- and y-coordinates that defines a point in a two-dimensional plane.
    /// </summary>
    [Serializable]
    public class Point
    {
        /// <summary>
        /// Represents a Point that has X and Y values set to zero.
        /// </summary>
        public static readonly Point Empty = new Point();

        private int _x;
        private int _y;

        /// <summary>
        /// Initializes a new instance of the Point class.
        /// </summary>
        public Point()
        {
        }

        /// <summary>
        /// Initializes a new instance of the Point class with the specified coordinates.
        /// </summary>
        /// <param name="x">The horizontal position of the point.</param>
        /// <param name="y">The vertical position of the point.</param>
        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        /// <summary>
        /// Gets a value indicating whether this Point is empty.
        /// </summary>
        /// <returns>
        /// true if both X and Y are 0; otherwise, false.
        /// </returns>
        public bool IsEmpty
        {
            get { return _x == 0 && _y == 0; }
        }

        /// <summary>
        /// Gets or sets the x-coordinate of this Point.
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Gets or sets the y-coordinate of this Point.
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}