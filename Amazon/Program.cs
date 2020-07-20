using System;

namespace Amazon
{
    class Program
    {
        static void Main(string[] args)
        {

            //Graph BFS(Breadth First Search) and DFS (Depth Frist Search) Traversal
            Graph graph = new Graph(7);
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 0);
            graph.AddEdge(1, 2);
            graph.AddEdge(2, 1);
            graph.AddEdge(2, 3);
            graph.AddEdge(3, 2);
            graph.AddEdge(3, 4);
            graph.AddEdge(4, 3);
            graph.AddEdge(4, 5);
            graph.AddEdge(5, 4);
            graph.AddEdge(5, 6);
            graph.AddEdge(6, 5);
            Boolean[] blockcities = new Boolean[7] {false,true,true,false,false,false,false};
            
            var count = graph.WaterSupplyProblem(blockcities);
            Console.WriteLine(count);


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
            //Console.WriteLine("BFS traversal starting from vertex 2:");
            //graph.BFS(2);
            //Console.WriteLine("DFS traversal starting from vertex 2:");
            //graph.DFS(2);




            ////There are two sorted arrays nums1 and nums2 of size m and n respectively.
            ////Find the median of the two sorted arrays. The overall run time complexity should be O(log (m+n)).
            //int[] num1 = { 0, 1, 2 };
            //int[] num2 = { 3, 4, 5 };
            //AmazonSolution amazonSolution = new AmazonSolution();
            //double median = amazonSolution.FindMedianSortedArrays(num1, num2);
            //Console.WriteLine("Median: {0}", median);



            ////Given a string, find the length of the longest substring without repeating characters.
            //string s = "pwwkew";
            //AmazonSolution amazonSolution = new AmazonSolution();
            //int count = amazonSolution.LengthOfLongestSubstring(s);
            //Console.WriteLine("Count: {0}", count);
        }
    }
}
