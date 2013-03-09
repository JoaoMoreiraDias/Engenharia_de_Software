package src;

import java.util.ArrayList;

public class Colaborador {
    private String nome;
    private double vencimentoBase;
    private double horasBase;
    private ArrayList<TrabExtra> listaExtra;

    public Colaborador(double vencimentoBase, double horasBase){
        try {
            listaExtra=new ArrayList<TrabExtra>();
            this.vencimentoBase=vencimentoBase;
            this.horasBase=horasBase;
        } catch (Exception e) {
            System.out.println("ERRO!");

        }

    }

    public Double calculaVencimento(){
        double vencimento=0;
        try{
            vencimento=vencimento+vencimentoBase;
            for (TrabExtra i : listaExtra) {
                vencimento=vencimento+i.calcula(vencimentoBase);
            }
        } catch (Exception e) {
            System.out.println("ERRO!");
            return null;
        }
        return vencimento;
    }

    public ArrayList<TrabExtra> getTrabExtra(){
        return listaExtra;
    }

    public void addTrabExtra(TrabExtra novo){
        try {
            listaExtra.add(novo);
        } catch (Exception e) {
            System.out.println("ERRO!");

        }
    }

    public String getNome(){
        return nome;
    }

    public void setNome(String nome){
        try{
            this.nome=nome;
        } catch (Exception e) {
            System.out.println("ERRO!");

        }
    }

    public double getVencimentoBase(){
        return vencimentoBase;
    }

    public void setVencimentoBase(double vencimentoBase){
        try {
            this.vencimentoBase=vencimentoBase;
        } catch (Exception e) {
            System.out.println("ERRO!");

        }
    }

    public double getHorasBase(){
        return horasBase;
    }

    public void setHorasBase(double horasBase){
        try{
            this.horasBase=horasBase;
        } catch (Exception e) {
            System.out.println("ERRO!");

        }
    }
}