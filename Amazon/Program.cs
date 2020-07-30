using System;
using Amazon.BST;

namespace Amazon
{
    class Program
    {
        static void Main()
        {

            var tree = new BinarySearchTree<int>();
            int[] values = { 10, 5, 20, 6, 8, 15, 40, 1, 2, 9, 6 };
            tree.Insert(values);

            tree.Traverse((Node<int> node) => Console.WriteLine(node.Value + ", "), TraversalType.InOrder);

            var node=tree.Search(15);
            






            //Graph BFS(Breadth First Search) and DFS (Depth Frist Search) Traversal
            //Graph graph = new Graph(7);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(1, 0);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(2, 1);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 2);
            //graph.AddEdge(3, 4);
            //graph.AddEdge(4, 3);
            //graph.AddEdge(4, 5);
            //graph.AddEdge(5, 4);
            //graph.AddEdge(5, 6);
            //graph.AddEdge(6, 5);
            //Boolean[] blockcities = new Boolean[7] {false,true,true,false,false,false,false};

            //var count = graph.WaterSupplyProblem(blockcities);
            //Console.WriteLine(count);


            //Graph BFS(Breadth First Search) and DFS (Depth Frist Search) Traversal
            //Graph graph = new Graph(7);
            //graph.AddEdge(0, 1);
            //graph.AddEdge(1, 0);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(2, 1);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(3, 2);
            //graph.AddEdge(3, 4);
            //graph.AddEdge(4, 3);
            //graph.AddEdge(4, 5);
            //graph.AddEdge(5, 4);
            //graph.AddEdge(5, 6);
            //graph.AddEdge(6, 5);
            //graph.PrintAdjacencyMatrix();
            //Console.WriteLine("BFS traversal starting from vertex 3:");
            //graph.BFS(3);
            //Console.WriteLine("DFS traversal starting from vertex 3:");
            //graph.DFS(3);



            ////Given a string, find the length of the longest substring without repeating characters.
            //string s = "pwwkew";
            //AmazonSolution amazonSolution = new AmazonSolution();
            //int count = amazonSolution.LengthOfLongestSubstring(s);
            //Console.WriteLine("Count: {0}", count);
        }
    }
}
