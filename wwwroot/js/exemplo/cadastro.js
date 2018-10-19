
const botaoNovoExemplo = document.querySelector(".exemplo-novo");
botaoNovoExemplo.addEventListener("click", () => {
    doGet("/Exemplo/FormNovo", (resposta) => {
        console.log(resposta)
        let areaNovoExemplo = document.createElement('div');
        areaNovoExemplo.classList.add("novo-exemplo");
        areaNovoExemplo.innerHTML = resposta;
        document.body.appendChild(areaNovoExemplo);
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

