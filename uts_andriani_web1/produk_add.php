<?php
include "koneksi.php";

$memberId = getautoid('memberid','member','mmb');
$nama_lengkap = $_POST['namaLengkap'];
$Jenis_Kelamin = $_POST['jenisKelamin'];
$Tgl = $_POST['tglLahir'];
$Telepon = $_POST['telepon'];
$Email = $_POST['email'];
$Alamat = $_POST['alamat'];
$Kota = $_POST['kota'];
$Kode_Pos = $_POST['kodePos'];
$Catatan = $_POST['catatan'];

$query="INSERT INTO `olshop`.`member` (`memberId`, `namaLengkap`, `jenisKelamin`, `tglLahir`, `telepon`, `email`,`alamat`, `kota`, `kodePos`, `catatan`) VALUES ('$memberId', '$nama_lengkap', '$Jenis_Kelamin', '$Tgl', '$Telepon', '$Email', '$Alamat', '$Kota', '$Kode_Pos', '$Catatan')";

mysql_query($query);

header("location:index.php?mod=produk_form");





?>
