Defination :
Bit Manipulation is a technique used in a variety of problems to get the solution in an optimized way. This technique is very effective from a Competitive Programming point of view. 
It is all about Bitwise Operators which directly works upon binary numbers or bits of numbers that help the implementation fast. Below are the Bitwise Operators that are used:

	Bitwise AND (&)
	Bitwise OR  (|)
	Bitwise XOR (^)
	Bitwise NOT (!)

Operator	  Operation		Result
XOR			  X  ^  0s		  X
XOR			  X  ^  1s		  ~X
XOR			  X  ^  X		  0
AND			  X  &  0s		  0
AND			  X  &  1s		  X
AND			  X  &  X		  X
OR			  X  |  0s		  X
OR			  X  |  1s		  1s
OR			  X  |  X		  X




#  Brian Kernighan’s Algorithm
   This algorithm is used to count the number of set bits in an INT. Intution is below :
   n =  9 (1001)
   count = 0

   Since 9 > 0, subtract by 1 and do bitwise & with (9-1)
   n = 9&8  (1001 & 1000)
   n = 8
   count  = 1

   Since 8 > 0, subtract by 1 and do bitwise & with (8-1)
   n = 8&7  (1000 & 0111)
   n = 0
   count = 2

   Since n = 0, return count which is 2 now.


#  Bit Masking Concepts

   Suppose you a given a number num 9 -> 1 0 0 1

   1. To set kth bit of the num 
      create a bit mask 0 0 0 0
	  set kth bit of the bit mask i.e 1 << k => 1 << 2 = 0 1 0 0
	  perform or operation between mask and num i.e 1 0 0 1 | 0 1 0 0 => 1 1 0 1

   2. To Unset Kth bit of the num
      create a bit mask 0 0 0 0
	  set kth bit of the bit mask i.e 1 << k => 1 << 2 = 0 1 0 0
	  find not of the modified mask i.e ~mask => 1 0 1 1
	  perform and operation between mask and num i.e 1 0 0 1 & 1 0 1 1 = 1 0 0 1
