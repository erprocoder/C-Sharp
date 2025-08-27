using System;

namespace Formula
{
    public class Box
    {
        public int width;
        public int height;
        public int depth;

        public Box(int w, int h, int d)
        {
            width = w;
            height = h;
            depth = d;
        }

        public void getVolume()
        {
            Console.WriteLine("Volume is : " + width * height * depth);
        }
    }

    public class MatchBox : Box
    {
        public int weight;

        public MatchBox(int w, int h, int d, int m) : base(w, h, d)
        {
            weight = m;
        }

        static void Main(string[] args)
        {
            MatchBox mb1 = new MatchBox(10, 20, 30, 40);

            mb1.getVolume();

            Console.WriteLine("width of MatchBox is " + mb1.width);
            Console.WriteLine("height of MatchBox is " + mb1.height);
            Console.WriteLine("depth of MatchBox is " + mb1.depth);
            Console.WriteLine("weight of MatchBox is " + mb1.weight);

            Console.ReadLine();
        }
    }
}