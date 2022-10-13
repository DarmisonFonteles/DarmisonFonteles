$(document).ready(function(){
    /*
    $('img').error(function(){
        $('img').attr("src","imagens/aula-ingles.png");
    });
*/
/*
    $('img').error(function(){
        var imagem = $(this).attr('src');
        alert('imagem '+imagem+' Indisponivel!');
        $('img').attr("src","./imagens/aula-ingles.png");
    });
    */

    /*
    $('img').width($(window).width()).height($(window).height());

    $(window).resize(function(){
        $('img').width($(window).width()).height($(window).height());
    })
*/

/*
    $(window).scroll(function(){
        $('img').fadeOut('1000');
    })
*/


///Efeito de Esconder a imagem com a rolagem
$('body').css("height","5000px");
    $(window).scroll(function(){
        var topo = $(window).scrollTop()
        if(topo>400){
            $('img').fadeOut('1000');
        }else{
            $('img').fadeIn('1000');
        }
    })


});