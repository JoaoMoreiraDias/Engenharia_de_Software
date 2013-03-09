package src;

import java.util.ArrayList;

public class MaquinaTrocos implements IMaquinaTrocos {
    private static final int NMOEDAS = 5;
    private double[] valores = {2,1,0.5,0.2,0.1};
    private int[] numMoedas;
    private double quantia;
    
    public MaquinaTrocos() {
        numMoedas = new int[NMOEDAS];
        quantia = 0;
    }
    
    public void setQuantia( double q) {
        quantia = q;
        calculaTroco();
    }

   public int getMoedas( double v) {
        for (int i=0; i<NMOEDAS; i++) {
            if (valores[i] == v) {
                return numMoedas[i];
            }
        }
        return 0;
    }    

   public ArrayList<NumeroMoedas> getTodasMoedas() {
	   ArrayList<NumeroMoedas> nm = new ArrayList<NumeroMoedas>();
	   for (int i=0; i<NMOEDAS; i++) {
		   if (numMoedas[i] > 0)
			   nm.add(new NumeroMoedas( valores[i],numMoedas[i]));
	   }
	   return nm;
    }    

    public double getResto() {
        return quantia;
    }
    
    private void calculaTroco() {
        for (int i=0; i<NMOEDAS; i++) {
            while (quantia >= valores[i] - 0.00001) {
                numMoedas[i] ++;
                quantia -= valores[i];
            }
        }
    }
        
}
