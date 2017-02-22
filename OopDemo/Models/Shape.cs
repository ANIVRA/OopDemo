using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OopDemo.Models 
{
    //The abstract modifier indicates that the thing being modified has a missing or incomplete implementation
    abstract class ShapesClass : IDirection
    {
        public string ImageUrl;
        abstract public double Area();

        public virtual int Up()
        {
            return 5;
        }

        public virtual int Down()
        {
            return 5;
        }

        public virtual int Left()
        {
            return 5;
        }

        public virtual int Right()
        {
            return 5;
        }
    }

    class Square : ShapesClass
    {
        double sideLength = 0;
        int _move = 0;

        public Square(double n, int m)
        {
            sideLength = n;
            _move = m;
        }

        // Area method is required to avoid
        // a compile-time error.
        public override double Area()
        {
            return sideLength * sideLength;
        }

        public override int Left()
        {
            return _move;
        }

    }

    class Circle : ShapesClass
    {
        double radius = 0;
        int _move = 0;

        public Circle(double n, int m)
        {
            radius = n;
            _move = m;
        }

        public override double Area()
        {
            return 3.14 * (radius * radius);
        }

        public override int Right()
        {
            return _move;
        }

    }

    class Triangle : ShapesClass
    {
        double sideHeight = 0;
        double baseLength = 0;
        int _move = 0;

        public Triangle(double b, double h, int m)
        {
            sideHeight = h;
            baseLength = b;
            _move = m;
        }

        public override int Up()
        {
            return base.Up();
        }

        public override double Area()
        {
            return .5 * baseLength * sideHeight;
        }

    }

    class Ecks : ShapesClass
    {
        int _move = 0;


        public Ecks(int x)
        {
            _move = x;

        }

        public override int Down()
        {
            return _move;
        }

        public override double Area()
        {
            return 0;
        }

    }
}