public class Triangulo
{
    private int a;
    private int b;
    private int c;

    public Triangulo(int a,int b, int c)
    {
        this.a=a;
        this.b=b;
        this.c=c;
    }

    public String getResultado()
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            return "Erro";
        }
        else if (a >= b && a >= c && a>b+c)
        {
            return "Erro";
        }
        else if (b >= a && b >= c && b>a+c)
        {
            return "Erro";
        }
        else if (c >= a && c >= b && c>a+b)
        {
            return "Erro";
        }
        else if (a==b & b==c){
                return "Equilatero";
            }
            else if (a==b || a==c || b==c){
                return "Isosceles";
            }
            else return "Escaleno";
        }
    }
