using System;

namespace Main
{
    internal class Program
    {
        public static void Main()
        {
            Edge[] edges = new Edge[]
            {
        new Edge()
        {
            FirstPoint = new Point()
            {
                X_Position = 4.5,
                Y_Position = 3.6
            },
            SecondPoint = new Point()
            {
                X_Position = 7.3,
                Y_Position = 2.4
            }
        },
        new Edge()
        {
            FirstPoint = new Point()
            {
                X_Position = 1.8,
                Y_Position = 2.1
            },
            SecondPoint = new Point()
            {
                X_Position = 1.8,
                Y_Position = 6.5
            }
        },
        new Edge()
        {
            FirstPoint = new Point()
            {
                X_Position = 5.6,
                Y_Position = 7.8
            },
            SecondPoint = new Point()
            {
                X_Position = 9.1,
                Y_Position = 3.4
            }
        },
        new Edge()
        {
            FirstPoint = new Point()
            {
                X_Position = 3.2,
                Y_Position = 4.5
            },
            SecondPoint = new Point()
            {
                X_Position = 3.2,
                Y_Position = 1.6
            }
        }
            };

            ShowVerticalEdges(edges);
        }

        public static void ShowVerticalEdges(Edge[] edges)
        {
            foreach (Edge edge in edges)
            {
                if (edge.FirstPoint.X_Position == edge.SecondPoint.X_Position)
                    Console.Write($"{edge.FirstPoint.X_Position} {edge.FirstPoint.Y_Position} {edge.SecondPoint.X_Position} {edge.SecondPoint.Y_Position}\n");
            }
        }
    }
}
