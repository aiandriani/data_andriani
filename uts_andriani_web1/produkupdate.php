<?php
include "koneksi.php";

$id = $_POST['id'];
$nama_lengkap = $_POST['namaLengkap'];
$Jenis_Kelamin=$_POST['pilih'];
$Tgl=$_POST['tglLahir'];
$Telepon=$_POST['telepon'];
$Email=$_POST['email'];
$Alamat=$_POST['alamat'];
$Kota=$_POST['kota'];
$Kode_Pos=$_POST['kodePos'];
$Catatan=$_POST['catatan'];

$query="UPDATE member SET namaLengkap='$nama_lengkap', jenisKelamin='$Jenis_Kelamin', tglLahir='$Tgl', telepon='$Telepon', email='$Email', alamat='$Alamat', kota='$Kota', kodePos='$Kode_Pos', catatan='$Catatan' WHERE memberId='$id'";
mysql_query($query);

header("location:index.php?mod=list");

?>