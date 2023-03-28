pendente.AceConcl= function (codigo) {

        var id = codigo.toString().replace(".", "")
            .replace(".", "")
            .replace("/", "")
            .replace("-", "");

    var checkedTerc = $("#AptoTerc" + id).prop("checked");
    var selectedAdv = $("#DdlAdv" + id).prop("value");
    if (checkedTerc == false && selectedAdv == "") {
        var checked = $("#AceConcl" + id).prop("checked",false);

        alert("ATENÇÂO: Informe advogado do acervo ou expediente vinculado antes de concluir a análise.");
    } else {
        conclusion(id);
    }

}

function conclusion(id) {
    var result = confirm("Finalizar análise do acervo?");
    if (result) {
        var checked = $("#AceConcl" + id).prop("checked");
        var url = "/PendentesAcervo/AceConcl"

        var callback = $.ajax({
            url: url,
            type: "POST",
            datatype: "json",
            data: {
                id: id,
                result: checked
            }
            , error: function (xlr, msg) {
                alert(msg);
            }
        });

        callback.done(function (data) {
            alert("Registro atualizado com sucesso!");
            window.location.reload();
        });
    } else {
        var checked = $("#AceConcl" + id).prop("checked", false);
    }
}