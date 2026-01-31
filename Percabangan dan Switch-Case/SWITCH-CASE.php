<?php
$warnaLampu = "kuning";

echo "Warna Lampu: " . $warnaLampu . "<br>";

switch ($warnaLampu) {
    case "merah":
        echo "Aksi: BERHENTI!";
        break;
        
    case "kuning":
        echo "Aksi: BERSIAP / HATI-HATI!";
        break;
        
    case "hijau":
        echo "Aksi: JALAN!";
        break;
        
    default:
    
        echo "Aksi: Lampu rusak atau warna tidak valid.";
}
?>