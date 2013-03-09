package gui;

import java.awt.Graphics;
import java.awt.image.BufferedImage;

import javax.swing.JPanel;

public class PainelPorta extends JPanel {
	private BufferedImage imagem;
	
	public PainelPorta() {
		super();
	}
	
	public void setImagem(BufferedImage imagem) {
		this.imagem = imagem;
	}
	
	public void paint( Graphics gc) {
		gc.drawImage( imagem, 0, 0, null);
	}

}
