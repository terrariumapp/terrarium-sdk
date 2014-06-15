//------------------------------------------------------------------------------
//      Copyright (c) Microsoft Corporation.  All rights reserved.                                                             
//------------------------------------------------------------------------------

namespace Terrarium.Sdk.Classes.Helpers
{
    /// <summary>
    /// Copy of the Point structure from System.Drawing (so we don't have to include it in the SDK)
    /// </summary>
    public class Point
    {
        private int x;
        private int y;

        public Point()
        {
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static readonly Point Empty = new Point();

        public bool IsEmpty
        {
            get
            {
                return x == 0 && y == 0;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
    }
}