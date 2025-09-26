import os

source = "C:\\Users\\admin\\Open Documents\\Code Stuff\\File Test Space\\test1.md"
destination = "C:\\Users\\admin\\Desktop\\test1.md"

try:
    if os.path.exists(destination): # Check if path exists
        print("There is already a file with the same name there")
    else:
        os.replace(source,destination)  # Replaces file
        print(f"{source} was moved")
except FileExistsError as e:
    print(e)
    print("File does not exist.")
