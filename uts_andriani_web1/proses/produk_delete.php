<?php

include"koneksi.php";
$id = $_GET['id'];
$query = "DELETE FROM member WHERE memberId='$id'";
mysql_query($query);

header("location:../index.php?mod=list");
?>