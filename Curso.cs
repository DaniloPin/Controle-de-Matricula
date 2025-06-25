public class Curso {
    public string Nome { get; set; }
    public int VagasTotais { get; set; }
    private List<Estudante> matriculas;

    public Curso(string nome, int vagasTotais) {
        Nome = nome;
        VagasTotais = vagasTotais;
        matriculas = new List<Estudante>();
    }

    public bool Matricular(Estudante estudante) {

        if (matriculas.Count >= VagasTotais) {
            Console.WriteLine("ERRO: Não há vagas disponíveis.");
            return false;
        }
        else {
            matriculas.Add(estudante);
            Console.WriteLine("Estudante cadastrado com sucesso!");
            return true;
        }
    }

    public void ListarMatriculados() {
        Console.WriteLine($"\nEstudantes matriculados: {Nome}");

        foreach (var estudantes in matriculas) {
            Console.WriteLine($" -  {estudantes.Nome}");
        }
        Console.WriteLine($"\nVagas disponiveis: {VagasDisponiveis}");
    }

    public int VagasDisponiveis {
        get { return VagasTotais - matriculas.Count; }
    }
}