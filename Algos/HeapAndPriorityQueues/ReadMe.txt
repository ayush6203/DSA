Defination : 
Heap are generally a tree like data-structure in which data automatically gets stored in sorted order, Delete & Insert operations are Log(n).
These heaps are nothing but the complete binary tree where each level has full childs only last level is allowed to have partial childs that too should start with left. (i.e always start adding child from left)
There are two types of heaps, 
 1. Min Heap
 2. Max Heap

 
1. Min Heap
   In this data-structure whenever insertion happen the smallest element always placed at the root.

   How it works : 
    - Suppose insertion happened, add the new inserted node in the last leaf. (Check which place is empty from left and add it)
    - Since it is min heap, root of every subtree should be smaller than its child, so start checking that path where new node is added and perform the swaps between root & child if root is found greater than its child.
    - We use array here, for every root node, left child = 2*n, right child = 2*n + 1 and vice-versa for every child, root = n/2;
    - At insertion we do heapyfy from bottom to top.
    - At deletion we do heapyfy from top to bottom.

2. Max Heap
   In this data-structure whenever insertion happen the largest element always placed at the root.

   How it works : 
    - Suppose insertion happened, add the new inserted node in the last leaf. (Check which place is empty from left and add it)
    - Since it is max heap, root of every subtree should be larger than its child, so start checking that path where new node is added and perform the swaps between root & child if root is found smaller than its child.
    - We use array here, for every root node, left child = 2*n, right child = 2*n + 1 and vice-versa for every child, root = n/2;
    - At insertion we do heapyfy from bottom to top.
    - At deletion we do heapyfy from top to bottom.



######### PRIORITY QUEUE
This data structure internally uses Min or Max heap, in C# we do not have any library for Min or Max heap. So we can use priority queue in this case.