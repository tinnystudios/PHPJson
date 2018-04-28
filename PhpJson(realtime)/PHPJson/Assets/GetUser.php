<?php

$userData = new \stdClass();
$userData->username = "John";
$userData->age = 20;
$userData->email = "tinnystudios@gmail.com";


$anySensitiveData = new \stdClass();
$anySensitiveData->password ="abcdefghij";

$userData->sensitiveData = $anySensitiveData;

$userDataJsonString = json_encode($userData);

echo $userDataJsonString;

?>