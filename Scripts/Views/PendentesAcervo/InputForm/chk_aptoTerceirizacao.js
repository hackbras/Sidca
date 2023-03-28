var pendente = {}

pendente.AptoTerc = function (codigo) {

   var id = codigo.toString().replace(".", "")
            .replace(".", "")
            .replace("/", "")
            .replace("-", "");

    var checked = $("#AptoTerc" + id).prop("checked");
        var url = "/PendentesAcervo/AptoTerc"

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
        });


    }

