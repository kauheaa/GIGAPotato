<?php
	$text1 = $_POST["name"];
	$text2 = $_POST["age"];
	$text3 = $_POST["score"];

	if ($text1 != "")
	{
		echo("Data succesfully sent!");
		echo("Field 1:" . $text1);
		echo("Field 2:" . $text2);
		echo("Field 3:" . $text3);
		$file = fopen("data.txt", "a");
		fwrite($file, $text1);
		fwrite($file, $text2);
		fwrite($file, $text3);
		fclose($file);
	}
	else
	{
		$file = fopen("data.txt", "r");
		echo fread($file, filesize("data.txt"));
		fclose($file);
	}
?>