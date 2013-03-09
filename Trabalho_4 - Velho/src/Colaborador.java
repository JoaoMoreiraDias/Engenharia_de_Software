package src;

import java.util.ArrayList;

public class Colaborador {
    private String nome;
    private double vencimentoBase;
    private double horasBase;
    private ArrayList<TrabExtra> listaExtra;
    private ArrayList<Double> listaDuracao;

    public Colaborador(double vencimentoBase, double horasBase){
        listaExtra=new ArrayList<TrabExtra>();
        listaDuracao=new ArrayList<Double>();
        this.vencimentoBase=vencimentoBase;
        this.horasBase=horasBase;
    }

    public double calculaVencimento(){
        double vencimento=0;
        vencimento=vencimento+vencimentoBase;
        for (TrabExtra i : listaExtra) {
            vencimento=vencimento+i.calcula(vencimentoBase);
        }
        return vencimento;
    }

    public ArrayList<Double> getTrabExtra(){
        double duracaoT=0;
        for (TrabExtra i : listaExtra) {
            listaDuracao.add(i.getDuracao());
        }
        return listaDuracao;
    }
    
    public String getNome(){
        return nome;
    }
    
    public void setNome(String nome){
        this.nome=nome;
    }
    
    public double getVencimentoBase(){
        return vencimentoBase;
    }
    
    public void setVencimentoBase(double vencimentoBase){
        this.vencimentoBase=vencimentoBase;
    }
    
    public double getHorasBase(){
        return horasBase;
    }
 
    public void setHorasBase(double horasBase){
        this.horasBase=horasBase;
    }
}