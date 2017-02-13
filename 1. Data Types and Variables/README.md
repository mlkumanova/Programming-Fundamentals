1.	Practice Integer Numbers
Create a new C# project and create a program that assigns integer values to variables. Be sure that each value is stored in the correct variable type (try to find the most suitable variable type in order to save memory). Finally, you need to print all variables to the console
// Input: 
-100
128
-3540
64876
2147483648
-1141583228
-1223372036854775808
Output:
-100
128
-3540
64876
2147483648
-1141583228
-1223372036854775808


2. Convert Speed Units
Create a program to ask the user for a distance (in meters) and the time taken (as three numbers: hours, minutes, seconds), and print the speed, in meters per second, kilometers per hour and miles per hour.
Assume 1 mile = 1609 meters.
Input:
1000 		
1		
1		
0		
Output:
0.2732241	
0.9836066	
0.6113155	

3. Create a program to convert a decimal number to hexadecimal and binary number and print it.

Input: 420
Output: 1A4
110100100


4. Comparing Floats
Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than some fixed constant eps. Examples:
Number a:	Number b:	Equal:	Explanation:
5.3			6.01		False	The difference of 0.71 is too big (> eps)
5.00000001	5.00000003	True	The difference 0.00000002 < eps
5.00000005	5.00000001	True	The difference 0.00000004 < eps
-0.0000007	0.00000007	True	The difference 0.00000077 < eps
-4.999999	-4.999998	False	Border case. The difference 0.000001 == eps. We consider the numbers are different.

5. Special Numbers
A number is special when its sum of digits is 5, 7 or 11.
Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).
Input:	Output:
15	1 -> False
	2 -> False
	3 -> False
	4 -> False
	5 -> True
	6 -> False
	7 -> True
	8 -> False
	9 -> False
	10 -> False
	11 -> False
	12 -> False
	13 -> False
	14 -> True
	15 -> False

6.	Triples of Latin Letters
Write a program to read an integer n and print all triples of the first n small Latin letters, ordered alphabetically:
Examples
Input: 3
Output:
aaa aab aac aba abb abc aca acb
acc baa bab bac bba bbb bbc bca
bcb bcc caa cab cac cba cbb cbc
cca ccb ccc

6. Elevator
Calculate how many courses will be needed to elevate n persons by using an elevator of capacity of p persons. The input holds two lines: the number of people n and the capacity p of the elevator.
Input:	Output:	Comments:
17
3	6	5 courses * 3 people
		+ 1 course * 2 persons

4
5	1	All the persons fit inside in the elevator.
		Only one course is needed.


