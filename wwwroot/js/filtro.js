const listaDinamicas = document.querySelectorAll(".dinamica");
document.querySelector(".filtro-botao").addEventListener("click", () =>{
    listaDinamicas.forEach(dinamica => {
        dinamica.style.display = "block";
    })
    document.querySelectorAll(".filtro-tipo:checked").forEach(campoTipo => {
        const tipo = campoTipo.value;
        listaDinamicas.forEach(dinamica => {
            if(dinamica.dataset.tipos.toString().indexOf(tipo) < 0) {
                dinamica.style.display = "none";
            }
        })
    })
});

document.querySelector(".filtro-mostra").addEventListener("click", function() {
    document.querySelector(".filtro-menu").classList.toggle("--esconde");
    let iconeFiltro = document.querySelector(".filtro-mostra");
    iconeFiltro.classList.toggle("glyphicon-plus-sign");
    iconeFiltro.classList.toggle("glyphicon-minus-sign");
})