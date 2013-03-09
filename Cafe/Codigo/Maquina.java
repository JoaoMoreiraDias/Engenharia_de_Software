package codigo;

import java.util.Observable;

public class Maquina extends Observable
{
    public final EstadoMaquina ATIRAR = new TirarCafe(this);
    public final EstadoMaquina SEMSALDO = new SemSaldo(this);
    public final EstadoMaquina COMSALDO = new ComSaldo(this);
    
    private EstadoMaquina estadoMaquina = SEMSALDO;
    
    public void click()
    {
        estadoMaquina.click();
    }
    
    public void terminado()
    {
        estadoMaquina.terminado();
    }
    
    public void setEstado(EstadoMaquina novo)
    {
        this.estadoMaquina=novo;
        setChanged();
        notifyObservers();
    }
    
    public String toString()
    {
        return estadoMaquina.toString();
    }
    
    public void tempo()
    {
        estadoMaquina.tempo();
    }
}
