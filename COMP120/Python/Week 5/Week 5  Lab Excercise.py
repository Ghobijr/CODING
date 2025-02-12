# Task 1

favorite_languages = {
    "jen": "HTML",
    "sarah": "c",
    "edward": "ruby",
    "phil": "C#",
    }

favorite_languages ["phil"] = "Python"  # Changing the value of the key "phil"
print(favorite_languages["phil"])  

favorite_languages ["Joe"] = "C++"     # Adding a new key and value to the dictionary
print(favorite_languages)

favorite_languages.pop("Joe")     # Removing a key and value from the dictionary
print(favorite_languages)

print(favorite_languages.values())  # Printing the values of the dictionary

# Task 2

students = {
    "Name": "Joe",
    "Age": "Software Engineering",
    "Subject": "Software Engineering",
    "Semester" : "Winter",
    "Grade": "A",   
    "Lab Keys": "Yes",
}

for key, value in students.items():  # Looping through the dictionary
    print(f"{key} : {value}")