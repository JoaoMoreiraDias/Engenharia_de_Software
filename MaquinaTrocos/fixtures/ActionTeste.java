package fixtures;

import src.MaquinaTrocos;

public class ActionTeste extends fit.ActionFixture
{
    private MaquinaTrocos MT;
    private double valor;
    
    public ActionTeste()
    {
        MT=new MaquinaTrocos();
    }
    
    public void quantidade(double novo)
    {
        MT.setQuantia(novo);
    }        
    
    public void valor(double novo)
    {
        valor=novo;
    }
    
    public int moedas()
    {
        return nova.getMoedas(valor);
    }
}