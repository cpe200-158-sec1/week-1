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
 
Answer: เมื่อรับค่ามา จะเปรียบเทียบตัวปัจจุบันกับตัวถัดไป แล้วสลับตำแหน่งเมื่อตัวปัจจุบันมากกว่าตัวถัดไป

2. What if two numbers equal, what will happen? 

Answer: ไม่มีการสลับตำแหน่ง เลื่อนพิจารณาตัวถัดไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (size of input) - 1 >= times <= (size of input)^2

4. Why we need flag variable ? 

Answer: ใช้ Check ว่ามีการเรียงลำดับแล้วหรือยัง 

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: จะเรียงลำดับทุกรอบ ถึงแม้มีการเรียงมาแล้ว 