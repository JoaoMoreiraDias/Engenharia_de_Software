//ActionFixture – Para testar sequências de ações
package fixtures;

import src.TrabExtra;
import src.Colaborador;
import java.util.ArrayList;

public class ActionTeste extends fit.ActionFixture{
    private Colaborador col;
    private int tipo;
    private double duracao;
    private double vencimento;
    private double horas;
    
    public ActionTeste()
    {
    }
    
    public void tipo(int novo)
    {
        tipo=novo;
    }
    
    public void vencimento(int novo)
    {
        vencimento=novo;
    }
    
    public void horas(int novo)
    {
        horas=novo;
    }
    
    public void duracao(double nova)
    {
        duracao=nova;
    }
    
    public boolean colaborador()
    {
        try{
            col=new Colaborador(vencimento, horas);
        }
        catch(Exception ex)
        {
            return false;
        }
        return true;
    }
    
    public boolean adicionarHoras()
    {
        try{
            col.addTrabExtra(new TrabExtra(tipo, duracao));
        }
        catch (Exception Ex)
        {
            return false;
        }
        return true;
    }
    
    public double calculaVencimento()
    {
        return col.calculaVencimento();
    }
}