

function Vemelho() {
    document.getElementById("fundo").style.backgroundColor = "red";
}
function Verde() {
    document.getElementById("fundo").style.backgroundColor = "Green";
}
function Azul() {
    document.getElementById("fundo").style.backgroundColor = "Blue";
}
function Amarelo() {
    document.getElementById("fundo").style.backgroundColor = "Yellow";
}
function Branco() {
    document.getElementById("fundo").style.backgroundColor = "White";
}

function mudarFonte() {
    var p = document.getElementById("paragrafo");

    if (p.style.display == "none") {
        p.style.display = "block";
        document.getElementById("btn").textContent = "Esconder Texto"

    } else {
        p.style.display = "none";
        document.getElementById("btn").textContent = "Mostrar Texto"
    }
}


function VerificaChecks() {
    var cbox = document.getElementsByName("Animal");
    var contagem = 0;
    for (let index = 0; index < cbox.length; index++) {
        if (cbox[index].checked == true) {
            contagem++;
        }
        if (contagem >= 2) {
            document.getElementById("btnCbox").removeAttribute("disabled");

        } else {
            document.getElementById("btnCbox").setAttribute("disabled", "enabled");
        }

    }

}
function ChecksTodos(todos) {
    var cbox = document.getElementsByName("Animal");
    for (let index = 0; index < cbox.length; index++) {
        cbox[index].checked = todos.checked;

    }
    VerificaChecks()
}
function CordaFonte(cor) {
    document.getElementById("txt").style.color = cor;
}
function CordaFundo(cor) {
    document.getElementById("txt").style.backgroundColor = cor;

}
function TamanhorFonte() {
    document.getElementById("ex07").style.fontSize = document.getElementById("aumetarFonte").value + "px";

}
var tamanho = 16;
function tamanhoMais() {
    tamanho++;
    document.getElementById("ex07").style.fontSize = tamanho + "px";
}

function tamanhoMenos() {
    tamanho--;
    document.getElementById("ex07").style.fontSize = tamanho + "px";
}
function Maiuscula() {
    var txt = document.getElementById("ex08");
    txt.innerText = x.innerText.toUpperCase();
}
function Miniscula() {
    document.getElementById("ex08").innerHTML = document.getElementById("ex08").innerHTML.toLocaleLowerCase();

}
function validar() {
    var nome = document.getElementById("nome").value;
    var senha1 = document.getElementById("senha1").value;
    var senha2 = document.getElementById("senha2").value;

    if (nome != "" && senha1 != "" && senha2 != "") {
        if (senha1 == senha2) {
            if (senha1.length > 5 && senha1.length <= 10) {
                alert("Salvo com sucesso!");
            }
            else {
                alert("Senha sem os requisitos!");
            }
        }
        else {
            alert("As senhas precisam ser iguais!!");
        }
    }
    else {
        alert("Preencha todos os campos!");
    }
}

function cadastrar() {

}

function alteraVisibilidade(tipop) {
    //alert(tipop);
    if (tipop == "fisica") {
        document.getElementById("pessoaFisica").style.display = "block";
        document.getElementById("pessoaJuridica").style.display = "none";
    }
    else {
        document.getElementById("pessoaFisica").style.display = "none";
        document.getElementById("pessoaJuridica").style.display = "block";
    }
}

function mascara(m, t, e) {
    var cursor = t.selectionStart;
    var texto = t.value;
    texto = texto.replace(/\D/g, '');
    var l = texto.length;
    var lm = m.length;
    if (window.event) {
        id = e.keyCode;
    } else if (e.which) {
        id = e.which;
    }
    cursorfixo = false;
    if (cursor < l) cursorfixo = true;
    var livre = false;
    if (id == 16 || id == 19 || (id >= 33 && id <= 40)) livre = true;
    ii = 0;
    mm = 0;
    if (!livre) {
        if (id != 8) {
            t.value = "";
            j = 0;
            for (i = 0; i < lm; i++) {
                if (m.substr(i, 1) == "#") {
                    t.value += texto.substr(j, 1);
                    j++;
                } else if (m.substr(i, 1) != "#") {
                    t.value += m.substr(i, 1);
                }
                if (id != 8 && !cursorfixo) cursor++;
                if ((j) == l + 1) break;
            }
        }
    }
    if (cursorfixo && !livre) cursor--;
    t.setSelectionRange(cursor, cursor);
}