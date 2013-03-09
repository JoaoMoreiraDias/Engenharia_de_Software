public class Ordenar
{
    /*
     * Outra solução que tinha, guardei como registo de trabalho de como resolvi o problema antes de ler o enunciado.
    private IComparavel[] alunos;
    private IComparavel[] livros;private Bolha bolha;
    private Seleccao seleccao;
    private Insercao insercao;
    {
        alunos=new IComparavel[10];
        alunos[0]=new Aluno(24972);
        alunos[1]=new Aluno(24672);
        alunos[2]=new Aluno(25972);
        alunos[3]=new Aluno(24979);
        alunos[4]=new Aluno(24972);
        alunos[5]=new Aluno(24572);
        alunos[6]=new Aluno(24962);
        alunos[7]=new Aluno(24982);
        alunos[8]=new Aluno(24922);
        alunos[9]=new Aluno(22972);

        livros=new IComparavel[10];
        livros[0]=new Livro("Anna Karenin");
        livros[1]=new Livro("Madame Bovary");
        livros[2]=new Livro("War and Peace");
        livros[3]=new Livro("Lolita");
        livros[4]=new Livro("The Adventures of Huckleberry Finn");
        livros[5]=new Livro("Hamlet");
        livros[6]=new Livro("The Great Gatsby");
        livros[7]=new Livro("In Search of Lost Time");
        livros[8]=new Livro("The Stories of Anton Chekhov");
        livros[9]=new Livro("Middlemarch");
    }*/
    private IComparavel[] lista;
    private IOrdenar algoritmo;
    
    public Ordenar(IComparavel[] lista, IOrdenar algoritmo)
    {
        this.algoritmo=algoritmo;
        this.lista=lista;
        algoritmo.ordenar(lista);
    }

    /*
    public void ordenarElementosBolha()
    {
        bolha=new Bolha();
        bolha.ordenar(alunos);
        bolha.ordenar(livros);
    }

    public void ordenarElementosSeleccao()
    {
        seleccao=new Seleccao();
        seleccao.ordenar(alunos);
        seleccao.ordenar(livros);
    }

    public void ordenarElementosInsercao()
    {
        insercao=new Insercao();
        insercao.ordenar(alunos);
        insercao.ordenar(livros);
    }*/
}			