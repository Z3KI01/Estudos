using System;

class ContadorSimples {
    // Atributo estático para contar o número de vezes que o método foi chamado
    private static int contador = 0;

    // Método estático para incrementar o contador
    public static void IncrementarContador() {
        contador++;
    }

    // Método estático para obter o valor atual do contador
    public static int ObterContador() {
        return contador;
    }
}

class Exercicio {
    public static void Executar() {
        // Chama o método IncrementarContador algumas vezes
        ContadorSimples.IncrementarContador();
        ContadorSimples.IncrementarContador();
        ContadorSimples.IncrementarContador();

        // Exibe o valor atual do contador
        Console.WriteLine("Número de chamadas: {0}", ContadorSimples.ObterContador());
    }
}
