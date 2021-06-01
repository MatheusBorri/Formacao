package Aula;

import javax.swing.JOptionPane;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Funcionario Jorge = new Funcionario();
		
		Jorge.setNome("Jorge");
		
		String nomeDoJorge = Jorge.getNome();
	
		JOptionPane.showMessageDialog(null, nomeDoJorge, "Jorge", 1);		

	}

}
