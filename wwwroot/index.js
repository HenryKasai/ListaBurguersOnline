const iniciar = async () => {
    const response = await fetch('/hamburgueria');
    const result = await response.json();
    const tbody = document.querySelector("tbody");
    const elementos = result.slice(1, 4);
    elementos.forEach(b => tbody.insertAdjacentHTML("beforebegin", 
    `<tr>
        <td>${b.nome}</td>
        <td>R$ ${b.preco}</td>
    </tr>`));
}

document.addEventListener("DOMContentLoaded", iniciar);