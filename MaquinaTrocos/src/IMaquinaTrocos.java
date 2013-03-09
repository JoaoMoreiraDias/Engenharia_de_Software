package src;

import java.util.ArrayList;

public interface IMaquinaTrocos
{

    void setQuantia(double q);
    double getResto();
    int getMoedas( double moeda);
    ArrayList<NumeroMoedas> getTodasMoedas();
}
