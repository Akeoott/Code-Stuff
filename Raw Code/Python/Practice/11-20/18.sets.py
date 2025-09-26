# set = collection wich is unordered, unindexed. No duplicate values.

utensils = {"fork","spoon","knife"}
dishes = {"bowl","plate","cup","knife"}

if False:               # Deactivates this part of the script
    utensils.add("napkin")  # Adds specified item
    utensils.remove("fork") # Removes specified item
    utensils.clear()    # Clears out the list
    utensils.update(dishes) # Adds all items in dishes to utensils
    dinner_table = utensils.union(dishes)   # Crates a new set that contains the items from the 2 other sets

print(utensils.difference(dishes)) # displays what the first set does not have in common with the second set
print(utensils.intersection(dishes))    # displays what both sets have in common

if False:
    for i in dinner_table:
        print(i)
