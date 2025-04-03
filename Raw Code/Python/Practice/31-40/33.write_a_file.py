# Lets write something in a file!

text = "I HATE **NI-**...\n*Nightmares!*\n\nI definitely meant to say *that*!"
more_text = "\n\nBananas taste good <3"

with open("C:\\Users\\admin\\Open Documents\\Code Stuff\\File Test Space\\test1.md","w") as file: # The "w" means write.
    file.write(text)

# This will overwrite everything in the file and if it doesnt exist it will make the file.

with open("C:\\Users\\admin\\Open Documents\\Code Stuff\\File Test Space\\test1.md","a") as file:
    file.write(more_text)

# The "a" means append MEANING it will add text instead of replacing everything.