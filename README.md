# DIO - Trilha .NET - Explorando a linguagem C#
www.dio.me

## Desafio de projeto
Para este desafio, você precisará usar seus conhecimentos adquiridos no módulo de explorando a linguagem C#, da trilha .NET da DIO.

## Contexto
Você foi contratado para construir um sistema de hospedagem, que será usado para realizar uma reserva em um hotel. Você precisará usar a classe Pessoa, que representa o hóspede, a classe Suíte, e a classe Reserva, que fará um relacionamento entre ambos.

O seu programa deverá cálcular corretamente os valores dos métodos da classe Reserva, que precisará trazer a quantidade de hóspedes e o valor da diária, concedendo um desconto de 10% para caso a reserva seja para um período maior que 10 dias.

## Regras e validações
1. Não deve ser possível realizar uma reserva de uma suíte com capacidade menor do que a quantidade de hóspedes. Exemplo: Se é uma suíte capaz de hospedar 2 pessoas, então ao passar 3 hóspedes deverá retornar uma exception.
2. O método ObterQuantidadeHospedes da classe Reserva deverá retornar a quantidade total de hóspedes, enquanto que o método CalcularValorDiaria deverá retornar o valor da diária (Dias reservados x valor da diária).
3. Caso seja feita uma reserva igual ou maior que 10 dias, deverá ser concedido um desconto de 10% no valor da diária.


![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## Solução
No sistema de gestão de hospedagem desenvolvido em C#, são utilizadas três classes principais: Pessoa, Suite e Reserva, juntamente com o método Main como ponto de entrada do programa.

1. Classe Pessoa: Responsável por representar um hóspede no hotel. Ela armazena informações como nome e sobrenome da pessoa, além de disponibilizar uma propriedade somente leitura para o nome completo.

2. Classe Suite: Define uma suíte no hotel, contendo propriedades para o tipo de suíte, capacidade máxima de hóspedes e valor da diária. Validadores no construtor garantem que os valores passados são válidos, e as propriedades são somente leitura após a inicialização para manter a integridade dos dados.

3. Classe Reserva: Representa uma reserva de hospedagem, contendo informações sobre os hóspedes, a suíte reservada e o número de dias da estadia. Métodos são fornecidos para cadastrar hóspedes e suítes, calcular o número de hóspedes na reserva e determinar o valor da diária, aplicando um desconto de 10% para reservas com mais de 10 dias.

4. Método Main: Serve como o ponto de entrada do programa, demonstrando como criar instâncias das classes Pessoa, Suite e Reserva, cadastrar hóspedes e suítes, e calcular os valores das diárias e das reservas.

Essas classes e métodos constituem um sistema simples, mas eficaz, para gerenciar reservas de hospedagem em um hotel, oferecendo funcionalidades essenciais para garantir uma experiência satisfatória aos clientes.