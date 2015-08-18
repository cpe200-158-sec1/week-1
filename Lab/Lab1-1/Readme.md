# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller:db39210d9f73c598ec40aeaf3390e691d78e56a1
* Without flag:7eb595cde841e4208221b5ec6fbff2dba8efb080

## Questions
1. How this code can sort number from smaller to larger
 
Answer: โปรแกรมจะทำการเปรียบเทียบค่าระหว่างอาเรย์ช่องที่ i กับอาเรย์ช่องที่ i+1 ถ้าค่าในอาเรย์ช่องที่ i มีค่ามากกว่าช่องถัดไป โปรแกรมจะนำค่าในช่องที่ i ไปแทนที่ช่องที่ i+1 และนำค่าช่องที่ i+1 ซึ่งมีค่าน้อยกว่ามาอยู่ในช่องที่ i

2. What if two numbers equal, what will happen? 

Answer: ไม่เกิดอะไรขึ้น และโปรแกรมจะข้ามไปตรวจสอบค่าของตัวเลขในอาเรย์ถัดไปแทน

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: n ( n -1 ) / 2

4. Why we need flag variable ? 

Answer: เพราะ ตัวแปร flag มีการเปลี่ยนจาก true เป็นfalse เมื่เข้าลูป while เพื่อตรวจสอบว่าค่าในอาเรย์ ถูกเรียงจากน้อยไปมากเรียบร้อยแล้วหรือไ หากในอาเรย์ มีการเรียงลำดับจากน้อยไปมากแล้ว โปรแกรมจะหยุดการทำงานในลูป while 
และทำการแสดงผลออกมา

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:ช้ากว่า เพราะ โปรแกรมจะรันทำงานไปเรื่อยๆ เพราะไม่มีตัวแปรที่หยุดการวนลูป