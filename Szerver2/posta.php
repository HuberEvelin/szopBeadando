<?php

include("./db.php");

global $con;
$request = $_SERVER['REQUEST_METHOD'];
$myfile = fopen("testfile1.txt", "w"); //TESZTELÉS
$teszteles = $con -> query("SELECT * FROM users;");
fwrite($myfile,var_dump($teszteles));

switch ($request) {
	case "GET": //Felhasználó üzeneteinek lekérése
		$myfile = fopen("testfile2.txt", "w"); //TESZTELÉS
		fwrite($myfile,"GET kérésig eljutottunk."); //TESZTELÉS
		if (empty($_GET["current_user_name"]) || 
			empty($_GET["current_user_password"])) {
			echo json_encode(
				array(
					'error' => 1,
					'message' => 'Ehhez be kell jelentkezni!'
				)
			);
			exit;
		}

		$currentUserName = $_GET["current_user_name"];
		$currentUserPassword = $_GET["current_user_password"];
		fwrite($myfile,$currentUserName); //TESZTELÉS
		fwrite($myfile,$currentUserPassword); //TESZTELÉS
		

		echo json_encode(
			array(
				'error' => 0,
				'message' => 'Üzenetek megjelenítése',
				'tartalom' => getUzenetek($currentUserName)
			)
		);
		break;
	case "POST": //Új üzenet hozzáadása
		if (empty($_POST["current_user_name"]) || 
			empty($_POST["current_user_password"]) ) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Hiba!'
				)
			);
			exit;
		}
	
		if (!empty($_POST["new_user_name"]) && !empty($_POST["new_user_password"]))
		{
			addUzenet($_POST["current_user_name"],$_POST["other_user_name"],$_POST["message_id"]);
		}
		else {
			echo json_encode(array(
						'error' => 1,
						'message' => 'Hiányos adatok!'
					)
				);
		}
		break;
	case "DELETE": //üzenet törlése
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		
		if (empty($data["current_user_name"]) || 
			empty($data["current_user_password"])) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Hiba!'
				)
			);
			exit;
		}
		
		if (!empty($data["id"]))
		delUzenet($data["id"]);
		break;
	default:
		header('Ismeretlen kérés!');
		break;
}

function getUzenetek($username) {
	global $con;

	$myfile = fopen("testfile3.txt", "w"); //TESZTELÉS JÓ
	fwrite($myfile, $username); //TESZTELÉS JÓ

	$cimzett  = $con -> query("SELECT id FROM users WHERE felhasznalonev = '$username';");
	$cimzett = $cimzett -> fetch_row();
	$cimzett = $cimzett[0];

	fwrite($myfile, $cimzett);  //TESZTELÉS JÓ

	$stmt = $con->prepare("SELECT * FROM uzenetek WHERE cimzett_id = ?");
	$stmt->bind_param("s", $cimzett);
	$stmt->execute();
	$result = $stmt->get_result();
	$result = $result->fetch_all(MYSQLI_ASSOC);
	$stmt->close();

	if (!$result) {
		fwrite($myfile, "Hiba az üzenetek lekérdezésekor: " . $con->error . "\n");
	} else {
		fwrite($myfile, "Üzenetek lekérdezése sikeres.\n");
	}

	return $result;
}

function addUzenet($kuldo, $cimzett, $uzenet_id) {
	global $con;
	$kuldo_id = $con -> query("SELECT id FROM users WHERE felhasznalonev = $kuldo;");
	$cimzett_id = $con -> query("SELECT id FROM users WHERE felhasznalonev = $cimzett;");
	$result = $con->query("INSERT INTO uzenetek (kuldo_id, cimzett_id, uzenet_id) VALUES ('$kuldo_id', '$cimzett_id', '$uzenet_id');");
	echo json_encode(
		array(
			'error' => 0,
			'message' => 'Üzenet elküldve'
		)
	);
}

function delUzenet($id) {
	global $con;
	$con -> query("DELETE FROM uzenetek WHERE id = '$id';");
	echo json_encode(
		array(
			'error' => 0,
			'message' => 'Üzenet törölve.'
		)
	);
	$con -> close();
}

?>