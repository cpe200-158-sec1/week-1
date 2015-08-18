# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 5158a002484e1ba29a17db5e22e3ea5b1ea8efcc
* Without flag: 93a595105b50b9905e4e0a4d1cbaa0519f0a4a8a

## Questions
1. How this code can sort number from smaller to larger
 
Answer: สลับตำแหน่งกับเลขตำแหน่งถัดไป ก็ต่อเมื่อ ตัวเลขนั้นมากกว่าตัวเลขตำแหน่งถัดไป

2. What if two numbers equal, what will happen? 

Answer: ไม่สลับตำแหน่งกัน

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: เช็คเงื่อนไขมากที่สุด [n-1]^2 ครั้ง น้อยสุด [n-1] ครั้ง เมื่อ n คือจำนวนที่ input

4. Why we need flag variable ? 

Answer: เพื่อนำมาเช็คว่าเลขที่เราเรียง เรียงได้ถุกต้องแล้วหรือยัง ถ้าถูกต้องทุกตัวแหน่งแล้ว จะหลุดออกจาก Loop while

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: 