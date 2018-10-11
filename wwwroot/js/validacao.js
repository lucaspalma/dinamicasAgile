window.onload = () => {
    document.querySelectorAll(".field-validation-error").forEach(erro => {
        erro.closest(".validado").classList.add("--erro")
    })
} 