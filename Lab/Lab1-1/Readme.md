# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 5acb6e187f8e7b887727d34867c24c4f7425c872
* Without flag: befb4acf2bda3d8a200d869af8708360276507bf

## Questions
1. How this code can sort number from smaller to larger
 
Answer:if Number(side-right) large than Number(side-left) ---> Number(side-left) Pushed from side-left to side-right

2. What if two numbers equal, what will happen? 

Answer: Not into function(if)--->don't happen push

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [n-1,(n-1)^2]

4. Why we need flag variable ? 

Answer: if finish loop(for) then [flag = false] that is in that round don't enter to (function if) even once , that mean is stop of program .

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:it will slower because totol of loop equal (n-1)^2 only.