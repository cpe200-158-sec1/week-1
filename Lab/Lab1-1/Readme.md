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
 
Answer: เปรียบเทียบตัวเลขสองตัว ถ้าเลขตัวแรกมากกว่าตัวถัดไป ก็จะสร้างตัวแปร temp มาเก็บค่าของตัวเลขตัวแรกไว้
แล้วนำค่าของเลขตัวถัดไปมาใส่ไว้ในตัวเลขตัวแรกแทนจากนั้นนำค่าของตัวเลขตัวแรกที่เก็บไว้ในตัวแปร tempไปใส่ไว้ในตัวเลขตัวถัดไป
เป็นการสลับตัวเลขโดยการเรียงจากน้อยไปมาก

2. What if two numbers equal, what will happen? 

Answer: ไม่เข้า while loop แสดงผลตัวเลขที่เรียงมาก่อนหน้านั้น

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: จำนวนครั้งที่น้อยสุดคือ x=n มากสุดคือ x=n(n-1) ;xคือinput 

4. Why we need flag variable ? 

Answer: เพื่อให้มีการเชคว่าเลขทั้งหมดเรียงจากน้อยไปมากหรือยังถ้ายังก็จะทำการเรียงตัวเลข ถ้าเรียงทั้งหมดแล้วก็จะออกจากloop

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: