<?php

include("./db.php");
$request = $_SERVER['REQUEST_METHOD'];

switch ($request) { //Felhasználók listájának lekérése
	case "GET":
		if (empty($_GET["current_user_name"]) || 
			empty($_GET["current_user_password"]) || 
			!userExist($_GET["current_user_name"], $_GET["current_user_password"])) {
			echo json_encode(
				array(
					'error' => 1,
					'message' => 'Ehhez be kell jelentkezned!'
				)
			);
			exit;
		}
		echo json_encode(
			array(
				'error' => 0,
				'message' => 'Felhasználók listája',
				'users' => getUsers()
			)
		);
		break;

		case "POST": //Regisztráció
			if (!empty($_POST["new_user_name"]) && !empty($_POST["new_user_password"]))
			{
				addNewUser($_POST["new_user_name"],$_POST["new_user_password"]);
			}
			else {
				echo json_encode(array(
							'error' => 1,
							'message' => 'Hiányos felhasználónév vagy jelszó!'
						)
					);
			}
			break;	

	case "DELETE": //Felhasználó törlése
		$content = file_get_contents('php://input');
		$data = json_decode($content, true);
		
		if (empty($data["current_user_name"]) || 
			empty($data["current_user_password"]) || 
			!userExist($data["current_user_name"], $data["current_user_password"])) {
				echo json_encode( 
				array(
					'error' => 1,
					'message' => 'Ehhez be kell jelentkezned!'
				)
			);
			exit;
		}
		
		if (!empty($data["id"]))
		delUser($data["id"]);
		break;

	default:
		header('Ismeretlen kérés!');
		break;
}

//Összes felhasználó lekérése
function getUsers() {
	global $con;
	
	$result = $con -> query("SELECT * FROM users;");
	
	return $result->fetch_all(MYSQLI_ASSOC);
}

//Bejelentkeztetés
function login($u, $p) {
	global $con;
	$result = count($con -> query("SELECT * FROM users WHERE felhasznalonev = '$u' AND jelszo = MD5('$p');") -> fetch_all());
	return $result > 0;
}

//Regisztráció
function addNewUser($username, $password) {
	global $con;
	$count = count($con -> query("SELECT * FROM users WHERE felhasznalonev = '$username';") -> fetch_all(MYSQLI_ASSOC));
	if ($count == 0) {
		$result = $con -> query("INSERT INTO users (felhasznalonev, jelszo) VALUES ('$username', md5('$password'));");
		echo json_encode(
			array(
				'error' => 0,
				'message' => 'Sikeres regisztráció!'
			)
		);
	}
	else {
		echo json_encode(array(
				'error' => 1,
				'message' => 'Már létezik ilyen nevű felhasználó!'
			)
		);
	}
}

//Felhasználó törlése
function delUser($id) {
	global $con;
	$con -> query("DELETE FROM users WHERE id = '$id';");
	echo json_encode(
		array(
			'error' => 0,
			'message' => 'Felhasználói fiók sikeres törölve!'
		)
	);
	$con -> close();
}

//Felhasználó ellenőrzés
function userExist($u, $p) {
	global $con;
	
	$result = count($con -> query("SELECT * FROM users WHERE felhasznalonev = '$u' AND jelszo = MD5('$p');") -> fetch_all());
	return $result > 0;
}
?>