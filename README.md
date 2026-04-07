Sistema de Conta Bancária em C#

Este é um projeto simples desenvolvido em C# com o objetivo de praticar conceitos fundamentais de programação orientada a objetos (POO), como:

Encapsulamento
Construtores
Sobrecarga de métodos
Propriedades
Métodos de instância
📌 Funcionalidades

O sistema permite:

Criar uma conta bancária com ou sem depósito inicial
Realizar depósitos
Realizar saques (com taxa de R$ 5,00 por operação)
Exibir os dados da conta atualizados

🧱 Estrutura do Projeto

O projeto é dividido em duas partes principais:


🔹 Classe Program

Responsável pela interação com o usuário via console:

Entrada de dados
Execução das operações
Exibição dos resultados

🔹 Classe ContaBancaria

Responsável pelas regras de negócio:

Armazena número da conta, titular e saldo
Implementa métodos de depósito e saque
Sobrescreve o método ToString()
🛠️ Tecnologias Utilizadas
C#
.NET
Console Application
System.Globalization (para formatação de valores)

▶️ Como Executar
Clone o repositório:
git clone https://github.com/seu-usuario/seu-repositorio.git

Acesse a pasta do projeto:
cd nome-do-projeto

Execute o programa:
dotnet run

💻 Exemplo de Execução
Entre o número da conta: 1234
Entre o titular da conta: João
Haverá depósito inicial (s/n)? s
Entre o valor de depósito inicial: 500.00

Dados da conta:
Conta 1234, Titular: João, Saldo: $ 500.00

Entre um valor para depósito: 200.00
Dados da conta atualizados:
Conta 1234, Titular: João, Saldo: $ 700.00

Entre um valor para saque: 100.00
Dados da conta atualizados:
Conta 1234, Titular: João, Saldo: $ 595.00

📚 Conceitos Aplicados
Uso de construtores com sobrecarga
Encapsulamento com private set
Métodos para manipulação segura do saldo
Uso de CultureInfo.InvariantCulture para padronização de números
Sobrescrita do método ToString()

🎯 Objetivo do Projeto

Este projeto foi desenvolvido com fins educacionais para reforçar a base em C# e lógica de programação, sendo ideal para iniciantes em desenvolvimento backend.
