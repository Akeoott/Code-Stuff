# indeg operator [] =   gives acces to a sequence's element (str,list,tuples...)

name = "Brown Banana!"

if False:
    if(name[0].islower):            # check if the selected letter is a capital
        name = name.capitalize()    # if true, it will capitalize it

first_name = name[:5].upper()   # will assign selected part to a new variable and additionally make is all upper case
last_name = name[6:12].lower()  # will assign selected part to a new variable and additionally make is all lower case
last_character = name[-1]   # will assign selected part to a new variable but backwards [-1]

print(first_name)
print(last_name)
print(last_character)
