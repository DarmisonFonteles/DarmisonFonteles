window.onload = function () {

    const cep = document.querySelector("#cep")

    const showDate = (result)=>{
        for(const campo in result){
            if(document.querySelector("#"+campo)){
                document.querySelector("#"+campo).value = result[campo]

            }
        }
    }
    
    cep.addEventListener("blur",()=>{
        let search = cep.value.replace("-","")
        const options = {
            method: 'GET',
            mode: 'cors',
            cache: 'default'
        }

        fetch(`https://viacep.com.br/ws/${search}/json/`, options) //
        .then( response=>{ 
            response.json()
            .then(data => showDate(data))
        })
        .catch(e => console.log('Deu erro: ' + e,message))
        console.log(cep.value)
    })

}
