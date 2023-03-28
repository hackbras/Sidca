var pendente = {};

pendente.DdlAcao = function (codigo) {

        var id = codigo.toString().replace(".", "")
            .replace(".", "")
            .replace("/", "")
            .replace("-", "");

        var selected = $("#DdlAcao").prop("value");
        var url = "/PendenteCadCadastramento/DdlAcao"

        var callback = $.ajax({
            url: url,
            type: "POST",
            datatype: "json",
            data: {
                id: id,
                result: selected
            }
            , error: function (xlr, msg) {
                alert(msg);
            }
        });

        callback.done(function (data) {
            alert("Registro atualizado com sucesso!");
        });


    }

