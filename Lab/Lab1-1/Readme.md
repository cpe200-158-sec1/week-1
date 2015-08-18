# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:
* Without flag:

## Questions
 1. How this code can sort number from smaller to larger
  
 
Answer: check condition(num[i]>num[i+1]) and switching two number until array number was sort to   smaller to larger.
 
 2. What if two numbers equal, what will happen? 
 
 
Answer: not issue and it will run next loop.
 
 3. How many times at line 24 will be executed (as a function of the size of input) 
  

Answer:when input array sort smaller to larger , it will run n-1 AND when input array sort larger to  smaller , it will run n(n-1).
 
 4. Why we need flag variable ? 
 

Answer: Because it control loop and save time to run .
 
 5. When we remove the flag variable, the code will run faster or slower? in which scenario? 
 Answer: slower..  because flag variable help to save to run for loop.