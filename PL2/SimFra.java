public class SimFra {
    private int n1;
    private int n2; 
    private int temp1;
    private int temp2; 
    private int n3;
    private int n4;
    private String resultado;

    public SimFra(int n1, int n2){
        this.n1=n1;
        this.n2=n2;
    }

    public String simplificar(){
        temp1 = n1;
        temp2 = n2; 

        while (n1 != n2){
            if(n1 > n2)
                n1 = n1 - n2;
            else
                n2 = n2 - n1;
        }      

        int n3 = temp1 / n1 ;
        int n4 = temp2 / n1 ;
        resultado=n3 + "/" + n4;
        return resultado;
    }  
}