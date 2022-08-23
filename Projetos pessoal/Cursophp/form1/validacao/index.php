<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Teste form 1</title>
</head>
<body>

    <?php
        if(isset($_POST['enviar-form'])):
            //array de erros
            $erros = array();

            //Validações
            if(!$idade = filter_input(INPUT_POST, 'idade', FILTER_VALIDATE_INT)):
                $erros[] = "Idade precisa ser um inteiro";
            endif;

            if(!$email = filter_input(INPUT_POST, 'email', FILTER_VALIDATE_EMAIL)):
                $erros[] = "Email invalido";
            endif;

            if(!$Peso = filter_input(INPUT_POST, 'Peso', FILTER_VALIDATE_FLOAT)):
                $erros[] = "Insira o Peso correto";
            endif;

            if(!$ip = filter_input(INPUT_POST, 'ip', FILTER_VALIDATE_IP)):
                $erros[] = "IP invalido";
            endif;

            if(!$url = filter_input(INPUT_POST, 'url', FILTER_VALIDATE_URL)):
                $erros[] = "URL invalido";
            endif;
            
            //exibindo mensagem
            
            if(!empty($erros)):
                foreach($erros as $erro):
                    echo "<li> $erro </li>";
                endforeach;
            else:
                echo "Parabens dados corretos";
            endif;

        endif;
    ?>

    <form action="<?php echo $_SERVER['PHP_SELF']; ?>" method="POST">
    Idade: <input type="texto" name="idade"><br>
    Email: <input type="texto" name="email"><br>
    Peso: <input type="texto" name="Peso"><br>
    IP: <input type="texto" name="ip"><br>
    URL: <input type="texto" name="url"><br>
    <button type="submit" name="enviar-form"> Enviar</button>
    </form>
    
</body>
</html>