using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Define a class: Point
namespace DynamicAnonType_Overloading
{//namespace begin
    internal class Point
    {//Point
        //create properties to hold X & co-ordinatesn
        public int X { get; set; }
        public int Y { get; set; }

    public Point(int x, int y)
        {//constuctor
            X = x;
            Y = y;
        }//constructor

        //overload the + operator to add not values but instances of the Point class
        //Syntax: public static  returnType operator OperatorSymbol (parameter list){methodbody}
        
        public static Point operator +(Point a, Point b)
        {//operator overload   
            //Return a new Point instance that is the sum of X & Y co-ordinates
            return  new Point(a.X + b.X, a.Y + b.Y);
        }   
    }//Point
}//namespace end
