public class Maquina
{
    private int cont005 = 0;
    private int cont010 = 0;
    private int cont020 = 0;
    private int cont050 = 0;
    private int cont1 = 0;
    private int cont2 = 0;
    private int[] troco = new int[6];
    private String Stroco="";

    public Maquina(int d005, int d010, int d020, int d050, int d1, int d2)
    {
        this.cont005=d005;
        this.cont010=d010;
        this.cont020=d020;
        this.cont050=d050;
        this.cont1=d1;
        this.cont2=d2;
    }

    public String troco(double deve, double dado)
    {
        if (temTroco(dado, deve)==true && dado>deve)
        {
            while (deve < dado)
            {
                if ((deve+2.00)<=dado && cont020>0)
                {
                    troco[5]+=1;
                    cont020--;
                    deve+=2.00;
                }
                else if ((deve+1.00)<=dado && cont010>0)
                {
                    troco[4]+=1;
                    cont010--;
                    deve+=1.00;
                }
                else if ((deve+0.50)<=dado && cont050>0)
                {
                    troco[3]+=1;
                    cont050--;
                    deve+=0.50;
                }
                else if ((deve+0.20)<=dado && cont020>0)
                {
                    troco[2]+=1;
                    cont020--;
                    deve+=0.20;
                }
                else if ((deve+0.10)<=dado && cont010>0)
                {
                    troco[1]+=1;
                    cont010--;
                    deve+=0.10;
                }
                else if ((deve+0.05)<=dado && cont005>0)
                {
                    troco[0]+=1;
                    cont005--;
                    deve+=0.05;
                }
            }
        }
        Stroco=troco[0]+";"+troco[1]+";"+troco[2]+";"+troco[3]+";"+troco[4]+";"+troco[5]+";";
        return Stroco;
    }

    public boolean temTroco(double dado, double deve)
    {
        if (0.5*cont005 + 0.10*cont010 + 0.20+cont020 + 0.50+cont050 + 1.00*cont1 + 2.00*cont2>=dado-deve)
        {
            return true;
        }
        return false;
    }
}
