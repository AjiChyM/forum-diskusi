umur = 15

print(f"Umur pengunjung: {umur} tahun")

if umur < 5:
    harga = 0
    kategori = "Balita (Gratis)"
elif umur <= 12:
    harga = 25000
    kategori = "Anak-anak"
elif umur <= 60:
    harga = 50000
    kategori = "Dewasa"
else:
    harga = 30000
    kategori = "Lansia"

print(f"Kategori: {kategori}")
print(f"Harga Tiket: Rp {harga}")