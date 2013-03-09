public class Bolha implements IOrdenar{
    private IComparavel[] lista;
    
    public Bolha(){
    }
   
    public void ordenar(IComparavel lista[]){
        for (int i = lista.length; --i>=0; ) {
            boolean flipped = false;
            for (int j = 0; j<i; j++) {
                if (lista[j].compararCom(lista[j+1])>0) {
                    IComparavel T = lista[j];
                    lista[j] = lista[j+1];
                    lista[j+1] = T;
                    flipped = true;
                }
            }
            if (!flipped) {
                return;
            }
        }
    }
}