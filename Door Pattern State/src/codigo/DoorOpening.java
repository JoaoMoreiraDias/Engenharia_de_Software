package codigo;

import java.io.File;

import javax.imageio.ImageIO;

public class DoorOpening extends DoorState { 
    public DoorOpening(Door door) {
        super(door);
        try {
        	File f = new File("resources\\abrindo.png");
        	imagem = ImageIO.read( f);
        } catch (Exception ex) {
        	ex.printStackTrace();
        }
    }
    public void click() {
        door.setState(door.CLOSING);
    }
    public void complete() {
        door.setState(door.OPEN);
    }
}
