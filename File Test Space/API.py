import requests

# Replace <Replace with MD5, SHA-1 or SHA-256 Hash> with the actual hash of the file you want to pull information from.
url = "https://www.virustotal.com/api/v3/files/<Replace with MD5, SHA-1 or SHA-256 Hash>"

headers = {
    "accept": "registrydictionary/json",

    # Replace <Your-API-Key> with your actual VirusTotal API key.
    "x-apikey": "<Your API Key>"
}

response = requests.get(url, headers=headers)

print(response.text)
