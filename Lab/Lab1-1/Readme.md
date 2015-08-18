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
 
Answer: ตั้งค่าiเป็นตัวเลขเริ่มต้นและเช็คกับiตัวถัดไป ถ้าเลขที่ตำแหน่งiมากกว่าตำแหน่งถัดไปมากกว่าก็จะสลับตำแหน่งกับตัวถัดไปเรื่อยๆจน ครบทุกตัวตามเงื่อนไข

2. What if two numbers equal, what will happen? 

Answer:  ไม่เกิดอะไรขึ้นเนื่องจาก ถ้าเจอเลขที่เท่ากันจะข้ามไปเช็คตัวถัดไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: ในกรณีน้อยสุดคือเรียงมาแล้วใช้จำนวนX-1รอบ ถ้าวนมากที่สุดคือ(X-1)^2 รอบ โดยที่ Xคือจำนวนตัวที่inputเข้ามา

4. Why we need flag variable ? 

Answer: เป็นตัวเช็คว่าทำการเรียงเลขถูกต้องหมดแล้ว ถ้าถูกหมด จะหลุดออกจากลูป

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:เร็วขึ้นแต่ว่าค่าที่ได้อาจจะผิดพลาดได้