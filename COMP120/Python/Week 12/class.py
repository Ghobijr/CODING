# #classes and objects
# class Student:
#     name="Joe"
#     age= 0

#     # object method

# stud1 = Student()
# stud1.age = 20
# stud1.name = "John"
# print(stud1.name)

# import math

# class Circle:
#     def __init__(self, radius):
#         self.radius = radius
 
#     def cal_circle_area(self):
#         return math.pi * self.radius ** 2
        
# radius = int(input("Enter the radius of the circle: "))
# c1= Circle(radius)

# area_circle = c1.cal_circle_area()
# print("The area of the circle is: ", area_circle)


#Create a class Arithmetic to perform/calculate basic operations (+,/,*,-).

import math

class ArithmeticMethods:
    def __init__(self, firstNumber, secondNumber):
        self.firstNumber = firstNumber
        self.secondNumber = secondNumber
    def addition(self):
        return self.firstNumber + self.secondNumber
    def subtraction(self):
        return self.firstNumber - self.secondNumber
    def multiplication(self):
        return self.firstNumber * self.secondNumber
    def division(self):
        return self.firstNumber / self.secondNumber
input1 = int(input("Enter the first number: "))
input2 = int(input("Enter the second number: "))

finalResult = ArithmeticMethods(input1, input2)
print("The sum of your two numbers are: ", finalResult.addition())      
print("The difference of your two numbers are: ", finalResult.subtraction())
print("The multiplication of your numbers are: ", finalResult.multiplication())
print("The division of your two numbers are: ", finalResult.division())


#Create a student class  and include attributes like name, address, DOB, contact, and course, and age. Create a method 
# to calculate the age of a student.

import datetime

class StudentInformation:
    def __init__(self, name, address, dob, contact, course):
        self.name = name
        self.address = address
        self.dob = dob
        self.contact = contact
        self.course = course

    def calculate_student_age(self):
        today = datetime.date.today()
        dob_year, dob_month, dob_day = map(int, self.dob.split('-'))
        age = today.year - dob_year - ((today.month, today.day) < (dob_month, dob_day))
        return age

name = input("Enter your name: ")
address = input("Enter your address: ")
dob = input("Enter your date of birth (YYYY-MM-DD): ")
contact = input("Enter your contact number: ")
course = input("Enter your course: ")

student = StudentInformation(name, address, dob, contact, course)
print(f"Student Name: {student.name}")
print(f"Student Address: {student.address}")
print(f"Student DOB: {student.dob}")
print(f"Student Contact: {student.contact}")
print(f"Student Course: {student.course}")
print(f"Student Age: {student.calculate_student_age()}")





