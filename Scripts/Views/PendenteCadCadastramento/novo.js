$(document).ready(function () {


    $("#DdlArea").on("change", function () {

        var value = $("#DdlArea option:selected").val();

        if (value !== "") {
            ChangeAssunto(value);
            ChangeCentroCusto();
        }
    });

    $("#DdlGrpA").on("change", function(){
        var value = $("#DdlGrpA option:selected").val();
        if(value !== "") {
            ChangeCentroCusto();
        }
    });
});



function ChangeCentroCusto() {

    var area = $("#DdlArea option:selected").val();
    var assunto = $("#DdlGrpA option:selected").val();

    var url = "/PendenteCadCadastramento/GetCentroCusto";

    var callback = $.ajax({
        url: url
        , datatype: "html"
        , type: "GET"
        , data: { area: area, assunto: assunto }
    });

    callback.done(function (data) {
        $("#centrocusto").empty().html(data);
    });


}

function ChangeAssunto(value) {

    var url = "/PendenteCadCadastramento/GetAssunto";

    var callback = $.ajax({
        url: url
        , datatype: "json"
        , type: "GET"
        , data: { area: value }
    });

    callback.done(function (data) {

        if (data.length > 0) {

            // Construir o select list <option>

            var optionSelect = "<option value=''>Selecione</option>";
            $("#DdlGrpA").empty().append(optionSelect);

            data.map((option) => {
                var option = `<option value='${option}'>${option}</option>`;
                $("#DdlGrpA").append(option);
            });
        }
    });

}