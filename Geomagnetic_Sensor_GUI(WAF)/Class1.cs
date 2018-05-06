using System;
using System.Collections.Generic;
using System.Text;
using QuickGraph;
using QuickGraph.Algorithms.ShortestPath;
using QuickGraph.Algorithms.Observers;
using QuickGraph.Algorithms;


namespace Geomagnetic_Sensor_GUI_WAF_
{

    public class Graph
    {
       Dictionary<char, Dictionary<char, int>> vertices = new Dictionary<char, Dictionary<char, int>>();

        public void add_vertex(char name, Dictionary<char, int> edges)
        {
            vertices[name] = edges;
        }

        public List<char> shortest_path(char start, char finish)
        {
            var previous = new Dictionary<char, char>();
            var distances = new Dictionary<char, int>();
            var nodes = new List<char>();

            List<char> path = null;

            foreach (var vertex in vertices)
            {
                if(vertex.Key == start)
                {
                    distances[vertex.Key] = 0;
                }
                else
                {
                    distances[vertex.Key] = int.MaxValue;
                }

                nodes.Add(vertex.Key);
            }

            while (nodes.Count != 0)
            {
                nodes.Sort((x, y) => distances[x] - distances[y]);

                var smallest = nodes[0];
                nodes.Remove(smallest);

                if (smallest == finish)
                {
                    path = new List<char>();
                    while (previous.ContainsKey(smallest))
                    {
                        path.Add(smallest);
                        smallest = previous[smallest];
                    }

                    break;
                }

                if (distances[smallest] == int.MaxValue)
                {
                    break;
                }

                foreach (var neighbor in vertices[smallest])
                {
                    var alt = distances[smallest] + neighbor.Value;
                    if (alt<distances[neighbor.Key])
                    {
                        distances[neighbor.Key] = alt;
                        previous[neighbor.Key] = smallest;
                    }
                }
            }

            return path;
        }

        public Graph()
        {
            add_vertex('A', new Dictionary<char, int> { { 'B', 1 },{ 'D', 1 } });
            add_vertex('B', new Dictionary<char, int> { { 'A', 1 },{ 'E', 1 },{ 'C', 1 } });
            add_vertex('C', new Dictionary<char, int> { { 'B', 1 },{ 'F', 1 } });
            add_vertex('D', new Dictionary<char, int> { { 'A', 1 },{ 'E', 1 },{ 'G', 1 } });
            add_vertex('E', new Dictionary<char, int> { { 'D', 1 },{ 'B', 1 },{ 'F', 1 },{ 'H', 1 } });
            add_vertex('F', new Dictionary<char, int> { { 'C', 1 },{ 'E', 1 },{ 'I', 1 } });
            add_vertex('G', new Dictionary<char, int> { { 'D', 1 },{ 'H', 1 } });
            add_vertex('H', new Dictionary<char, int> { { 'G', 1 },{ 'E', 1 },{ 'I', 1 } });
            add_vertex('I', new Dictionary<char, int> { { 'F', 1 },{ 'H', 1 } });
            
        }
    }

   









    























    public class Point //  Clase point que guarda los componentes del Campo magnético ( XYZ ) además de la magnitud de dicho punto
    {
        public double x;

        public double y;

        public double z;

        public double mag; // Magnitud

        public char ID;

        public double max;

        public double min;

        public Point(double equis = 0.0, double Ye = 0.0, double zeta = 0.0) // Constructor
        {
            x = equis;
            y = Ye;
            z = zeta;

            mag = x * x + y * y + z * z;

            mag = Math.Sqrt(mag);
            mag = Math.Round(mag, 1);
                        
            ID = ' ';

            max = mag + 500.0;
            min = mag - 500.0;
        }

    }


    





}
