# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 8b0e6f2a2a9c38d655ab88ed423479759b89d90b
* Without flag: 69b297cacc76f2730df79177a53bb3c0cccf3ee9

## Questions
1. How this code can sort number from smaller to larger
 
Answer: By check value of numbers in input[] if input[i]>input[i+1] the program will sort by input[i+1] in front of input[i] and
		do this for every numbers until all of numbers are sort from smaller to larger.

2. What if two numbers equal, what will happen? 

Answer: Don't entry if loop and don't switch between those numbers.

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [n-1,(n-1)^2]

4. Why we need flag variable ? 

Answer: To check before while loop. If flag=false it's means all of numbers are sort from smaller to larger
		and won't entry while loop. If flag=true it's means some numbers aren't sort from smaller to larger
		and entry while loop again until flag=true.


5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: Slowwer. Because code without flag variable is have 2 for loops. It will be slowwer then code with flag.