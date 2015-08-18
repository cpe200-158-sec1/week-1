# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 9 8 5 4 4 3 2 1 1
* Without flag: 5 4 8 9 2 2 4 3 1 1

## Questions
1. How this code can sort number from smaller to larger
 
Answer: เทียบตัวเลขในarrayปัจจุบันกับarrayถัดไป หากตัวเลขในarrayถัดไปมีค่าน้อยกว่าตัวเลขในarrayปัจจุบัน จะสลับตำแหน่งตัวเลขสองตัว

2. What if two numbers equal, what will happen? 

Answer: จะไม่สลับตัวเลขกัน

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n(n-1)!

4. Why we need flag variable ? 

Answer: เป็นตัวเช็คว่าจะไม่มีการสลับตำปหน่งตัวเลขแล้ว

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:โค๊ดจะไม่สามารถทำงานได้เนื่องจากติดลูปwhile