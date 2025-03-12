# Question 1
# 1. Use the above table data. Create a dictionary. use for loop to display the
# results
# 2. Use the same data. Create a list, display the results.
# 3. Write your understanding of the difference between list and dictionary

# medals_dict = {
#     "Canada": {"Gold": 2, "Silver": 0, "Bronze": 2},
#     "OAR": {"Gold": 1, "Silver": 2, "Bronze": 0},
#     "Japan": {"Gold": 1, "Silver": 1, "Bronze": 0},
#     "China": {"Gold": 0, "Silver": 1, "Bronze": 0},
#     "Germany": {"Gold": 1, "Silver": 0, "Bronze": 0}
# }

# print("1. Dictionary Implementation:\n")
# # Looping through the dictionary to display results
# for country, medal_counts in medals_dict.items():
#     print(f"{country}:")
#     for medal_type, count in medal_counts.items():
#         print(f"  {medal_type}: {count}")
#     print()  # Empty line for better readability

# Question 1.2: Create a list and display results

# medals_list = [
#     ["Nation", "Gold", "Silver", "Bronze"],
#     ["Canada", 2, 0, 2],
#     ["OAR", 1, 2, 0],
#     ["Japan", 1, 1, 0],
#     ["China", 0, 1, 0],
#     ["Germany", 1, 0, 0]
# ]

# print("\nList Implementation:\n")
# # Display the list data in a formatted way
# for row in medals_list:
#     if row[0] == "Nation":  # Header row
#         print(f"{row[0]:<10} {row[1]:<6} {row[2]:<6} {row[3]:<6}")
#         print("-" * 30)  # Separator line
#     else:  # Data rows
#         print(f"{row[0]:<10} {row[1]:<6} {row[2]:<6} {row[3]:<6}")

# Question 2

# Use Copilot chat and perform the following .
# 1. open the csv file called "nfl_offensive_stats.csv" and read in the csv data from
# the file
# 2. Include the prompt and execute the code
# 3. the 3rd column in data is player position, the fourth column ③ is the player,
# and the 8th column is the passing yards. ③ For each player whose position in
# column 3 is "QB", determine the sum of yards from column
# 4. print the sum of the passing yards sorted by sum of passing yards in
# descending order

# import csv
# from collections import defaultdict
# import os

# # Get the directory of the current script
# script_dir = os.path.dirname(__file__)
# file_path = os.path.join(script_dir, 'nfl_offensive_stats.csv')

# passing_yards = defaultdict(int)

# # Open the csv file called "nfl_offensive_stats.csv" and read in the csv data from the file
# with open(file_path, mode='r') as file:
#     reader = csv.reader(file)
#     next(reader)  # Skip the header row
#     for row in reader:
#         position = row[2]
#         player = row[3]
#         yards = int(row[7])
#         if position == "QB":
#             passing_yards[player] += yards

# # Print the sum of the passing yards sorted by sum of passing yards in descending order
# sorted_passing_yards = sorted(passing_yards.items(), key=lambda x: x[1], reverse=True)

# print("Sum of passing yards for each QB (sorted by passing yards in descending order):")
# for player, yards in sorted_passing_yards:
#     print(f"{player}: {yards}")


#Question 3
# John is signing up for a new social network website called ProgrammerBook.
# He wants to make sure that his password is strong.
# 2. John starts with a modest definition of what it means for a password to be
# strong: it’s strong if it’s not the word password and not the word qwerty.
# (Those are terrible passwords, for sure, but in reality, we have to do way
# better than this definition to ensure that our password is strong!) A helpful
# function would be one that takes a proposed password and tells us whether it
# is strong or not.
# 3. Unlike our previous functions in this chapter, we’re not dealing with numbers
# here. The parameter, the password to check, is text. And the return value is
# supposed to indicate some yes/no result. We need new types!
# 4. The Python type for text is called a string. There are zillions of possible
# strings because we can use a string to store whatever text we want. And the
# Python type for a yes/no result is called a Boolean or bool. A bool has only
# two values: True or False.


# def is_strong_password(password):
#     # Check if the password is not "password" or "qwerty"
#     if password.lower() in ["password", "qwerty"]:
#         return False
#     return True

# # Example usage
# passwords_to_test = ["password", "qwerty", "gafiltefish123", "GafilteFish12#"]

# for pwd in passwords_to_test:
#     if is_strong_password(pwd):
#         print(f"The password '{pwd}' is strong.")
#     else:
#         print(f"The password '{pwd}' is not strong.")


# Question 4
# Use prompt engineering technique . use the below to determining the largest
# number of students that can be added to a row. Explain your understanding .

def most_students(classroom):
    '''
    classroom is a list of lists
    Each ' ' is an empty seat
    Each 'S' is a student
    How many new students can sit in a row?
    '''
    max_empty_seats = 0

    for row in classroom:
        empty_seats = row.count(' ')  # Count the number of empty seats in the row
        if empty_seats > max_empty_seats:
            max_empty_seats = empty_seats  # Update the maximum if current row has more empty seats

    return max_empty_seats

# Example usage
classroom = [
    ['S', ' ', 'S', ' ', ' '],
    [' ', ' ', 'S', 'S', ' '],
    ['S', 'S', 'S', ' ', ' '],
    [' ', ' ', ' ', ' ', ' ']
]

print(f"The largest number of students that can be added to a row is: {most_students(classroom)}")