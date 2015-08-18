# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:672c76102f64f62ac4c00656f46637c2ea364db4
* Without flag:1c8cd7cb9b613af155b694724a04a1824249a4b8

## Questions
1. How this code can sort number from smaller to larger
 
Answer: เมื่อมีการ input ตัวเลขเข้ามาจะมีการตรวจสอบถ้าตัวเลขที่เข้ามามีค่ามากว่าตัวถัดไปจะมีการสลับตำแหน่งและนำค่าที่มากกว่าไปด้านหลัง

2. What if two numbers equal, what will happen? 

Answer: จะไม่มีการสลับตำแหน่งของตัวเลข และจะเช็คตัวต่อไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: x คือจำนวน input จำนวนลูปได้เร็วที่สุดคือ x-1 ลูป และจำนวนที่ช้าที่สุดคือ  (x/2)*(x-1) ลูป

4. Why we need flag variable ? 

Answer:  ใช้เป็นตัวเช็ค ว่าโปรแกรมเรียงเลขถูกต้องแล้วหรือยัง ถ้าถูกจะออกจากลูป

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:  เร็วขึ้นแต่อาจมีการผิดพลาด 