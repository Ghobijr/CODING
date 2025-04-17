# demofile = open ("demo.txt", "r")
# print (demofile.name())

# opens, reading, and printing the file
# with open ("demo.txt", "r") as file:
#    content_demo_file = file.read()
#    print (content_demo_file)


# with open ("demo.txt", "r") as file:
#     content_demo = file.readline()
#     while content_demo:
#         print (content_demo, end="")
 

# with open("demo.txt", "r") as file:
#     file.write("im learning writing to file")
#     print ("writing successful")





# 1)Reading File

f=open(r"D:\Studying\Centennial\CODING\COMP120\Python\Week 11\pi_digits.txt", "r")
print(f.read())

# 2)Reading using readline()

f=open(r"D:\Studying\Centennial\CODING\COMP120\Python\Week 11\pi_digits.txt", "r")
print(f.readline())
print(f.readline())
print(f.readline())


# 3) Write a number to the existing file Appending
f=open(r"D:\Studying\Centennial\CODING\COMP120\Python\Week 11\pi_digits.txt", "a")
f.write("3.77777777")

f.close()

f=open(r"D:\Studying\Centennial\CODING\COMP120\Python\Week 11\pi_digits.txt", "r")

print(f.read())