<option value=01 selected></option>
	  <?php
	$now=date('31');
	echo "<select name='tgl'>";
	for ($a=1;$a<=$now;$a++)
	{
		echo "<option value='".$a."'>".$a."</option>";
	}
	echo "</select>";
	?>
	
	<option value=Januari selected></option>
	<?php
	$bln=array(1=>"Januari","Februari","Maret","April","Mei","Juni","July","Agustus","September","Oktober","November","Desember");
	
	echo "<select name=bulan>
		<option value=Januari selected>Januari</option>";
	for($bulan=2; $bulan<=12; $bulan++){
    echo "<option value=$bulan>$bln[$bulan]</option>";
	}
	echo "</select>";
	?>
	
	<option value=1989 selected></option>
	<?php
	$now=date("Y");
	echo "<select name=tahun>
	<option value=1989 selected>1989</option>";
	for($thn=1901; $thn<=$now; $thn++){
	echo "<option value=$thn>$thn</option>";
	}
	echo "</select>";
	?>
	
    </div>
  </div>
  <br>