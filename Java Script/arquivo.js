
function mostrarpares() {
    for (let i = 0; i <= 10; i++) {
        if (i % 2 == 0) {
            alert(i);
        }
    }

}

function somarpares() {
    var total = 0;
    for (let i = 0; i <= 100; i++) {
        total += i;
    }
    alert(total);
}

function deixarcaixaalta() {
    var x;
    x = document.getElementById("nome");
    on

    x.value = x.value.toUpperCase();

}

function mostrar() {
    var name;
    var idade;
    name = document.getElementById("name").value;
    idade = document.getElementById("idade").value;

    alert(name + "sua idade é" + idade + "anos");

}


function verificar() {
    var name;
    var idade;
    name = document.getElementById("name").value;
    idade = document.getElementById("idade").value;

    if (idade >= 18) {
        alert(name + "É maior de idade!");
    } else {
        alert(name + "É  nenor de idade!");
    }
}

function calcular(botao) {
    var n1;
    var n2;
    var total;
    n1 = parseInt(document.getElementById("n1").value);
    n2 = parseInt(document.getElementById("n2").value);

    total = n1 + n2

    if (total % 2 == 0) {

        //var botao = document.getElementById("btn");
        botao.style.background = '#F00';


    } else {
        botao.style.background='#00F'; 

    }
    alert(total);

}