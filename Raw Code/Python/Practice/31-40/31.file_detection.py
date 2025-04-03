# The basics of file detection

import os

path_README = "C:\\Users\\admin\\Documents\\Code Stuff\\Raw Code\\Python\\Practice\\README.txt"

if os.path.exists(path_README): # Checks if path exists
    print("Your read me exists!")

    if os.path.isfile(path_README): # Checks if path is a file
        print("That is a file")
    elif os.path.isdir(path_README):    # Checks if path is a directory
        print("That is a directory")
else:
    print("That locations doesn't exist.")  # If path doesnt exist, it will print this