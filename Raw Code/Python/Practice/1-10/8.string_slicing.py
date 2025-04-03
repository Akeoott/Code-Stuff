# slicing = create a substring by extracting elements from another string
#           indexing[start:stop:step]
#           slice(start,stop,step)

name = "Banana Man"

# Lets start with indexing[]

# the first value of a computer is 0 meaning B in Banana is the start with the value 0

first_name = name[0:6] # the start value is inclusive, the stop value is exclusive meaning i cant enter 0 and 5 as a start and stop
# you can also do: first_name = name[:6] since python asumes that that missing value is 0
last_name = name[7:10]
# you can also do: last name = name[7:] and it will go till the end and will have the same effect
funky_name = name[0:10:1] # the default step value is 1 and will do nothing

# if step is 2 it will jump over every second character with 3 over every third and so on...
funky_name = name[0:10:2]
# you can also do: funky_name = name[::2] since python will assume that star is 0 and stop is at the end.

print(first_name+" "+last_name) # will print "Banana Man"
print(first_name) # will print "Banana" ect...
print(funky_name) # will print "Bnn a"

# lets reverse this shit!

reversed_name = name[::-1] # its kinda like couting backwards if the step value is negative
print(reversed_name)



# Now slicing() wich will create a slice object wich is reusable and somewhat convenient.

website_1 = "https://google.com"
website_2 = "https://wikipedia.com"
# we only want the site name in this example
#           (start,stop,step)
# Since website length can varie we will use negative values as the stop value wich goes from right to left starting with 1 and not 0 since the stop value is exclusive
slice_1 = slice(8,-4)

print(website_1[slice_1]) # result = "google"
print(website_2[slice_1]) # result = "wikipedia"

# both use slice_1 wich can be named however you like, example: banana_slice_1 = slice(8,-4)