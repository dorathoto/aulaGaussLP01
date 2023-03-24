programa
{
	
	funcao inicio()
	{
		inteiro   num1, num2, mdc=0, i  

	
		escreva("Digite o primeiro número: ")
   		leia(num1)
   		escreva("Digite o segundo número: ")
   		leia(num2)


   		//  MDC usando o algoritmo de Euclides (Máximo divisor comum) https://pt.wikipedia.org/wiki/Algoritmo_de_Euclides
   		i = 1
   		enquanto (i <= num1 e i <= num2)
		{
			se (num1 % i == 0){
				se ( num2 % i == 0){
				 mdc = i
				}
			}
			i++
		}


   
   		// Verificação se o MDC é igual a 1
		se (mdc == 1){
		      escreva("Os números são primos entre si.")
		}
		senao{
		      escreva("Os números não são primos entre si.")
		}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 310; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */