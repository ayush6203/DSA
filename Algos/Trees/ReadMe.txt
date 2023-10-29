Defination : 
 Tree leverages the benefit of both array & linklist i.e it searches the data in optmised way and insertion/deletion is also done in optimised way.
 where as array or linklist can do only one thing at a time either search is good or insert/update is good.

Types of Trees : 
 1. General Tree
 2. Binary Tree
 3. Binary Search Tree
 4. AVL Tree
 5. Spanning Tree
 6. Red Black Tree
 7. Segment Tree
 8. N-Ary Tree

BST Basic Operations : 
 1. Insert					            -> Search the location by traversing down the line and insert new node.
 2. Search					            -> Search the tree for a particular node.
 3. PreOrder Traversal		            -> Traverse the root node first and then go to the left or right subtrees. -- O(n), O(n)
 4. InOrder Traversal		            -> Traverse left or right subtree first, then traverse root node and then traverse other subtree. -- O(n), O(n)
 5. PostOrder Traversal		            -> Traverse both left and right subtrees first & then traverse root node. -- O(n), O(n)
 6. Morris Traversal		            -> This is also like DFS only thing is it does not uses auxilarry stack to store the recursive call. -- O(n), O(1)
 7. Level Order Traversal				-> This is Breadth First Search, a queue is being used to store the nodes of a level. -- O(n), O(n)





