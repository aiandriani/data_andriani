<?php
include"koneksi.php";
$id=$_GET['id'];
$query="delete from member where memberId='$id'";
mysql_query($query);
header("location:index.php?mod=list");



?>