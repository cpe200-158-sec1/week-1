# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 97ff6d1e90de504c009152471469d9af25823375
* Without flag:91613db6fe0ac5bf075a70966235ca6f44e26bd4

## Questions
1. How this code can sort number from smaller to larger
 
Answer: switch number until sort number from smaller to larger and leave from loop.

2. What if two numbers equal, what will happen? 

Answer: skip to run next number.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer:  min= n-1 ,max = n(n-1)

4. Why we need flag variable ? 

Answer:  Because when we can sort number from smaller to larger finish,they don't enter while loop again.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: