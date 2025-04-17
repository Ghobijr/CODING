# Define the table as a list of lists
tv_shows_by_age = [
    ["Age", "Show"],  # Header row
    ["30-39", "Friends"],
    ["20-29", "The Office"],
    ["10-19", "Pretty Little Liars"],
    ["0-9", "Chi's Sweet Home"]
]

# Display the table
print("Possible Favorite TV Shows by Age")
print("-" * 35)  # Separator line for better formatting
for row in tv_shows_by_age:
    print(f"{row[0]:<10} {row[1]:<20}")  # Format columns for alignment