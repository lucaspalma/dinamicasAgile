function addPasso() {
	const fluxo = document.querySelector(".gerador .lista-fluxo")
	const listaDePassos = fluxo.querySelectorAll(".lista-item")
	const ultimoPasso = listaDePassos[listaDePassos.length - 1]
	const ultimaPosicaoOcupada = parseInt(ultimoPasso.dataset.posicao)
	let novoPasso = ultimoPasso.cloneNode(true)
	novoPasso.id = novoPasso.id.replace(ultimaPosicaoOcupada, ultimaPosicaoOcupada + 1)
	novoPasso.name = novoPasso.name.replace(ultimaPosicaoOcupada, ultimaPosicaoOcupada + 1)
	novoPasso.dataset.posicao = novoPasso.dataset.posicao.replace(ultimaPosicaoOcupada, ultimaPosicaoOcupada + 1)
	
	let novoItem = document.createElement("li")
	novoItem.appendChild(novoPasso)

	fluxo.appendChild(novoItem)
}

function addLink() {
	const links = document.querySelector(".gerador .lista-links")
	const listaDePassos = links.querySelectorAll(".lista-item")
	const ultimoLink = listaDePassos[listaDePassos.length - 1]
	const ultimaPosicaoOcupada = parseInt(ultimoLink.dataset.posicao)
	let novoLink = ultimoLink.cloneNode(true)
	novoLink.id = novoLink.id.replace(ultimaPosicaoOcupada, ultimaPosicaoOcupada + 1)
	novoLink.name = novoLink.name.replace(ultimaPosicaoOcupada, ultimaPosicaoOcupada + 1)
	novoLink.dataset.posicao = novoLink.dataset.posicao.replace(ultimaPosicaoOcupada, ultimaPosicaoOcupada + 1)

	let novoItem = document.createElement("li")
	novoItem.appendChild(novoLink)

	links.appendChild(novoItem)
}
