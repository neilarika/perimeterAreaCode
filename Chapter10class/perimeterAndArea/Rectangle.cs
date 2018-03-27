using System;


namespace Chapter10class
{
    class Rectangle
    {
        private double length;
        private double width;

        //constructors

        //constructor with no parameters
        public Rectangle(): this(1, 1)

        {
            //length = 1;
            //Length = 1;
            //Width = 1;
        }

        // constructor with  2 parameters
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;

            //not as good
            //we coulve said
            //this.length = length;
            //this.width = width;
        }




        //properties for length and width
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    length = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"length",
                        value, "length must be between 0-20");
                }
            }
        }


        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value >= 0 && value <= 20)
                {
                    width = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"width",
                        value, "width must be between 0-20");
                }
            }
        }


        public double Area
        {
            get
            {
                return length * width;
            }
        }

        public double Perimeter
        {
            get
            {
                return (length * 2) + (width * 2);
            }
        }

        public override  String ToString()
        {
            //return "Length is " + Length;
            return ($"Length: {Length} \nWidth: {Width} \n" +
                $"Area: {Area:f2} \nPerimeter: {Perimeter:f2}");

        }

    }
}
