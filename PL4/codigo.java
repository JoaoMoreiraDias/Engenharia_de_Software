public class codigo
{
    private String Scodigo;
    private String alfaAF="ABCDEF";
    private String alfaAZ="ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private String primeiraParte;
    private String segundaParte;

    public codigo(String novo)
    {
        Scodigo=novo;        
    }

    public boolean verificar()
    {
        if(verificarTamanho()==false)
        {
            return false;
        }
        if(verificarTraco()==false)
        {
            return false;
        }
        if(validarTamanhoPrimeiraParte()==false)
        {
            return false;
        }
        if(validarPrimeiraParte()==false)
        {
            return false;
        }
        if(validarTamanhoSegundaParte()==false)
        {
            return false;
        }
        if(validarSegundaParte()==false)
        {
            return false;
        }
        return true;
    }

    private boolean verificarTamanho()
    {
        if(Scodigo.length()<5 || Scodigo.length()>6)
        {
            return false;
        }
        return true;
    }

    private boolean verificarTraco()
    {
        if(Scodigo.indexOf("-")!=-1)
        {
            String[] codigoPartido=Scodigo.split("-");

            primeiraParte=codigoPartido[0];
            segundaParte=codigoPartido[1];
            return true;
        }
        return false;
    }

    private boolean validarTamanhoPrimeiraParte()
    {
        if(primeiraParte.length()<2 || primeiraParte.length()>3)
        {
            return false;
        }
        return true;
    }

    private boolean validarPrimeiraParte()
    {
        if(alfaAF.indexOf(primeiraParte.substring(0, 1))==-1)
        {
            return false;
        }
        int tamanho=primeiraParte.length();
        for (int i=1; i<tamanho; i++)
        {
            int verificar;
            String verificarString=primeiraParte.substring(i, i+1);
            try
            {
                verificar=Integer.parseInt(verificarString);
            } catch (Exception exception)
            {
                return false;
            }	

            if(verificar<1 || verificar>9)
            {
                return false;
            }
        }
        return true;
    }

    private boolean validarTamanhoSegundaParte()
    {
        if(segundaParte.length()!=2)
        {
            return false;
        }
        return true;
    }

    private boolean validarSegundaParte()
    {
        String letraVerificar=segundaParte.substring(0, 1);
        if(alfaAZ.indexOf(letraVerificar)==-1)
        {
            return false;
        }
        int numeroVerificar;
        String numeroStringVerificar=segundaParte.substring(1, 2);
        try
        {
            numeroVerificar=Integer.parseInt(numeroStringVerificar);
        } catch(Exception exception)
        {
            return false;
        }
        if(numeroVerificar<0 || numeroVerificar>9)
        {
            return false;
        }
        return true;
    }
}