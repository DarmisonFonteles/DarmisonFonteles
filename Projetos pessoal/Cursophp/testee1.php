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

        function exibirnome($nome){
            echo "Exibir nome e $nome";
        }

        exibirnome("Adriele santos");
        
        echo "<hr>";

        function calnotas($nome, $nota1, $nota2, $nota3, $nota4 ){
            $media = ($nota1 + $nota2 + $nota3 + $nota4) / 4;
            if($media >= 7):
                echo "Aluno $nome aprovado com nota $media";
            else:
                echo "Aluno $nome repovado";
            endif;
        }

        calnotas("Bob", 4, 6, 8, 10);

        echo "<hr>";

        $x = 10;
        $y = 5;

        function soma() {
            echo $GLOBALS['x'] + $GLOBALS['y'];
        }
        soma();

        echo "<hr>";

        echo $_SERVER['PHP_SELF']."<br>";
        echo $_SERVER['SERVER_NAME']."<br>";
        echo $_SERVER['SCRIPT_FILENAME']."<br>";
        echo $_SERVER['DOCUMENT_ROOT']."<br>";
        echo $_SERVER['SERVER_PORT']."<br>";
        echo $_SERVER['REMOTE_ADDR']."<br>";
    ?>
</body>
</html>