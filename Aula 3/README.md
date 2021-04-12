# Ficha de Trabalho Nº3

1.  Escreva um programa em C# que calcula a tabuada de qualquer número entre 1 e 10. O resultado deverá ter a seguinte forma:

        7 * 1 = 7
        ...
        7 * 10 = 70

2.  Escreva um programa em C# que leia dois números inteiros e escreve o maior deles.

3.  Escreva um programa em C# que leia 2 números inteiros, `x` e `y`, e escreve o resultado de elevar `x` à potência de `y`.

4.  Escreva um programa em C# que leia uma _string_ e determine se é um palíndromo (ou seja, se o inverso da _string_ é igual a ela).

5.  Escreva um programa em C# que dada uma sequência de `n` números inteiros, procure a primeira ocorrência de um determinado valor nessa sequência.

    Por exemplo, se a seguinte sequência for introduzida: [3,1,10,5,8,7,1], e pesquisar pelo 10 o seu programa deverá devolver o índice da primeira ocorrência na sequência (neste caso, índice = 2).

6.  Numa empresa, o vencimento dos empregados é calculado a partir de um vencimento base (VB) em função da sua idade (Id), do número de filhos (NF) e dos anos de serviço (AS). O cálculo é feito somando o VB as seguintes parcelas:

    - 1% de VB por cada ano de Id superior a 25;
    - 3% de VB por cada AS, se trabalhar há mais de 6 anos;
    - 5% de VB por cada filho (NF), até ao limite de 4.

    Calcular o valor a receber por cada funcionário.

7.  Dada uma sequência de `n` números inteiros, calcular os seguintes resultados:

    1. o mínimo valor da sequência;
    2. os três maiores valores da sequência;
    3. o somatório dos valores da sequência;
    4. a média dos valores da sequência;
    5. o número de valores superiores a 10;
    6. a percentagem de valores superiores a 10;
    7. a média dos valores superiores a 10.

8. Considere a seguinte implementação da classe `BankAccount`:

    ```c#
    public class BankAccount
    {
        private static int _accountNumberSeed = 1234567890;

        public BankAccount(string name, double initialBalance)
        {
            Number = _accountNumberSeed.ToString();
            _accountNumberSeed++;
            Owner = name;
            Balance = initialBalance;
        }

        public string Number { get; }

        public string Owner { get; }

        public double Balance { get; private set; }

        public void Debit(double amount)
        {
            if (amount > Balance)
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Debit amount exceeds balance!");
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), amount, "Debit amount is less than zero!");
            Balance -= amount;
        }

        public void Credit(double amount)
        {
            if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount), "Credit amount must be positive!");
            Balance += amount;
        }
    }
    ```

    1. Crie testes unitários.
    2. Adicione o método `GetAccountHistory()` que retorna uma _string_ com o histórico de transações. Crie um novo tipo para representar uma transação. O resultado deverá ter a seguinte forma: `Date\t\tAmount\tBalance\tDescription`. Adicionar testes unitários.
