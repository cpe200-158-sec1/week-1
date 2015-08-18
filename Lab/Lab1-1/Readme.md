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
 
Answer: เช็คสมาชิกใส input ตัวที่ i ว่ามากกว่า i+1 หรือไม่ ถ้าค่า i>i+1 จนเข้าลูป for เพื่อสลับค่าในตำแหน่งทั้งสอง โดยใช้ตัวแปร tmp เก็บค่า ของ 
input[i] ชั่วคราว แล้วนำค่าของ input[i+1] มาเก็บไว้ที่ input[i] จากนั้นให้นำค่าในtmp มาเก็บไว้ input[i+1] วนลูปจนกว่า input[i]<input[i+1]
แล้วจึงแสดงผลที่เรียงได้ออกมา

2. What if two numbers equal, what will happen? 

Answer: ไม่มีอะไรเกิดขึ้นคือไม่เข้าลูป for

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: (i/2)*(i-1)

4. Why we need flag variable ? 

Answer: ถ้าไม่มีการกำหนดตัวแปร flag การเรียงลำดับเลขจะเรียงได้ไม่ครบ

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: ช้าลง เพราะถ้าไม่ใช้ flag จะมีการวนลูปให้ครบทุกตัว