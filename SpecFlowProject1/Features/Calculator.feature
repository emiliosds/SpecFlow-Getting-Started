#language: pt-br

Funcionalidade: Calculadora
	Para evitar erros
	Como um iniciante em matemática
	Quero testar todas as operações básicas

Cenário: Somar dois números
	Dado que o primeiro número seja 50
	E o segundo número seja 70
	Quando há uma soma
	Então o resultado deve ser 120

Cenário: Descobrir a diferença entre dois números
	Dado que o primeiro número seja 70
	E o segundo número seja 50
	Quando há uma subtração
	Então o resultado deve ser 20

Cenário: Multiplicar um número por outro
	Dado que o primeiro número seja 3
	E o segundo número seja 6
	Quando há uma multiplicação
	Então o resultado deve ser 18

Cenário: Dividir um número por outro
	Dado que o primeiro número seja 10
	E o segundo número seja 5
	Quando há uma divisão
	Então o resultado deve ser 2

Cenário: Dividir um número por zero
	Dado que o primeiro número seja 0
	E o segundo número seja 8
	Quando há uma divisão
	Então o resultado deve ser 0