<?php
include("./db.php");
$request = $_SERVER['REQUEST_METHOD'];

switch ($request) {
	case "GET": //A másik fájlban a regizstráció a GET
		if (!empty($_GET["username"]) && !empty($_GET["password"])) {
			if (login($_GET["username"], $_GET["password"])) {
				echo json_encode(array(
						'error' => 0,
						'message' => 'Sikeres bejelentkezés!'
					)
				);
			}
			else {
				echo json_encode(array(
						'error' => 1,
						'message' => 'Nincs ilyen felhasználó.'
					)
				);
			}
			
		} else {
			echo json_encode(array(
					'error' => 1,
					'message' => 'Hiányzó felhasználónév vagy jelszó'
				)
			);
		}
		break;
	default:
		header('Ismeretlen kérés!');
		break;
}

function login($u, $p) {
	global $con;
	
	$result = count($con -> query("SELECT * FROM users WHERE felhasznalonev = '$u' AND jelszo = MD5('$p');") -> fetch_all());
	return $result > 0;
}


?>