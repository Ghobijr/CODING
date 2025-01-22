# 1) Write a program to accept two number from user and calculate multiplication

num1 = int(input("Enter Number"))
num2 = int(input("Enter Second Number"))

print("Multiplication of the two numbers is {}".format(num1*num2))

# 2) Write a program to take three Names as input from user in single input() function call

name1, name2, name3= input("Enter three names").split() #use split() to seperate the words

print("Name 1",name1)
print("Name 2",name2)
print("Name 3",name3)

# 3) Assume you are taking Laptop type as Dell from user and its cost from user. Write program to . format() to print “I have DELL LAPTOP which costs around $1500 “

laptop=input("Enter Laptop Type")
cost= int(input("Enter Cost"))

print("I have a {} laptop which costs me ${}".format(laptop,cost))

# 4) Write a code to print your Name, Address, Qualification, Hobby. All entries should be taken from use

name=input("Enter your name")
address=input("Enter your address")
qualification=input("Enter your qualification")
hobby=input("Enter your Hobby")

print ("My name is {}, and my address is {}. My job qualification is {}. My greatest hobby is {}".format(name, address, qualification, hobby))