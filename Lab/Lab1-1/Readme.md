# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 3e673ef
* Without flag: 

## Questions
1. How this code can sort number from smaller to larger
 
Answer: สลับเลขโดยเปียบเทียบเลขตัวต่อไปเรื่อยๆ

2. What if two numbers equal, what will happen? 

Answer: มันก็ไม่สลับ

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: น้อยสุด n-1 รอบ / มากสุด (n-1)^2 รอบ

4. Why we need flag variable ? 

Answer: เพื่อตรวจสอบว่า เรียงเลขได้ถูกต้องแล้วหือยัง

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: faster but it's not correct