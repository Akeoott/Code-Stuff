import os   # Needed to delete stuff
import shutil   # Needed to delete folders containing files

path = "C:\\Users\\admin\\Open Documents\\Code Stuff\\File Test Space\\test1.md"

try:    # Error handling
    if os.path.isfile(path):
        os.remove(path) # The thing that deletes the file
    else:
        shutil.rmtree(path) # Deletes the entire path with anything inside it.
                            # This can be dangerous as it deletes the file and anything that is contained within it.
    
    if False:
        os.rmdir(path)  # The thing that deletes empty directories

except FileNotFoundError as e:  # More optional error handling
    print(e)
except PermissionError as e:
    print(e)
except OSError as e:
    print(e)
except Exception as e:
    print(e)
else:
    print(f"Successfully deleted: {path}")