# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 9 8 5 4 4 3 2 2 1 1
* Without flag: 9 8 5 4 4 3 2 2 1 1

## Questions
1. How this code can sort number from smaller to larger
 
Answer: Change condition in line 24 from "if (input[i] > input[i + 1])" to "if (input[i] < input[i + 1])".

2. What if two numbers equal, what will happen? 

Answer: Number in position i will not transposition to i+1 (stay in current position).

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: Executed between  n-1 to (n-1)^2 time(s) when n is size of input.

4. Why we need flag variable ? 

Answer: We do not want to processing all case EVEN all number are sorted. So if these number are correctly sorted, Flag variables will be FALSE (TRUE if not) and it will break all loop to next process.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: Slower because EVEN it were sorted, it will run all case (processing up to max times).
