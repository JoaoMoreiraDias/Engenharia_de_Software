package codigo;

import java.awt.image.BufferedImage;

public abstract class DoorState { // classe abstrata: estado da porta
    protected Door door;
    protected BufferedImage imagem;

    public DoorState(Door door) {
        this.door = door;
    }
    public abstract void click();
    
    public void complete() {}
    
    public String status() {
        String s = getClass().getName();
        return s.substring(s.lastIndexOf('.') + 1);
    }
    
    public void timeout() {}
    
    public BufferedImage getImagem() {
    	return imagem;
    }

}
