public class Insercao implements IOrdenar {
    public Insercao(){
    }
    
    public void ordenar(IComparavel lista[]){
        for (int i = 1; i < lista.length; i++) {
            int j = i;
            IComparavel B = lista[i];
            while ((j > 0) && (lista[j-1].compararCom(B)>0)) {
                lista[j] = lista[j-1];
                j--;    
            }
            lista[j] = B;
        }
    }   
}