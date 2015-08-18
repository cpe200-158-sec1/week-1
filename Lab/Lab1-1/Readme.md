# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


* Sort from larger to smaller:
* Without flag:

## Questions
1. How this code can sort number from smaller to larger
 
Answer: ตั้งค่า 'i' เป็นตำแหน่งของตัวเลข และนำไปเทียบกับตัวเลขในตำแหน่งถัดไป(i+1) ถ้า ตัวเลขใน(i) มากกว่าตัวเลขใน(i+1) ก้จะสลับตำแหน่งกัน โปรแกรมจะตรวจไล่ไปเรื่อย ๆ จนครบทุกตำแหน่ง

2. What if two numbers equal, what will happen? 

Answer: โปรแกรมก็จะข้ามไปตรวจสอบในตำแหน่งต่อไป

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer:หาได้จากการแทนจำนวน input เป็น x แล้วแทนใน x/2(x-1) จะได้ตำตอบเป็น 45 รอบ

4. Why we need flag variable ? 

Answer: เพื่อตรวจสอบว่าตัวเลขทั้งหมดได้ถูกจัดเรียง

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer:ช้าลงแต่ทำงานได้ถูกต้อง

## Revision, put your commit number here
 *Sort from Larger to smaller ## 2d93ac6723e04cb0db42e6aa7da2daa396750f92
 *Without Flag ## fb36b2a0c154c9d6512541a7a5fde203cf730598