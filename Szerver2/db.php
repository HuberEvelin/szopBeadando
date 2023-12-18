<?php
$host="localhost";
$port=3306; //XAMPP haló
$socket="";
$user="root";
$password="";
$dbname="beadandoDB2";



$con = new mysqli($host, $user, $password, $dbname, $port, $socket)
    or die ("Kapcsolódás sikertelen: ".mysqli_connect_error());
if ($con->connect_errno > 0) {
    printf("Kapcsolódás sikertelen: %s\n", $con->connect_error);
    exit();
}

?>