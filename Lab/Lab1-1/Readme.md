# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: 6257e4f70b62b2ddc93214c92dbdb261ac696e13
* Without flag:

## Questions
1. How this code can sort number from smaller to larger
 
Answer: เปรียบเทียบเลขมากกับน้อยแล้วสลับเลขโดยเอาเลขมากไปไว้ข้างหลังก่อน

2. What if two numbers equal, what will happen? 

Answer: ไม่มีอะไรเกิดขึ้น 

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [x,(x-1)^2]

4. Why we need flag variable ? 

Answer: เราต้องการเช็คว่ายังมีการสลับเลขอยู่มั้ยเมื่อไม่มีการสลับแล้วจะออก loop while เมื่อ flag ไม่เป็น true

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:ช้าลงเพราะ flag ช่วยเช็คว่ายังมีการสลับตัวเลขอยู่มั้ย และทำการจบ loop ได้เร็วถ้าเสร็จก่อน