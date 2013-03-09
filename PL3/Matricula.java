public class Matricula
{
    private String Smatricula;
    private String[] divisao;

    public Matricula(String Smatricula)
    { 
        this.Smatricula=Smatricula;
    }
    
    public boolean verificar()
    {
        if(verificarTamanho()==false)
        {
            return false;
        }
        if(verificarTracos()==false)
        {
            return false;
        }
        divisao=Smatricula.split("-");
        if(verificarNumeros(divisao[0])==false)
        {
            return false;
        }
        if(verificarNumeros(divisao[2])==false)
        {
            return false;
        }
        if(verificarNumerosPossiveis(Integer.parseInt(divisao[0])))
        {
            return false;
        }
        if(verificarNumerosPossiveis(Integer.parseInt(divisao[2]))==false)
        {
            return false;
        }
        if(verificarLetrasPossiveis(divisao[1])==false)
        {
            return false;
        }       
        return true;
    }

    private boolean verificarTracos()
    {
        if (Smatricula.substring(2, 3).equals("-")==false || Smatricula.substring(5, 6).equals("-")==false)
        {
            return false;
        }
        return true;
    }

    private boolean verificarTamanho()
    {
        if (Smatricula.length()!=8)
        {
            return false;
        }
        return true;
    }

    private boolean verificarNumeros(String numero)
    {
        try  
        {  
            Integer.parseInt(numero);  
            return true;  
        }  
        catch(Exception exception)  
        {  
            return false;  
        }  
    }
    
    private boolean verificarNumerosPossiveis(int numero)
    {
        if(numero<0 || numero>99)
        {
            return false;
        }
        return true;
    }
    
    private boolean verificarLetrasPossiveis(String letras)
    {
        String alfa="ABCDEFGHIJLMNOPKRSTUVXZ";
        for (int i=1; i<3; i++)
        {
            if(alfa.indexOf(letras.substring(-1+i, 0+i))==-1)
            {
                return false;
            }
        }   
        return true;
    }   
}