Desenvolvi um sistema de controle de matrículas para uma escola. Nesse sistema, um estudante só pode ser matriculado se o curso ainda tiver vagas disponíveis. A regra é clara: se o número de estudantes já matriculados alcançar o limite, novas matrículas devem ser recusadas.

Precisei modelar duas classes:

Classe Curso:

- Propriedade pública Nome
- Propriedade pública VagasTotais (definida no construtor)
- Campo privado matriculas (lista de estudantes)
- Método bool Matricular(Estudante estudante) que:
- Adiciona o estudante se houver vaga
- Exibe mensagem de erro e retorna false caso contrário
- Método ListarMatriculados(), que mostra todos os estudantes matriculados
- Propriedade somente leitura VagasDisponiveis

Classe Estudante:

- Propriedade pública Nome (com construtor)
