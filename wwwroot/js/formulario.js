
$(document).ready(function(){
    if ( $("#vendedor").prop("checked")==false && $("#cajero").prop("checked")==false) {
        $(document).ready(function(){
          
            $("#ide").hide();
            $(".ide").hide();
            $("#sueldo").hide();
            $(".sueldo").hide();
            $("#numcaja").hide();
            $("#idc").hide();
            $(".numcaja").hide();
            $(".idc").hide();
            $("#idv").hide();
            $(".ingresar").hide();
            $(".idv").hide();
            $("#sueldov").hide();
            $(".sueldov").hide();
            
                  
           
       });    
    }
     $("#vendedor").click(function(){
            document.getElementById("vendedor").checked = true;
            document.getElementById("cajero").checked = false;
            $("#numcaja").hide();
            $("#idc").hide();
            $(".numcaja").hide();
            $(".idc").hide();
            $("#idv").show();
            $(".idv").show();
            $(".ingresar").show();
            $("#sueldov").show();
            $(".sueldov").show();
            $("#sueldo").hide();
            $(".sueldo").hide();
            $("#ide").show();
            $(".ide").show();
        });
    
        $("#cajero").click(function(){
            document.getElementById("cajero").checked = true;
            document.getElementById("vendedor").checked = false;
            $("#idv").hide();
            $(".idv").hide();
            $("#idc").show();
            $("#numcaja").show();
            $(".idc").show();
            $(".numcaja").show();
            $("#sueldo").show();
            $(".sueldo").show();
            $(".ingresar").show();
            $(".ide").show();
            $("#ide").show();
            $("#sueldov").hide();
            $(".sueldov").hide();
        });
    
});