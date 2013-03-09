package codigo;

import java.io.File;

import javax.imageio.ImageIO;

public class DoorClosing extends DoorState { 
	
    public DoorClosing(Door door) {
        super(door);
        try {
        	File f = new File("resources\\fechando.png");
        	imagem = ImageIO.read( f);
        } catch (Exception ex) {
        	ex.printStackTrace();
        }
    }
    public void click() {
        door.setState(door.OPENING);

    }
    
    public void complete() {
        door.setState(door.CLOSED);
    }
}
