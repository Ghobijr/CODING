student = {
    "Name": "Joe",
    "Dept": "Software Engineering"
}
faculty = {}

print(student["Name"])

print(student.get("age"))

student ["Dept"]= "Finance"
print(student["Dept"])

newkey= student.keys()
print(newkey)

# newValue = student.values()
# print(newValue)



# # LOOP to do something continuously. FOR is the command

for key, value in student.items():
    print(f"{key} : {value}")


    student["Name"] = "Joseph"
    print(student)