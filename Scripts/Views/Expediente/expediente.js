var pendente = {}
pendente.Apto= function (codigo) {


        var id = codigo.toString().replace(".", "")
            .replace(".", "")
            .replace("/", "")
            .replace("-", "");

        var checked = $("#chk" + id).prop("checked");
        var url = "/PendentesAcervo/Apto"

        var callback = $.ajax({
            url: url,
            type: "POST",
            datatype: "json",
            data: {
                id: id,
                result: checked
            }
            , error: function (xlr, msg) {

            }
        });

        callback.done(function (data) {
            alert("Registro atualizado com sucesso!");
        });


    }

