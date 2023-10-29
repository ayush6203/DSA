Defination :
A graph consists of a finite set of vertices or nodes and a set of edges connecting these vertices.
Two vertices are said to be adjacent if they are connected to each other by the same edge.

Some Basic Definations  :
Order				            ->	The number of vertices in the graph.
Size				            ->	The number of edges in the graph.
Vertex degree		            ->	The number of edges that are incident to a vertex.
Isolated vertex		            ->	The number of vertices that are not connected to any edges.
Self loop			            ->	An edge from a vertex to itself.
Directed graph		            ->	An edge where all the edges have direction indicating what is the start vertex and what is the end vertex.
Undirected graph	            ->	A graph with edges that have no direction.
Weighted graph		            ->	Edges of the graph has weight.
Unweighted graph	            ->	Edges of the graph has no weight.

Some Basic Algorithms	:
1.  BFS							->	Traverse all the neighbours before moving to the next depth.
2.  DFS							->	Traverse a particular vertex as deep as possible.
3.  Prims's Algo				->	This Algo is used to find minimum spanning tree.
4.	Disjoin Set Union			->	This is one of the data structure which follows union and findparent approach to arrange the node, it can be used in kruskal algorithm.
3.  Dijikstra					->	It is a shortest path algorithm. (it can find the shortest path between two node where the sum of the weight can be minimum)
4.  Bellmon Ford				->	It is a shortest path algorithm. (it can find the shortest path between two node where the sum of the weight can be minimum)
5.  Floyd Cycle					->	It can detect if there is cycle in the graph or not.
6.  Brent’s	algo				->	It can detect if there is cycle in the graph or not.
8.  Kruskal algo				->	It find the minimum spanning tree. (A minimum spanning tree is a subset of the edges of a graph that connects all the vertices with the minimum sum of edge weights and consists of no cycles)
9.  Kosaraju’s algo				->	It find weather the graph is strongy connected or not. (A graph is said to be strongly connected if every vertex in the graph is reachable from every other vertex.)
10. Tarjan’s strongly-conn		->	It find weather the graph is strongy connected or not. (A graph is said to be strongly connected if every vertex in the graph is reachable from every other vertex.)
11. Kahn's Algo	+ DFS			->	Topological sorting of a graph is a linear ordering of its vertices so that for each directed edge (u, v) in the ordering, vertex u comes before v.
12. BFS or DFS Coloring			->	Graph colouring assigns colours to elements of a graph while ensuring certain conditions. Vertex colouring is the most commonly used graph colouring technique.
13. Greedy Coloring				->	Graph colouring assigns colours to elements of a graph while ensuring certain conditions. Vertex colouring is the most commonly used graph colouring technique.



#### SPANNING TREE (See Image : SpanningTree)
When a graph follows below conditon it is called spanning tree : 
1. Graph should have N number of vertices & N-1 number of edges. (Means no cycle)
2. Each node should be reachable to every other nodes of the graph. 

 -- Minimum Spanning Tree (See Image : MST)
 A spanning tree with lowest cost of edges.

    We have two algorithms which works for finding Minimum Spanning Tree.
	1. Prim's Algo
	2. Kruskal's Algo


	* Prim's Algo (https://www.youtube.com/watch?v=HnD676J56ak)
	  - Create Adj List from the given Input.
	  - Create 3 Array for lookup with vertices size.  Visited (to track visited nodes) | Parent (to hold the parent node of the current Node) | Weight (to hold the minimum wait in each step).
	  - Initialise Visited with false, Parent with -1, Weight with Int32.MaxValue except 0th Index (0th index should have 0 as the weight).
	  - Find the index of the Minimum Weight from the Weight Array and that selected index should not be visited (check visited array for that).
	  - Get all the adjecent nodes of the selected index from above steps (Use adj list for that).
	  - Loop through all the adjcent nodes and compare the Weight Array with the edge weight, if edge weight is found to be less than the weight in the Weight Array and adjecent node is not already visited (check the Visited array), update the Weight array index with smaller edge weight and also mention the parent of that adjecent node in Parent array.
	  - Keep repeating all the steps except first 3 untill all the nodes are visited. i.e all the elements of Visited array becomes true.
	  - Note : See striver video on Prims & Check this solution Prim comments in Prim.cs file.
	  At the End of the Algo, you will find the Parent array as the MST in which every index has its parent name.


	* Kruskal's Algo (https://www.youtube.com/watch?v=1KRmCzBl_mQ&t=240s)
	  - Sort the given edges in assending order of the weights of edges.
	  - Start with sorted array of edges and one by one start unifying the components to each other.
	  - If any node is already belongs to same component than skip that particular edge.
	  - Reapeat the above 2 steps untill you are iterated with all the edges.


#### DISJOINT SET UNION
This data structure helps to merge the small small components into the big one i.e you are having number of edges you can combine those edges to create a graph. (https://www.youtube.com/watch?v=3gbO7FDYNFQ&t=963s)
it can store which is the parent of which node and can this in O(Constant) time.
	  - Create a two lookup array i.e Parent & Rank of size n.
	  - Intially parent of each node will be the node itself & rank will be zero.
	  - Pick the edges one by one, each edge will have two nodes n1 & n2.
	  - Find the parent of n1 & n2
	      If both n1 & n2 have same parent, it means both the nodes are already in a component no action required.
		  If parents are different & rank p1 is equal to the rank of p2, then do, parent[p2] = p1 & rank[p1] += 1
		  If parents are different & rank p1 is greater than the rank p2, then do, parent[p2] = p1
		  Else If parents are different & rank p2 is greater than the rank p1, then do, parent[p1] = p2 



#### CYCLE DETECTION
When you reach back to visited node during the travesal, it means cycle is present.

-- Directed Graph
	
	* Self DFS (https://www.youtube.com/watch?v=uzVUw90ZFIg&t=800s)
	   - This is very easy algorithm, a simple DFS only difference here is, we maintain two Isvisited array i.e isVisited & isDFSVisited.
	   - Appraoch is, whenever you visit any node mark both isVisited & isDFSVisited to true and when we you return back to the calling method again make isDFSVisited false for that same node. 
	   - For every node during traversal, There could be three scenerios
				-> Both isVisited & isDFSVisited is true : it means cycle is present in the graph (return it from here, saying cycle is present)
				-> Both isVisited & isDFSVisited is false : it means you are visiting this node first time (mark both the flags true and keep traversing)
				-> isVisited is true but isDFSVisited is false : it means you visited this particular node from different branch but cycle not found, so you are good. (return from here, saying no need to move further as already checked this branch no cycle detected, simply move back to traverse different branch.)

-- UnDirected Graph
	
	* BFS (https://www.youtube.com/watch?v=A8ko93TyOns&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=7)
	  - This is very easy algorithm, a simple BFS only difference here is, we try to push parent of the adj nodes along with adj nodes.
	  - Pefrom BFS, but don't propogate in parent node side.
	  - If you reach back to the visited node, it means the graph is cyclic

	* DFS (https://www.youtube.com/watch?v=Y9NFqI6Pzd4&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=8)
	  - This is very easy algorithm, a simple DFS only difference here is, we try to avoid recursive call for parent of the adj nodes.
	  - Pefrom DFS, but don't propogate in parent node side.
	  - If you reach back to the visited node, it means the graph is cyclic


#### TOPOLOGICAL SORT
Topological sorting is the linear ordering of the vertices such that there is an edge u, v where u appears before v in the ordering. It can only be applied on DAG (Directed Asyclic Graph).
	
	We have two ways by which topological sort can be done.
	1. DFS
	2. BFS

	* DFS Topological Sort (Make sure graph is Acyclic & directed (DAG)) (https://www.youtube.com/watch?v=Yh6EFazXipA&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=13&t=679s)
	  - Create Adjcency Matrix.
	  - Create one stack & visited array.
	  - Perfrom DFS traversal & at the time of returning push the element in the stack.
	  - Stack will give the toposort result.

	* BFS Topolical Sort (Make sure graph is Acyclic & directed (DAG)) => [Kahn's Algorithm] (https://www.youtube.com/watch?v=rZv_jHZva34&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=14&t=356s)
	  - Create Adjcency List
	  - Create inDegree array, which stores the count of incoming edges to a particular node
	  - Create a Queue for Bfs traversal & Initially enqueue all the nodes which have zero degree for now.
	  - Dequeue first node and store it in the toposort result, get all the adj nodes from adjList for this dequeued node and loop through the adj nodes : 
			-> reduce the indegree count by 1 for current adj node
			-> if indegree for this node become 0, push it into the queue.
	  - Repeat above step, untill the queue is empty.
	  (Note : You can use this algo to find if the given graph is cyclic or not, what you can do is, use a counter and keep track on the number of nodes dequed, if it cross the given number means the graph is cyclic)
	  (https://www.youtube.com/watch?v=V6GxfKDyLBM&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=15)


 ### SHORTEST DISTANCE
	
	 1. UnDirected Graph
	 2. Directed Graph

	 * UnDirected Graph (https://www.youtube.com/watch?v=hwCWi7-bRfI&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=15)
	   This approach can help to find out the shortest possible distance between the source node and the other remaining nodes.
	   This algorith assumed the weight is uniform across all the edges.
	   - Create Adjcency List.
	   - Create a distance array of size n where n is number of vertices & intially assing Infinite to all the distances except the source one.
	   - We will perform BFS traversal here, and to start with traversal enqueue the source node into the Queue.
	   - While Queue contains the elements keep traversing and perform below steps :
	         Dequeue the element from the queue & fetch its distance from distance array (this distance is the minimum length of path which is required to reach that ith node)
			 get all its adjecent nodes
			 check if alrady assigned distance of adj nodes are greater than currNode + 1
			    if no, do nothing
				if yes, updated the currNode distance + 1 value to the distance array of that adjNode, and push this same node into the queue.
			 repeat all the above steps again.
			 the last cell of distance array will contain minimum length requried to reach to destination.

	  * Directed Graph (https://www.youtube.com/watch?v=CrxG4WJotgg&list=PLgUwDviBIf0rGEWe64KWas0Nryn7SCRWw&index=16)




	  * Dijkastra Algorithm (https://www.youtube.com/watch?v=jbhuqIASjoM&t=886s)
	    This algorithm is basically used to find the shortest distance between the source node and the rest of the other nodes. It only works with positive weights and generally used where weight is not uniform.
		- Create Adjcenty List.
		- Create a distance array of size n where n is number of vertices & initially assign max infinite to all the distances except the source one, source one will be 0.
		- We will perform BFS traversal here, and to start with traversal enqueue the source node into the priority queue. (Min Heap) { it will keep the node with shortest path at top and it should be picked at first, GREEDY APPROACH}
		- While Priority Queue contains the elements, keep traversing and perform below steps :
	         Dequeue the top element from the queue & fetch its distance from distance array (this distance is the minimum length of path which is required to reach that ith node)
			 Get all its adjecent nodes
			 Check if alrady assigned distance of adj nodes are greater than currDistance + adj Node weight/distance
			    if no, do nothing
				if yes, updated the currNode distance + adj Node weight/distance value to the distance array of that adjNode, and push this same node into the queue along with the total added weight as priority.
			 repeat all the above steps again.
			 the last cell of distance array will contain minimum length requried to reach to destination.



	  * Bellman Ford Algorithm (https://www.youtube.com/watch?v=75yC1vbS8S8&t=14s)
	    This algorithm is basically used to find the shortest distance between the source node and the rest of the other nodes. It can work with both positive and negetive weights and generally used where weight is not uniform.
		- Input edges array should contain { source, destination, weight }
		- Bellman ford algorithm expects, if you perform relaxation on distance array n-1 times where n = number of nodes, than you should get shortest path array.
		- Create an array with the length of n and make all the nodes having max values except the source node. Soruce node should be 0.
		  
		  Relaxation logic, 
		  for each edge in edges array, perform below step
		  if(distance[soruce]+weight < distance[dest])					// if current distance of source node + the weight of that particular edge is less than the current distance of the dest node, then
		    distance[dest] = distance[source]+weight					// assign the calculated weight to the dest node.
		  
		  Note : Inorder to detect the negetive cycle, perform relaxation one more time and see if distance array is getting modified or not. if distance array is still getting modified it means negetive cycle is present in
				 the graph. Because bellman ford assumes that by N-1 times of relaxation you should be able to get min distance for each node.
				 Further scope of minimization is not possible after N-1 cycles, but in case there is negetive cycle is present minimization will keep on reducing even after N-1 cycles.
				 So, we can use this feature to detect if negetive cycle is present or not.



	  * Floyd Warshal's Algorithm (https://www.youtube.com/watch?v=YbY8cVwWAvw&t=1351s)
	    This algorithm is used to find the shortesh distance of each node with all the other nodes. It can work with negetive weights and can detect negetive cycles too. It generally return 2D array which gives info about the shortesht distance between each & every nodes.
		- Input edges array should contains { soruce, destination, weight}
		- It is like a brute force, where we try to go every node via every node. i.e if you want to go 1 -> 2, so it will be like 1 -> 0 -> 2 (via 0), 1 -> 3 -> 2 (via 3)
		- So, try to find the shortest path by traverlling via each and every node.
		
		Note : Inorder to detect negetive cycle, check the final result matrix, if at any place any cell for which i == j is less than 0, it means negetive cycle is present. 
		       (because weight of a node to travel to itself should always be 0 not less than that.)




