<?php include "koneksi.php";?>
  <p>ISI MEMBERNYA YAAA........</p>                                                                                      
  <div class="table-responsive">          
  <table class="table table-bordered">
    <thead>
      <tr>
        <th>No</th>
        <th>Nama Lengkap</th>
		<th>Telepon</th>
        <th>Email</th>
        <th>Alamat</th>
		<th>Aksi kita </th>
      </tr>
    </thead>
    <tbody>
	
<?php 
	$query = "select * from member";
	$res = mysql_query($query);
	$no=1;
	while($row=mysql_fetch_array($res)){
	?>
      <tr>
        <td><?php echo $row['memberId'];?></td>
        <td><?php echo $row['namaLengkap'];?></td>
        <td><?php echo $row['telepon'];?></td>
        <td><?php echo $row['email'];?></td>
		<td><?php echo $row['alamat'];?></td>
        <td><a href="index.php?mod=produk_form&id=<?php echo $row['memberId'];?>"> Edit</a> |<a href="deleteform.php?mod=produk_form&id=<?php echo $row['memberId'];?>"> Delete</a></td>
      </tr>
	<?php } ?>
    </tbody>
  </table>
  </div>