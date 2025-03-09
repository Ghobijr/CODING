# #Function is a block of code

# def calldemo(name): #definition of function
#     print("Hello World", name)

# calldemo("JG") #call of the function

################################

# def add_demo(number1, number2):
#     sum = number1 + number2
#     print("Sum  ", sum)
# add_demo(4,8)

################################

# numbers = {2,4,6,8,10}

# maxium = max (numbers)
# print(maxium)

# def welcome(name):

#   print("Hello, " + name + " Centennial College welcomes you!")

# welcome('James')

################################

# def agile_principle(principle, message):

#     """Summarize the principle."""

#     print(f"\nAgile team is  {principle} .")

#     print(f'Agile team :   "{message}"')

# agile_principle('Iterative ', 'Works on High Quality deliverables !')

# agile_principle(message="Populated by motivated individuals.", principle='self organized team')

################################


# print(f'round the value {round(12.6)}')

# mystring = 'Pythonooon'

# print('Length of', mystring, 'is', len(mystring))

################################

# #Exercise 1 

# def team_collaboration(first_software, second_software):
#     print(f"I use {first_software} and {second_software} for team collaboration")

# team_collaboration('Scrum', 'Trello')

################################

# #Exercise 2 

# project_id = 1
# project_Local_id = 2
# project_global_id = 3

# def project(project_Local_id = 2, project_global_id = 3):

#     print(f"My global project id is: {project_global_id}")
#     print(f"My internal project id is: {project_Local_id}")

# project()
    
################################
# import math

# def sqrt(number):
#     result = math.sqrt (number)
# print(result)

# print_sqrt(900)
#################################


# def my_function(*subject):

#   print("My favourite subject is " + subject[2])


# my_function("COMP100", "COMP213", "COMP120")

################################

# Importing Math library  

# import math 

# print(f'The value of pi is approximately {math.pi:.3f}.')

# print(f'Factorial {math.factorial(5)}')

# print(f'square root : {math.sqrt(25)}')

# ################################

# # Importing Date library  

# x = datetime.datetime.now()

# print(x)

# ################################

# # Importing random 
# for i in range(10):

#     print(random.randint(1, 25))

# ################################

# # OS Module 

# # The OS module in python provides functions for interacting with the operating system. OS, comes under Python’s standard utility modules.

# # The below code will get your current working directory, hence "cwd."

# # Example 

# import os 

# print(os.getcwd()) 

# curDir = os.getcwd()

# print(curDir)

# ################################

# # Printing the results 

# import pandas as pd

# import os

# cwd = os.getcwd()  # Get the current working directory (cwd)

# files = os.listdir(cwd)  # Get all the files in that directory

# print("Files in %r: %s" % (cwd, files))

################################
#Exercise 1

# import calendar
# year = 2025
# print(calendar.month(year, 10))

# #Exercise 2
# import math

# functions = {
#     "square root": math.sqrt(50),
#     "Factorial": math.factorial(10),
#     "Value of pi": math.pi,
#     "Value of e": math.e,
#     "Value of tau": math.tau
# }

# for name, result in functions.items():
#     if isinstance(result, float):
#         print(f'{name}: {result:.3f}')
#     else:
#         print(f'{name}: {result}')

# #Exercise 3

# import os

# new_directory = "new_folder"
# os.makedirs(new_directory, exist_ok=True)
# print(f"Directory '{new_directory}' created.")

# file_to_delete = os.path.join(new_directory, "file_to_remove.txt")

# # Create the file to ensure it exists
# with open(file_to_delete, 'w') as f:
#     f.write("This is a temporary file.")

# if os.path.exists(file_to_delete):
#     os.remove(file_to_delete)
#     print(f"File '{file_to_delete}' deleted.")
# else:
#     print(f"File '{file_to_delete}' does not exist.")


################################

# What is the output of the following program 

import statistics as stats

grades=[85,93,45,87,93]

stats.mean(grades)