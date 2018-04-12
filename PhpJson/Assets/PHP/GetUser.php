<?php
$someClass = new \stdClass();
$someClass->developerName = "SomeDeveloper";
$someClass->rank = 82;

$myObj = new  \stdClass();

$myObj->username = "John";
$myObj->age = 30;
$myObj->city = "New York";
$myObj->hasChildren = true;
$myObj->points = 19;
$myObj->developer = $someClass;

$myJSON = json_encode($myObj);

echo $myJSON;
?>