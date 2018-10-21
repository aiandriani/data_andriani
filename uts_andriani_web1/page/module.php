<?PHP
if(isset($_GET['mod'])){
$page= $_GET['mod'];

switch($page){
	case "produk_form":
		include "page/produk_form.php";
		break;
		case "list";
		include "list.php";
		break;
    }
}
else{
	echo "module hilang ";
}
?>