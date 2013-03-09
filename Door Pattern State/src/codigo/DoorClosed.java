package codigo;

import java.io.File;

import javax.imageio.ImageIO;

public class DoorClosed extends DoorState { 

    public DoorClosed(Door door) {
        super(door);
        try {
        	File f = new File("resources\\fechada.png");
        	imagem = ImageIO.read( f);
        } catch (Exception ex) {
        	ex.printStackTrace();
        }

    }
    public void click() {
        door.setState(door.OPENING);
    }

}
