package codigo;

public abstract class EstadoMaquina
{
    protected Maquina maquina;
    
    public EstadoMaquina(Maquina nova)
    {
        maquina=nova;
    }
    
    public abstract void click();
    
    public void terminado() {}
    
    public String toString()
    {
        String nomeClass=getEstado();
        return nomeClass;
    }
    
    public abstract String getEstado();
    
    public void tempo(){}
}
