using System;
using System.Collections.Generic;
using System.Text;

namespace Amazon
{
    public class Graph
    {
        private int Vertices { get; set; }

        private List<int>[] AdjacencyList { get; set; }


        public Graph(int v)
        {
            Vertices = v;
            AdjacencyList = new List<int>[v];

            for(int i = 0; i < Vertices; i++)
            {
                AdjacencyList[i] = new List<int>();
            }
        }

        public void AddEdge(int v, int e)
        {
            AdjacencyList[v].Add(e);
        }

        public void PrintAdjacencyMatrix()
        {
            for(int i = 0; i < Vertices; i++)
            {
                foreach (var Item in AdjacencyList[i])
                {
                    Console.WriteLine(i + "-->" + Item);
                    
                }
               
            }

        }

        public int WaterSupplyProblem(Boolean[] blockcities)
        {
            int max = 0;
            for(int i=0; i < Vertices; i++)
            {
                max = Math.Max(WSPBFS(i, blockcities), max);
            }
            
            return max+1;
        }

        public int WSPBFS(int start, Boolean[] blockcities)
        {
            if (blockcities[start]) 
                return 0;

            bool[] visited = new bool[Vertices];
            Queue<int> queue = new Queue<int>();
            int max = 0;
            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                start = queue.Dequeue();
                Console.WriteLine("next->" + start);
                max++;
                //Get all the adjacent vaertices of start
                foreach (var Item in AdjacencyList[start])
                {
                    if (!visited[Item] && !blockcities[Item])
                    {
                        visited[Item] = true;
                        queue.Enqueue(Item);
                        
                    }
                    
                }

            }
            return max;
        }




        //BFS uses Queue as Base
        public void BFS(int start)
        {
            bool[] visited = new bool[Vertices];
            Queue<int> queue = new Queue<int>();
            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count != 0)
            {
                start = queue.Dequeue();
                Console.WriteLine("next->" + start);

                //Get all the adjacent vaertices of start
                foreach (var Item in AdjacencyList[start])
                {
                    if (!visited[Item])
                    {
                        visited[Item] = true;
                        queue.Enqueue(Item);
                    }
                }

            }
        }
        //DFS uses Stack as Base
        public void DFS(int start)
        {

            bool[] visited = new bool[Vertices];
            Stack<int> stack = new Stack<int>();
            visited[start] = true;
            stack.Push(start);

            while (stack.Count != 0)
            {
                start = stack.Pop();
                Console.WriteLine("next-->" + start);

                foreach(var Item in AdjacencyList[start])
                {
                    if (!visited[Item])
                    {
                        visited[Item] = true;
                        stack.Push(Item);
                    }
                    
                }

            }


        }
    }
}
