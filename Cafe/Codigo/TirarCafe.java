package Codigo;

public class TirarCafe extends Estado
{ 
    public TirarCafe(Maquina maquina) {
        super(maquina);
    }
    
    public void click(){
        maquina.setEstado(maquina.SI);
    }
    
    public void completar(){
        maquina.setEstado(maquina.SS);
    }
}
