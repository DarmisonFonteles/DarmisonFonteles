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

            //sanitize

            $nome = filter_input(INPUT_POST, 'nome', FILTER_SANITIZE_SPECIAL_CHARS);
            

            $idade = filter_input(INPUT_POST, 'idade', FILTER_SANITIZE_NUMBER_INT);
            if(!filter_var($idade, FILTER_VALIDATE_INT)):
                $erros[] = "Idade precisa ser um inteiro";
            endif;

            $email = filter_input(INPUT_POST, 'email', FILTER_SANITIZE_EMAIL);
            if(!filter_var($email, FILTER_VALIDATE_EMAIL)):
                $erros[] = "Email invalido";
            endif;
            
            $url = filter_input(INPUT_POST, 'url', FILTER_SANITIZE_URL);
            if(!filter_var($url, FILTER_VALIDATE_URL)):
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
    Nome: <input type="texto" name="nome"><br>
    Idade: <input type="texto" name="idade"><br>
    Email: <input type="texto" name="email"><br>
    URL: <input type="texto" name="url"><br>
    <button type="submit" name="enviar-form"> Enviar</button>
    </form>
    
</body>
</html>