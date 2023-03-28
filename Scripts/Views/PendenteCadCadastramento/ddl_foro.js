
pendente.DdlForo = function (codigo) {

        var id = codigo.toString().replace(".", "")
            .replace(".", "")
            .replace("/", "")
            .replace("-", "");

        var selected = $("#DdlForo").prop("value");
        var url = "/PendenteCadCadastramento/DdlForo"

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

