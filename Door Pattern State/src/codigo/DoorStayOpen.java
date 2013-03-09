package codigo;

import java.io.File;

import javax.imageio.ImageIO;

public class DoorStayOpen extends DoorState { 
    public DoorStayOpen(Door door) {
        super(door);
        try {
        	File f = new File("resources\\aberta.png");
        	imagem = ImageIO.read( f);
        } catch (Exception ex) {
        	ex.printStackTrace();
        }
    }
    public void click() {
        door.setState(door.CLOSING);
    }
}
