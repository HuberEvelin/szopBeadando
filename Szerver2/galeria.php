<?php

include("./db.php");

$request = $_SERVER['REQUEST_METHOD'];

switch ($request) {
	case "GET": //Összes rajz lekérése
		if (empty($_GET["current_user_name"]) || 
			empty($_GET["current_user_password"]) || 
			!userExist($_GET["current_user_name"], $_GET["current_user_password"])) {
			echo json_encode(
				array(
					'error' => 1,
					'message' => 'Hiba!'
				)
			);
			exit;
		}
	
		echo json_encode(
			array(
				'error' => 0,
				'message' => 'Összes rajz megjelenítése',
				'cars' => getRajzok()
			)
		);
		break;
	case "POST": //Új rajz hozzáadása
		if (empty($_POST["current_user_name"]) || 
			empty($_POST["current_user_password"]) || 
			!userExist($_POST["current_user_name"], $_POST["current_user_password"])) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Hiba!'
				)
			);
			exit;
		}
	
		if (!empty($_POST["new_drawing_name"]) && !empty($_POST["new_drawing"]))
		{
			addRajz($_POST["new_drawing_name"],$_POST["new_drawing"]);
		}
		else {
			echo json_encode(array(
						'error' => 1,
						'message' => 'Hiányos adatok!'
					)
				);
		}
		break;
	default:
		header('Ismeretlen kérés!');
		break;
}

function getRajzok() {
	global $con;
	
	$result = $con -> query("SELECT * FROM galeria;");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}

function addRajz($drawingName, $drawing) {
	global $con;
	$count = count($con -> query("SELECT * FROM galeria WHERE rajzNev = '$drawingName';") -> fetch_all(MYSQLI_ASSOC));
	if ($count == 0) {
		$result = $con -> query("INSERT INTO galeria (rajzNev, rajz) VALUES ('$drawingName', '$drawing');");
		echo json_encode(
			array(
				'error' => 0,
				'message' => 'Új rajz hozzáadva!'
			)
		);
	}
	else {
		echo json_encode(array(
				'error' => 1,
				'message' => 'Már létezik rajz ezzel a névvel!'
			)
		);
	}
}

?>