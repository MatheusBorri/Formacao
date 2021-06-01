// JavaScript Document

function entra() {
	
		$("#result").text("");
	
		var id = $("#id").val();
		var senha = $("#senha").val();
	
	if (id == "1" && senha =="sla" ) {
	
		$("#result").text(" Tudo certo, pode passa! ");
		$("#result").css("color", "green");
} 
	else {
	
		$("#result").text(" Email e/ou senha Incorreto(s) ");
		$("#result").css("color", "red");
	
		}
	return false;
}
$("#entra").bind("click", entra);