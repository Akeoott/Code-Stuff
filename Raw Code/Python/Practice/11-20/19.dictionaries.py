#   Dictionary  =   A changable, unordered collection of unique key:value pairs
#                   Fast because they use hashing, allow us to access a value quickly

capitals = {'USA':'Washington DC','India':'New Dehli','China':'Beijing','Russia':'Moscow'}

capitals.update({'Germany':'Berlin'})   # Adds a key and value to the dictionary
capitals.update({'USA':'Banana DC'}) # Replacec a value with the selected key

if False:
    capitals.pop('China')   # Removes the key with the value
    capitals.clear()        # Clears the entire dictionary


    print(capitals['Germany']) # Not safe if item is not in dictionary. (Will cause error)
    print(capitals.get('Germany')) # Will print None instead of crashing. (Much safer)
    print(capitals.keys()) # Will print only the keys
    print(capitals.values()) # Will print only the values
    print(capitals.items()) # Will print both keys and values

for key,value in capitals.items(): # Displays all key, value pairs in a dictionary
    print(key,value)