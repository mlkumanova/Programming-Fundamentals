using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle
{
    public int Top { get; set; }
    public int Left { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }

    public int Right => Left + Width;
    public int Bottom => Top - Height;
    public int Area => Width * Height;

}

class RectanglePosition
    {
        static void Main(string[] args)
        {
        var firstRectangle = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var secondRectangle = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

        var first = new Rectangle
        {
            Left   = firstRectangle[0],
            Top    = firstRectangle[1],
            Width  = firstRectangle[2],
            Height = firstRectangle[3]
        };

        var second = new Rectangle
        {
            Left   = secondRectangle[0],
            Top    = secondRectangle[1],
            Width  = secondRectangle[2],
            Height = secondRectangle[3] 
        };
        if (FirstIsInside(first, second))
        {
            Console.WriteLine("Inside");
        }
        else
        {
            Console.WriteLine("Not Inside");
        }
     }

    public static bool FirstIsInside(Rectangle first , Rectangle second)
    {
        var leftIsCorrect = first.Left >= second.Left;
        var rightIsCorrect = first.Right <= second.Right;
        var bottomIsCOrrect = first.Bottom >= second.Bottom;
        var topIsCorrect = first.Top <= second.Top;

        return leftIsCorrect && rightIsCorrect && bottomIsCOrrect && topIsCorrect;
    }
    public static bool SecondIsInside(Rectangle first, Rectangle second)
    {
        var leftIsCorrect = first.Left <= second.Left;
        var rightIsCorrect = first.Right >= second.Right;
        var bottomIsCOrrect = first.Bottom <= second.Bottom;
        var topIsCorrect = first.Top >= second.Top;

        return leftIsCorrect && rightIsCorrect && bottomIsCOrrect && topIsCorrect;
    }
}

