# 1. Python program to check if input number is even or odd
# 2. Python program to print multiplication table from 1 to 10.

#1
num = int(input("Enter a number: "))
print("Even" 
      if num % 2 == 0 
      else "Odd")

#2
for num1 in range(1,5):
    for num2 in range(1,5):
        print(f"{num1} * {num2} = {num1*num2}")
