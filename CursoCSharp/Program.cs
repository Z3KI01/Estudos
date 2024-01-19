using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentários.Executar},
                {"VariaveisEConstantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Logicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadorTernario.Executar},

                // Estruturas de Controle
                {"Estruturas IF - Estrutuas de Controle", EstrutraIF.Executar},
                {"Estruturas IF e Else - Estrutuas de Controle", EstrutraIfElse.Executar},
                {"Estruturas IF/Else/If - Estrutuas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estrutuas de Controle", EstrutraSwitch.Executar},
                {"Estrutura While - Estrutuas de Controle", EstruturaWhile.Executar},
                {"Estrutura do While - Estrutuas de Controle", EstruturaDoWhile.Executar},
                {"Estrutura For - Estrutuas de Controle", EstruturaFor.Executar},
                {"Calculadora", Exercicio.Executar},
                {"Estrutura For Each - Estrutuas de Controle", EstruturaForEach.Executar},
                {"Usando Break - Estrutuas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estrutuas de Controle", UsandoContinue.Executar},
                {"Você é minha namorada - Estrutuas de Controle", VoceEMinhaNamorada.Executar},
                
                //Classes e Métodos
                {"Membros - Classes e Métodos", Membros.Executar},
                {"Contrutores - Classes e Métodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estáticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Ex Atributos - Classes e Metodos", Exercicio.Executar},
                {"Desafio Atributos - Classes e Metodos", DesafioAtributo.Executar},
                {"Parans - Classes e Metodos", Parans.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Get Set - Classes e Metodos", Moto.GetSet.Executar},
                {"Props - Classes e Metodos", Props.Executar},
                {"Get e Set Youtube - Classes e Metodos", YtGetSet.Executar},
                {"Readonly - Classes e Metodos", Readonly.Executar},
                {"Enum - Classes e Metodos", ExemploEnum.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"StructVsClasse - Classes e Metodos", StrucVsClasse.Executar},
                {"Valor Vs Referência - Classes e Metodos", ValorVsReferência.Executar},
                {"Parametros por Referência - Classes e Metodos", ParametrosPorReferencia.Executar},
                {"Parametro Padrão - Classes e Metodos", ParametroPadrao.Executar},
                
                // Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", ColeceoesList.Executar},
                {"Coleções Array List - Coleções", ColecoesArrayList.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}