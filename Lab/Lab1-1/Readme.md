# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: fe7a3708492ad9d684411fd81924bb57596ff730
* Without flag: bc1c26ac4743be2fc3066ba0077ff634f43bfb61

## Questions
1. How this code can sort number from smaller to larger
 
Answer: Consider input in pair, compare and decide to swap them if a former is more than a latter.

2. What if two numbers equal, what will happen? 

Answer: Do nothing.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [n-1, (n-1)^2], n = size of input.

4. Why we need flag variable ? 

Answer: We need flag variable to check the condition, that show this sorting is finished, so it cause to break the loop.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: Slower, because there is no detector(flag variable) to check when exit the loop in advance.