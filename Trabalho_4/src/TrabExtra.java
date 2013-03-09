package src;

public class TrabExtra {
    private int tipo;
    private double duracao;

    public TrabExtra(int tipo, double duracao) {
        this.tipo = tipo;
        this.duracao = duracao;
    }

    public Double calcula(double vencimentoBase){
        double pagamento=0;
        try{
            if (tipo==1){
                pagamento=(vencimentoBase*125)/100;
                pagamento=pagamento*duracao;
            } else if (tipo==2){
                pagamento=(vencimentoBase*150)/100;
                pagamento=pagamento*duracao;
            } else if (tipo==3){
                pagamento=(vencimentoBase*200)/100;
                pagamento=pagamento*duracao;
            }
        } catch (Exception e) {
            System.out.println("ERRO!");
            return null;
        }
        return pagamento;
    }

    public double getDuracao(){
        return duracao;
    }

    public void setDuracao(double duracao){
        try{
            this.duracao=duracao;
        } catch (Exception e) {
            System.out.println("ERRO!");
        }
    }

    public int getTipo(){
        return tipo;
    }

    public void setTipo(int tipo){
        try{
            this.tipo=tipo;
        } catch (Exception e) {
            System.out.println("ERRO!");

            
        }
    }
}
