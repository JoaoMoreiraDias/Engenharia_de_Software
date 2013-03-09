package codigo;

import java.io.File;

import javax.imageio.ImageIO;

public class DoorOpen extends DoorState { 
    public DoorOpen(Door door) {
        super(door);
        try {
        	File f = new File("resources\\abertatempo.png");
        	imagem = ImageIO.read( f);
        } catch (Exception ex) {
        	ex.printStackTrace();
        }
    }
    public void click() {
        door.setState(door.STAYOPEN);
    }
    public void timeout() {
        door.setState(door.CLOSING);
    }
}
