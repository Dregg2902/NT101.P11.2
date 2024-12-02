from cryptography.hazmat.primitives.asymmetric import rsa
from cryptography.hazmat.primitives.serialization import Encoding, PublicFormat
from binascii import unhexlify

# Hexadecimal representation of n and e
n_hex = ("A9FF9C7F451E70A8539FCAD9E50DDE4657577DBC8F9A5AAC46F1849ABB91DBC9FB2F01FB920900165EA01CF8C1ABF9782F4ACCD885A2D8593C0ED318FBB1F5240D26EEB65B64767C14C72F7ACEA84CB7F4D908FCDF87233520A8E269E28C4E3FB159FA60A21EB3C920531982CA36536D604DE90091FC768D5C080F0AC2DCF1736BC5136E0A4F7AC2F2021C2EB46383DA31F62D7530B2FBABC26EDBA9C00EB9F967D4C3255774EB05B4E98EB5DE28CDCC7A14E47103CB4D612E6157C519A90B98841AE87929D9B28D2FFF576A66E0CEAB95A82996637012671E3AE1DBB02171D77C9EFDAA176EFE2BFB381714D166A7AF9AB570CCC863813A8CC02AA97637CEE3")
e_hex = "65537"

try:
    # Convert hexadecimal to integers
    n = int(n_hex, 16)
    e = int(e_hex, 16)

    # Check for valid e and n
    if e <= 1 or e >= n:
        raise ValueError("Exponent 'e' should be between 1 and n.")

    # Create an RSA public key object
    public_key = rsa.RSAPublicNumbers(e, n).public_key()

    # Serialize the public key to PEM format
    pem = public_key.public_bytes(Encoding.PEM, PublicFormat.SubjectPublicKeyInfo)

    # Save the PEM file
    with open("public_key.pem", "wb") as f:
        f.write(pem)

    print("Khóa công khai đã được lưu vào file public_key.pem")

except ValueError as ve:
    print(f"Lỗi giá trị: {ve}")
except Exception as e:
    print(f"Đã xảy ra lỗi: {e}")
