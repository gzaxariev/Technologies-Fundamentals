<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>

<?php

if (isset($_GET['num'])){

    $n = intval($_GET['num']);
    $count = $n+1;

    for ($i=0; $i < $n; $i++) {

        $count--;
        if ($count % 2 != 0){
            echo $count, " ";
        }
    }

}


?>

</body>
</html>