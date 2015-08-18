# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:48c1f56
* Without flag:df14848

## Questions
1. How this code can sort number from smaller to larger?
 
Answer: The program compare the value of two positions from begin position to the last position. If the value position i is larger than i+1 the values will be switch and looping till the flag value is false.

2. What if two numbers equal, what will happen? 

Answer: Nothing will happen.

3. How many times at line 24 will be executed (as a function of the size of input)?

Answer:  81 times  [If input x value the longest case is x*(x-1) times]

4. Why we need flag variable ? 

Answer: To cheack the sorting process is sorted or not.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: Slower, because the flag use to check if the sorting process is finish then exit the loop.