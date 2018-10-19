
const botaoNovoExemplo = document.querySelector(".exemplo-novo");
botaoNovoExemplo.addEventListener("click", () => {
    doGet("/Exemplo/FormNovo", (resposta) => {
        
        let areaNovoExemplo = document.createElement('div');
        areaNovoExemplo.classList.add("novo-exemplo");
        areaNovoExemplo.innerHTML = resposta;
        document.body.appendChild(areaNovoExemplo);
        const botaoCriaExemplo = document.querySelector(".exemplo-add");
        botaoCriaExemplo.addEventListener("click", (botao) => {
            
            var novoExemplo = {
                avaliacao : document.querySelector(".questao-resposta[name='Avaliacao']").value,
                participante : document.querySelector(".questao-resposta[name='Participante']").value,
                tempo : document.querySelector(".questao-resposta[name='Tempo']").value,
                contexto : document.querySelector(".questao-resposta[name='Contexto']").value,
                motivo : document.querySelector(".questao-resposta[name='Motivo']").value,
                metrica : document.querySelector(".questao-resposta[name='Metrica']").value,
                observacao : document.querySelector(".questao-resposta[name='Observacao']").value
            }
            const id  = document.querySelector(".dinamica").dataset.id;
            
            doPost("/Exemplo/Adiciona/"+id, novoExemplo, (resposta) => {
                let nova = document.createElement("div");
                nova.innerHTML = resposta;
                document.querySelector(".dinamica-exemplo").appendChild(nova);
                document.querySelector(".novo-exemplo").remove();
                
            }, (error) => {
                console.log(error)
            });
        });
    });
});

function doGet(link, success)
{
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.onreadystatechange = function()
    {
        if(xmlHttp.readyState === 4 && xmlHttp.status === 200)
        {
            success(xmlHttp.responseText)
        }

    }
    xmlHttp.open("GET", link);
    xmlHttp.send();
}

function doPost(url, data, success, fail) {
    var newName = 'John Smith',
    xhr = new XMLHttpRequest();

    xhr.open('POST', url);
    xhr.setRequestHeader('Content-Type', 'application/json');
    xhr.onload = function() {
        if (xhr.status === 200 && xhr.responseText !== newName) {
            success(xhr.responseText);
        }
        else if (xhr.status !== 200) {
            fail(xhr);
        }
    };
    xhr.send(JSON.stringify(data));

}