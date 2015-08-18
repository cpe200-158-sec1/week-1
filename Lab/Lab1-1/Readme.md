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
 
Answer: ตรวจสอบค่าของiและตัวต่อไปคือi+1 โดยที่เริ่มi=0 โดยใช้เงื่อนไขi>i+1วนลูปจนกระทั่งi<i+1 แล้วจึงแสดงoutputออกมาจากการเรียงเลขจากน้อยไปมาก

2. What if two numbers equal, what will happen? 

Answer: ไม่เกิดอะไรขึ้น ไม่ทำการวนลูปfor

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: [x,x^2]

4. Why we need flag variable ? 

Answer: ถ้าไม่มีตัวแปรflagจะมีการวนลูปแค่ครั้งเดียว ทำให้เรียงเลขได้ไม่ครบ

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: ช้าลง