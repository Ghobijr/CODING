# To make codes into comments, select the code and hold CTRL /

#Integer
number_one = 7 
print(number_one)

# float_number means the value presented will be a number
float_number = 8.7
print(float_number)
#or
float_number = float (8.7)
print (float_number)

# .format tells the code which entry goes into the {} first and then the sequences after. 
laptop=input("Enter Laptop Type")
cost= int(input("Enter Cost"))
print("I have a {} laptop which costs me ${}".format(laptop,cost))

# .split to seperate the words
name1, name2, name3= input("Enter three names").split() 

print("Name 1",name1)
print("Name 2",name2)
print("Name 3",name3)

#string means the value will be a variable, most likely a word and NOT a number
string_one = "Joseph"
print(string_one)
string_two = 'Ghobi'
print(string_two)

#Adding Integers together
num1=7
num2=8
num3=num1 + num2
print(num3)

#Adding Strings together
string1="Hello"
string2="Students"
string3=string1+ " " +string2
print(string3)

# Multiple Assignments
a,b=5,6
print(a,b)

#Practice Questions
#Adding Integers and Strings together
num1=1
num2=2
string1="Learner"
print(num1+num2+string1)

#Adding float numbers together
num1=5.5
num2=1.8
num3=num1+num2
print(num3)

#Conversions
print(float(5))
print(int(5.5))
print(complex(7))

#Bool means (T or F)  or (1 or 0)
# = assign , == means equal too

print(19>15)
print(20==20)

print(bool("0"))

# Numeric Equations
result = 3 + 7 / 6
print(result)

# % gives the remainder
Remainder = 13 % 2
print(Remainder)

# ** means the square root

findasqaure  = 8 ** 2
findacube = 9 ** 3
print(findasqaure)
print(findacube)

#To print the same thing multiple times
multipleprinting="python" * 11
print(multipleprinting)

# Round to the nearest number
result=1+2
print(result)

# To get entry from user

firstname = input("Enter your first name")
print(firstname)