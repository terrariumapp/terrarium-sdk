//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

using System;
using Terrarium.Sdk.Classes.Helpers;

namespace Terrarium.Sdk.Classes.Creature
{
    /// <summary>
    ///     <para>
    ///         Used to define a vector along which creatures can move.  The vector
    ///         encompasses both destination and speed.
    ///     </para>
    /// </summary>
    [Serializable]
    public class MovementVector
    {
        private readonly Point _destination;
        private readonly int _speed;

        /// <summary>
        ///     <para>
        ///         Used to define a vector along which creatures can move.  The vector
        ///         encompasses both destination and speed.
        ///     </para>
        /// </summary>
        /// <param name="destination">
        ///     System.Point representing the location in the world to move to.
        /// </param>
        /// <param name="speed">
        ///     The speed at which to move.
        /// </param>
        /// <exception cref="System.ApplicationException">
        ///     Thrown if speed is less than 2.  Also thrown if destination is empty and speed is not 0.
        /// </exception>
        public MovementVector(Point destination, int speed)
        {
            // Speed must be greater than 1 because if it is 1, then roundoff causes the animal not to move at all
            // when they are moving one unit on a grid and they aren't moving exactly left/right or up/down
            if (speed < 2)
            {
                throw new ApplicationException("Speed must be positive and > 1.");
            }

            if (!destination.IsEmpty)
            {
                _destination = new Point(destination.X, destination.Y);
            }
            else
            {
                if (speed != 0)
                {
                    throw new ApplicationException("Speed must be zero if destination is empty");
                }
                _destination = Point.Empty;
            }

            _speed = speed;
        }

        /// <summary>
        ///     <para>
        ///         Used to determine the destination location for this MovementVector.
        ///     </para>
        /// </summary>
        /// <returns>
        ///     System.Point representing the destination for this MovementVector.
        /// </returns>
        public Point Destination
        {
            // Point is not immutable
            get
            {
                if (_destination.IsEmpty)
                {
                    return Point.Empty;
                }
                return new Point(_destination.X, _destination.Y);
            }
        }

        /// <summary>
        ///     <para>
        ///         Used to determine the speed defined for this MovementVector
        ///     </para>
        /// </summary>
        /// <returns>
        ///     System.Int32 representing the speed of movement for this MovementVector.
        /// </returns>
        public int Speed
        {
            get { return _speed; }
        }

        /// <summary>
        ///     <para>
        ///         Used to determine if this MovementVector will stop movement.  This is
        ///         true whenever an empty point and a speed of 0 was used.
        ///     </para>
        /// </summary>
        /// <returns>
        ///     System.Int32 representing the speed of movement for this MovementVector.
        /// </returns>
        public Boolean IsStopped
        {
            get { return _destination.IsEmpty; }
        }

        /// <summary>
        ///     <para>
        ///         Used to get a special string representation of this MovementVector
        ///         for debugging purposes.
        ///     </para>
        /// </summary>
        /// <returns>
        ///     System.String of the string representation of a MovementVector.
        /// </returns>
        public override string ToString()
        {
            return "MovementVector {" + _destination.X + "," + _destination.Y + " speed=" + _speed + "}";
        }
    }
}