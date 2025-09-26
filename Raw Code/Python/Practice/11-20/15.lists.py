# list = used to store multiple items in a single variable
# a list is defined by doing this - list = ["something", "banana", "idk"]

# Current List
food = ["something","pizza","banana 1.0","children (they are cute)","plutonium-239 (my favourite)","Dont delete plutonium!"]

food[0] = 'banana 2.0' # Replace the selected item in list with new item.

if False:
    print(food[3]) # The first value is 0 since computers start with 0 (pizza = 0)

# List funktions!

from copy import deepcopy

if True:
    food.append("banana 3.0")   # adds the item to the end of the list
    food.remove("pizza")        # removes the item from the list
    food.pop()                  # will remove the last item on the list
    food.insert(4,"LOLCODE")    # inserts item to selected space
    food.sort()                 # sorts the list alphabetically
    more_food = food.copy()     # a shallow copy
    even_more_food = deepcopy(food) # a true copy with its own spot in memory (expensive performance)
if False:
    food.clear()                 # clears the entire list

# Test the outcome

if True:
    for x in food: # Displays everything
        print(x)

# Just for fun -
print("-"*30)
print(f"I LOVE TO EAT {food[5]}")
