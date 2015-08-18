# Instruction

## Read and understand the code, the logic behind it, the limitation of it
* Answer the question 1 - 4 below (you can edit this file directly)
* Change the code such that it will sort from larger to smaller, put the revision of your code below
* Change the code such that there is no flag variable, put the commit number below and answer question 5 


## Revision, put your commit number here
* Sort from larger to smaller: d6da8cfe061f5eaa451a30902a68d63468efe352
* Without flag: 4669e38e500f84a8747d10986b838a6d65ffa373

## Questions
1. How this code can sort number from smaller to larger
 
Answer: ทำการเปรียบเทียบค่าของตัวเลขที่อยู่ใน address(ลำดับ) แรก
		ว่ามีค่ามากกว่าค่าที่อยู่ใน address ถัดไปหรือไม่ถ้ามากกว่า
		จะสร้างจัวแปร temp มารับค่าใน address แรกไว้ แล้วให้ address แรก
		เปลี่ยนค่าเท่ากับ address ที่สอง แล้วให้ค่า addressที่ 2
		มีค่าเท่ากับ temp ลักษณะคือการสลับที่ค่าที่อยู่ใน address ที่ติดกัน
		ไปเรื่อยๆจนค่า ลำดับที่ที่น้อยกว่ามีค่าน้อยกว่าลำดับที่มากกว่า

2. What if two numbers equal, what will happen? 

Answer: if two numbers equal there will not come in condition if  

3. How many times at line 24 will be executed (as a function of the size of input) 

Answer: x = n to x = n(n-1)  ; n = input

4. Why we need flag variable ? 

Answer: to check loop is complete? .if the sort number not from small to large
		all it will come to process in loop and check in condition if again.
		And check all number until all number sort from small to large all number.

5. When we remove the flag variable, the code will run faster or slower? in which scenario? 

Answer: The code will run slower because it will go to process in loop for equal n-1 times (n is size of input number) 
		)  