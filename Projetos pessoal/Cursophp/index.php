<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    

    <?php
        echo "<hr>";
            $times = array(
                "cariocas" => array("campeao"=>"vasco", "vice"=>"flamengo","terceiro"=>"borafogo"),
                "paulistas"=> array("santos","Sao paulo","palmeiras"),
                "baianos"=> array("bahia","vitoria","itabuna")
            );

            echo $times["paulistas"][1];
        echo "<hr>";
        echo "<br>";

            foreach($times["cariocas"] as $indice => $valor){
                echo $indice.": ".$valor."<br>";
            }
    
        echo "<hr>";
    ?>
</body>
</html>