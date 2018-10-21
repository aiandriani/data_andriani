<?php 
$id ="";
$nama_lengkap ="";
$Jenis_Kelamin ="";
$Tgl ="";
$Telepon ="";
$Email ="";
$Alamat ="";
$Kota ="";
$Kode_Pos ="";
$Catatan ="";
$action="produk_add.php";
if(isset($_GET['id'])){
	$id = $_GET['id'];
	include"koneksi.php";
	$query = "select * from member where memberId='".$id."'";
	$row = mysql_query($query);
	$res = mysql_fetch_array($row);
	$nama_lengkap = $res['namaLengkap'];
	$Jenis_Kelamin=$res['jenisKelamin'];
	$Tgl=$res['tglLahir'];
	$Telepon=$res['telepon'];
	$Email=$res['email'];
	$Alamat=$res['alamat'];
	$Kota=$res['kota'];
	$Kode_Pos=$res['kodePos'];
	$Catatan=$res['catatan'];
	
	$action ="produkupdate.php";
}
?>

<form method="POST" action="<?php echo $action;?>" enctype="multipart/form-data">
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Nama Lengkap</label>
    <div class="col-sm-10">
	<input type="hiden" name="id" value="<?php echo $id;?>">
      <input type="text" class="form-control"  value="<?php echo $nama_lengkap;?>" placeholder="Nama Lengkap" name="namaLengkap">
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Jenis Kelamin</label>
    <div class="col-sm-10">
      <input type="radio" value="pria" checked name="pilih" class="opt">Pria<br>
	  <input type="radio" value="wanita" name="pilih" class="opt">Wanita<br>
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Tanggal Lahir</label>
    <div class="col-sm-10">
      <input type="date" value="<?php echo $Tgl;?>" name="tgl">
	  </div>
	  </div>
	<br>
	  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Telepon</label>
    <div class="col-sm-10">
      <input type="text" class="form-control"  value="<?php echo $Telepon;?>" placeholder="Telepon" name="telepon">
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Email</label>
    <div class="col-sm-10">
      <input type="text" class="form-control" value="<?php echo $Email;?>" placeholder="Email" name="email">
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Alamat</label>
    <div class="col-sm-10">
      <input type="textarea" cols="30" rows="5" class="form-control" value="<?php echo $Alamat?>" placeholder="Alamat" name="alamat">
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Kota</label>
    <div class="col-sm-10">
      <input type="text" class="form-control"  value="<?php echo $Kota;?>" placeholder="Kota" name="kota">
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Kode Pos</label>
    <div class="col-sm-10">
      <input type="text" class="form-control"  value="<?php echo $Kode_Pos;?>" placeholder="Kode Pos" name="kodePos">
    </div>
  </div>
  <br>
  
  <div class="form-group row">
    <label for="colFormLabel" class="col-sm-2 col-form-label">Catatan</label>
    <div class="col-sm-10">
      <input type="text" class="form-control"  value="<?php echo $Catatan;?>" placeholder="Catatan" name="catatan">
    </div>
  </div>

<div class="button" ALIGN="CENTER" >
<button type="submit" class="btn btn-outline-primary" >Simpan</button>
<button type="submit" class="btn btn-outline-danger" >Batal</button>
</div>
  </form>
 