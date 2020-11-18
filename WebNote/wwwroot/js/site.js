function retornarHora() {
    var horario = new Date();
    var horas = horario.getHours();
    var minutos = horario.getMinutes();

    var hrs = horario.getHours() + ":" + horario.getMinutes();
    return hrs;
}
function retornaDataAtual() {

    var dataAtual = new Date();
    var dia = dataAtual.getDate();

    if (dia < 10)
        dia = ("0" + dia);

    var data = dataAtual.getFullYear() + "-" + (dataAtual.getMonth() + 1) + "-" + dia;
    return data;
}
function validarDia() {
    let dia = document.getElementById("dia").value;

    if (dia < retornaDataAtual()) {
        event.preventDefault();
        return Document.event(alert("A data deve ser maior que o dia atual!"));
    }
}
function validarDataNascimento() {
    let dia = document.getElementById("DtN").value;

    if (dia > retornaDataAtual()) {
        event.preventDefault();
        return Document.event(alert("A data deve ser menor que o dia atual!"));
    }
}
function validarHorarioCompromisso() {
    validarDia();
    let inicio = document.getElementById("inicio").value;
    let fim = document.getElementById("fim").value;

    if (inicio > fim) {
        event.preventDefault();
        return Document.event(alert("O horário de início deve ser menor que o fim!"));
    }
}
function validarHorarioAtividade() {
    validarDia();
    let hr = retornarHora();
    let formHrs = document.getElementById("hrs").value;
    let dia = document.getElementById("dia").value;

    if (dia == retornaDataAtual())
        if (formHrs < hr) {
            event.preventDefault();
            return Document.event(alert("O horário da atividade deve ser maior que o horário atual!"));
        }
}
