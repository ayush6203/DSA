using Algos.Bit_Manipulation;
using Algos.Graphs;
using Algos.HeapAndPriorityQueues;
using Algos.Searching;
using Algos.Sorting;
using Algos.Trees;
using Algos.Tries;
using Domain.DataModels.Tree;
using DSAConcepts;
using System.Data;

#region Searching
//Binary Search
//int element = 30;
//BinarySearch binarySearch = new BinarySearch();
//int[] input = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
//Console.WriteLine("Index is : " + binarySearch.Search(input, element));
#endregion

#region Sorting
//Merge Sort
//int[] inputArr = new int[] { 25, 11, 24, 28, 56, 44, 52 };
//MergeSort mergeSort = new MergeSort();
//var response = mergeSort.Sort(inputArr);


//Quick Sort
//int[] inputArr = new int[] { 25, 11, 24, 28, 56, 44, 52 };
//QuickSort quickSort = new QuickSort();
//var response1 = quickSort.Sort(inputArr);
#endregion

#region Graph
//Input Creationg
//int[] pusher = new int[] { 0, 1, 0, 2, 0, 5, 1, 3, 1, 4, 2, 1, 5, 6 };
//int[][] graphInput = new int[pusher.Length/2][];
//int iterator = 0;
//for(int i = 0; i < graphInput.Length; i++)
//{
//    graphInput[i] = new int[] { pusher[iterator++], pusher[iterator++] };
//}

//DFS
//DFS dfs = new DFS();
//dfs.Traverse(graphInput);
//BFS
//BFS bfs = new BFS();
//bfs.Traverse(graphInput);


//Prim's Algo
//int[] pusher = new int[] { 0, 1, 2, 0, 3, 6, 1, 0, 2, 1, 3, 8, 1, 4, 5, 1, 2, 3, 2, 1, 3, 2, 4, 7, 3, 0, 6, 3, 1, 8, 4, 1, 5, 4, 2, 7 }; // set of 3, [source, destination, weight]
//int[][] graphInput = new int[pusher.Length / 3][];
//int iterator = 0;
//for(int i = 0; i < graphInput.Length; i++)
//{
//    graphInput[i] = new int[] { pusher[iterator++], pusher[iterator++], pusher[iterator++] };
//}
//Prim prim = new Prim();
//prim.BuildMst(5, graphInput);


//Kruskal
//int[] pusher = new int[] { 0, 4, 8, 0, 1, 5, 1, 2, 3, 2, 3, 2, 3, 4, 2, 3, 1, 1 }; // set of 3, [source, destination, weight]
//int[][] graphInput = new int[pusher.Length / 3][];
//int iterator = 0;
//for (int i = 0; i < graphInput.Length; i++)
//{
//    graphInput[i] = new int[] { pusher[iterator++], pusher[iterator++], pusher[iterator++] };
//}
//Kruskal kruskal = new Kruskal();
//kruskal.BuildMst(5, graphInput);


//DSU Algo
//int[] pusher = new int[] { 1, 2, 2, 3, 4, 5, 6, 7, 5, 6, 3, 7 };
//int[][] dsuInput = new int[pusher.Length / 2][];
//int iterator = 0;
//for(int i = 0; i < dsuInput.Length; i++)
//{
//    dsuInput[i] = new int[] { pusher[iterator++], pusher[iterator++] };
//}
//DSU dsu = new DSU();
//dsu.PerformDsuOperation(dsuInput);


//TopoSort
//int[][] graphInput = new int[6][];
//graphInput[0] = new int[] { 2, 3 };
//graphInput[1] = new int[] { 3, 1 };
//graphInput[2] = new int[] { 4, 0 };
//graphInput[3] = new int[] { 4, 1 };
//graphInput[4] = new int[] { 5, 0 };
//graphInput[5] = new int[] { 5, 2 };
//DFS
//TopoSortDfs topoSort = new TopoSortDfs();
//topoSort.FindTopoSort(6, graphInput);
//BFS
//TopoSortBfs topoSort = new TopoSortBfs();
//topoSort.FindTopoSort(6, graphInput);


//Cycle Detection
//BFS
//int[][] edges = new int[12][];
//edges[1] = new int[] { 2, 4 };
//edges[2] = new int[] { 3, 5 };
//edges[3] = new int[] { 5, 6 };
//edges[4] = new int[] { 6, 7 };
//edges[5] = new int[] { 7, 8 };
//edges[6] = new int[] { 8, 11 };
//edges[7] = new int[] { 8, 9 };
//edges[8] = new int[] { 9, 10 };
//edges[9] = new int[] { 10, 5 };
//edges[10] = new int[] { 1, 2 };
//BFSCycleDetectionInUnDirectedGraph bfsCycleDetection = new BFSCycleDetectionInUnDirectedGraph();
//bfsCycleDetection.DetectCycle(12, edges);
//DFS
//DFSCycleDetectionInUnDirectedGraph dfsCycleDetection = new DFSCycleDetectionInUnDirectedGraph();
//dfsCycleDetection.DetectCycle(12, edges);


//Shortest Path
//int[][] edges = new int[11][];
//edges[0] = new int[] { 0, 1 };
//edges[1] = new int[] { 0, 3 };
//edges[2] = new int[] { 1, 3 };
//edges[3] = new int[] { 1, 2 };
//edges[4] = new int[] { 2, 6 };
//edges[5] = new int[] { 3, 4 };
//edges[6] = new int[] { 4, 5 };
//edges[7] = new int[] { 5, 6 };
//edges[8] = new int[] { 6, 7 };
//edges[9] = new int[] { 6, 8 };
//edges[10] = new int[] { 7, 8 };
//ShortedDistanceInUndirectedDFS shortedDistanceInUndirectedDFS = new ShortedDistanceInUndirectedDFS();
//shortedDistanceInUndirectedDFS.CalculateShortedDistance(9, edges);


//Dijkstra Algorithm for shortest path
//int n = 4;
//int source = 2;
//int[][] edges = new int[3][];
//edges[0] = new int[] { 2, 1, 1 };
//edges[1] = new int[] { 2, 3, 1 };
//edges[2] = new int[] { 3, 4, 1 };
//Dijkstra dijkstra = new Dijkstra();
//dijkstra.FindTheShortedPath(n, edges, source);


//Belman Ford for shortest path for negetive weights too.
//int[][] edges = new int[7][];
//edges[0] = new int[] { 3, 2, 6 };       // {source, destination, weight} 
//edges[1] = new int[] { 5, 3, 1 };
//edges[2] = new int[] { 0, 1, 5 };
//edges[3] = new int[] { 1, 5, -3 };
//edges[4] = new int[] { 1, 2, -2 };
//edges[5] = new int[] { 3, 4, -2 };
//edges[6] = new int[] { 2, 4, 3 };
//BellmanFord bellmanFord = new BellmanFord();
//bellmanFord.FindTheShortedPath(6, edges, 0);


//Floyd Washell Algorithm for shortest path of every node with every node : 2D array will be the response.
//int n = 4;
//int[][] edges = new int[6][];
//edges[0] = new int[] { 0, 1, 2 };
//edges[1] = new int[] { 1, 0, 1 };
//edges[2] = new int[] { 1, 2, 3 };
//edges[3] = new int[] { 3, 0, 3 };
//edges[4] = new int[] { 3, 1, 5 };
//edges[5] = new int[] { 3, 2, 4 };
//FloydWarshal floydWarshal = new FloydWarshal();
//floydWarshal.FindTheShortedPath(n, edges);

#endregion

#region Heaps

//PriorityQueues priorityQueues = new PriorityQueues();
//priorityQueues.BuildMinHeap(new int[] { 100, 5, 54, 22, 1, 6, 8, 17 });
//priorityQueues.BuildMaxHeap(new int[] { 100, 5, 54, 22, 1, 6, 8, 17 });

//PriorityQueue<int, int> testQ = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => a == b ? -1 : a - b));
//testQ.Enqueue(0, 1);
//testQ.Enqueue(1, 4);
//testQ.Enqueue(2, 1);
//testQ.Enqueue(3, 1);
//Console.WriteLine(testQ.Dequeue());
//Console.WriteLine(testQ.Dequeue());

//MinHeap minHeap = new MinHeap(6);
//minHeap.Insert(7);
//minHeap.Insert(8);
//minHeap.Insert(4);
//minHeap.Insert(3);
//minHeap.Insert(2);
//minHeap.Insert(1);
//Console.WriteLine(minHeap.Delete());
//Console.WriteLine(minHeap.Delete());
//Console.WriteLine(minHeap.Delete());
//Console.WriteLine(minHeap.Delete());
//Console.WriteLine(minHeap.Delete());
//Console.WriteLine(minHeap.Delete());


//MaxHeap maxHeap = new MaxHeap(6);
//maxHeap.Insert(1);
//maxHeap.Insert(2);
//maxHeap.Insert(3);
//maxHeap.Insert(2);
//maxHeap.Insert(12);
//maxHeap.Insert(111);
//Console.WriteLine(maxHeap.Delete());
//Console.WriteLine(maxHeap.Delete());
//Console.WriteLine(maxHeap.Delete());
//Console.WriteLine(maxHeap.Delete());
//Console.WriteLine(maxHeap.Delete());
//Console.WriteLine(maxHeap.Delete());

//Console.Read();

#endregion

#region Bit Manipulation

//GetOrSetBit getOrSetBit = new GetOrSetBit();
//Console.WriteLine(getOrSetBit.PowerOfTwo(4));

//Console.WriteLine(getOrSetBit.GetBit(9, 0));
//Console.WriteLine(getOrSetBit.GetBit(9, 1));
//Console.WriteLine(getOrSetBit.GetBit(9, 2));
//Console.WriteLine(getOrSetBit.GetBit(9, 3));

//Console.WriteLine(getOrSetBit.SetBit(9, 1));

//Console.WriteLine(getOrSetBit.ClearBit(11, 1));

#endregion

#region Trie
//Trie trie = new Trie();
//trie.Insert("ayush");
//trie.Insert("arsh");
//trie.Insert("nikku");
//trie.Insert("papa");
//trie.Insert("pakhi");
//trie.Insert("pihu");
//bool res1 = trie.Search("ayush");
//bool res2 = trie.Search("nikk");
//bool res3 = trie.Search("nikkuu");
//bool res4 = trie.Search("piho");
//bool res5 = trie.Search("pihu");
//bool res6 = trie.Search("ayush");
//bool res7 = trie.Search("komal");
//bool res8 = trie.Search("ar");
//bool res9 = trie.Search("piihu");
//bool res10 = trie.Search("topmate");
//bool res11 = trie.Search("pakhi");
//bool res12 = trie.Search("pakhh");

//bool res13 = trie.StartsWith("ay");
//bool res14 = trie.StartsWith("ar");
//bool res15 = trie.StartsWith("ak");
//bool res16 = trie.StartsWith("pihu");
//bool res17 = trie.StartsWith("paki");
//bool res18 = trie.StartsWith("nik");
//bool res19 = trie.StartsWith("zeb");
#endregion


KMP kmp = new();
kmp.KmpSearch("abxabcabcaby","abcxaby");

Console.ReadLine();