<?php
    //Conexão com banco de dados

    $servename = "localhost";
    $username = "root";
    $password = "";
    $db_name = "sistemalogin";

    $connect = mysqli_connect($servename, $username, $password, $db_name);
    
    //verifica a conexão
    if(mysqli_connect_error()):
        echo "Falha na conexão: ".mysqli_connect_error();
    endif;


?>