// JavaScript Document

function entra() {

		$("#result").text("");

		var id = $("#id").val();
		var senha = $("#senha").val();

	if (id == "1" && senha == "sla" ) {

		$("#result").text(" Tudo certo, pode passa! ");
		$("#result").css("color", "green");


		var nome = "Matheus Borri";
		var empre = "Google";


		localStorage.setItem('nome', nome);
		localStorage.setItem('empre', empre);

		window.location.href = "registroponto.html";

		} 
	else {
	
		$("#result").text(" Email e/ou senha Incorreto(s) ");
		$("#result").css("color", "red");
	
		}
	return false;
}

function carrega(){	
	
	document.getElementById("1").disabled = true;
	document.getElementById("2").disabled = true;
	document.getElementById("3").disabled = true;
	document.getElementById("4").disabled = true;
	
	
	
	
	document.getElementById("btnentradaalmoco").disabled = true;
	
	document.getElementById("btnregistrar").disabled = true;
	
	document.getElementById("btnsaida").disabled = true;

	var nome = localStorage.getItem('nome');
	var empre = localStorage.getItem('empre');
	
	document.getElementById("lblFun").innerHTML = "Funcionário: " + nome;
	document.getElementById("lblEmpre").innerHTML = "Empresa: " + empre;
	
	
	if(document.getElementById("1").value != ""){
		
		document.getElementById("btnentradaalmoco").disabled = false;	   
		
	   }
	if(document.getElementById("2").value != ""){
	   
		document.getElementById("btnregistrar").disabled = false;
	   
	   }
	if(document.getElementById("3").value != ""){
	   
		document.getElementById("btnsaida").disabled = false;
	   
	   }
	
}

function regHr(numbtn){
	
	var data = new Date();
	
	var dia     = data.getDate();
	var mes     = data.getMonth();
	var ano4    = data.getFullYear();
	var hora    = data.getHours();
	var min     = data.getMinutes();
	
	
	
		
	
	
	if(numbtn == "1" ){
		
		var str_data = dia + '/' + (mes+1) + '/' + ano4 + " " + hora + ':' + min;
		
		document.getElementById("1").value = str_data;		
		
		document.getElementById("btnentradaalmoco").disabled = false;
		
		
	
	
		
	}
	
	if(numbtn == "2" ){
		
		var str_data = dia + '/' + (mes+1) + '/' + ano4 + " " + hora + ':' + min;
		
		document.getElementById("2").value = str_data;	
		
		document.getElementById("btnregistrar").disabled = false;	
		
	}
	
	if(numbtn == "3" ){
		
		var str_data = dia + '/' + (mes+1) + '/' + ano4 + " " + hora + ':' + min;
		
		document.getElementById("3").value = str_data;
		
		document.getElementById("btnsaida").disabled = false;
		
		
	}
	
	if(numbtn == "4" ){
		
		var str_data = dia + '/' + (mes+1) + '/' + ano4 + " " + hora + ':' + min;
		
		document.getElementById("4").value = str_data;
		
		
	}
	

	
}

function reset (){
	
	document.getElementById("1").value = "";
	document.getElementById("2").value = "";
	document.getElementById("3").value = "";
	document.getElementById("4").value = "";
	
	document.getElementById("btnentradaalmoco").disabled = true;	
	document.getElementById("btnregistrar").disabled = true;	
	document.getElementById("btnsaida").disabled = true;
	
}





