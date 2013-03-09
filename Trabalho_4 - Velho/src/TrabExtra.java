package src;

public class TrabExtra {
    private int tipo;
    private double duracao;

    public TrabExtra(int tipo, double duracao) {
        this.tipo = tipo;
        this.duracao = duracao;
    }

    public double calcula(double vencimentoBase){
        double pagamento=0;
        if (tipo==1){
            pagamento=vencimentoBase*125;
        } else if (tipo==2){
            pagamento=vencimentoBase*150;
        } else {
            pagamento=vencimentoBase*200;
        }
        return pagamento;
    }

    public double getDuracao(){
        return duracao;
    }
    
    public void setDuracao(double duracao){
        this.duracao=duracao;
    }
    
    public int getTipo(){
        return tipo;
    }
    
    public void setTipo(int tipo){
        this.tipo=tipo;
    }
}
