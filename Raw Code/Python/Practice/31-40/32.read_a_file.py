# Reading a file in python >

try:    # Error handling is important
    with open("C:\\Users\\admin\\Open Documents\\Code Stuff\\LICENSE.md") as file:   # With "with open" the file automatically closes at the end
        print(file.read())  # Will print the file content
except FileNotFoundError as e:  # Again error handling
    print(f"Error: {e}")
    print("File does not exist.")
