import requests

url = "https://www.virustotal.com/api/v3/files/60c7225ef52d2a5a77463c3450a56c67a0af99dc9a4c337f06a18f11b702d2ff"

headers = {
    "accept": "registrydictionary/json",
    "x-apikey": "0ebd6106b59598f1b56ba336c1b2bf36fecfac7c37d310d0218095283d316000"
}

response = requests.get(url, headers=headers)

print(response.text)