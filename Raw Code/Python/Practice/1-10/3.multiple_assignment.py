# multiple assignments = allows us to assign multiple variables at the same time in one line of code

# if multiple_assignments = False

name = "Banana Man"
age = 21
attractive = True

# if multiple_assignments = True

name, age, attractive = "Banana Man", 21, True



# If value is the same like example

Spongebob = 30
Patrick = 30
Sandy = 30
Squidward = 30

# Use this instead-

Spongebob = Patrick = Sandy = Squidward = 30    # This can then be printed...

# Result

print("My name is "+name+". I am "+str(age)+" years old and it's "+str(attractive)+" that im attractive <3")

print(Spongebob, Patrick, Sandy, Squidward)
