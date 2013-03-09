package fixtures;

import src.TrabExtra;
import src.Colaborador;
import java.util.ArrayList;

public class ActionTeste extends fit.ActionFixture{
    private TrabExtra trab;
    private Colaborador col;

    public ActionTeste(int tipo, double duracao, double vencimentoBase, double horasBase)
    {
        trab=new TrabExtra(tipo, duracao);
        col=new Colaborador(vencimentoBase, horasBase);
    }

    public void setDuracao(double novo)
    {
    	trab.setDuracao(novo);
    }

    public void setTipo(int tipo)
    {
    	trab.setTipo(tipo);
    }

    public void setVencimentoBase(double vencimentoBase)
    {
    	col.setVencimentoBase(vencimentoBase);
    }

    public void setHorasBase(double horasBase)
    {
    	col.setHorasBase(horasBase);
    }

    public double getVencimento()
    {
    	return col.calculaVencimento();
    }

    public ArrayList<Double> getTrabExtra()
    {
        return col.getTrabExtra();
    }

    public int getTipo()
    {
    	return trab.getTipo();
    }

    public double getDuracao()
    {
    	return trab.getDuracao();
    }

    public double getVencimentoBase()
    {
    	return col.getVencimentoBase();
    }

    public double getHorasBase()
    {
    	return col.getHorasBase();
    }
}