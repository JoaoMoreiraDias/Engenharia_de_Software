class Livro implements IComparavel{
    private String nome;
    public Livro(String nome){
        this.nome=nome;
    }

    public int compararCom(IComparavel novo){
        return nome.compareTo(((Livro) novo).getNome());
    }
    
    public String getNome()
    {
        return nome;
    }
}