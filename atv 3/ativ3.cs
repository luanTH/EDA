using System;
using ArvoreBinaria;

namespace ativ
{
    
    public class ativ:ArvoreB  //HERANÇA DA CLASSE ARVOREB
    {
        private ArvoreB ab;   //CRIAMOS UM OBJETO DO TIPO ARVOREB PARA USAR O MÉTODO DE INSERÇÃO
        
        public ativ()
		{
			this.ab = null;
		}
       
        public void inserirpre(string x, string y)   //FUNÇÃO INSERIR PRE-ORDEM - PARAMETROS EQUIVALENTES A ELEMNTOS EM PRE E EM ORDEM.
        {
            
            int i,j=0;
            string aux1="",aux2="",aux3="",aux4="";   //VARIAVEIS AUXILIARES INCIADAS

            if (x.Length == 0){

				return;
            }
            else{
               for( i=0; i < x.Length ; i++){
                   ab.Inserir(x[i]);                 //IRA PERCORRER A STRING X, ADICIONANDO CADA VALOR SEU A ARVORE

                   while (y[j]!=x[i])
                   {
                       aux2+=y[j];                  //ADICIONA OS VALORES DA SUBARVORE A DIREITA DA RAIZ ENCONTRADA NO FOR, NA VARIAVEL AUXILIAR
                       j++;                         //EQUIVALE A STRING CONTENDO OS ELEMENTOS DE PREORDEM
                   }
                   for(i=1;i<j+1;i++){
                       aux1+=x[i];                  //ADICIONA OS VALORES DA SUBARVORE A ESQUERDA DA RAIZ, A PARTIR DA POSIÇÃO j
                   }                                //EQUIVALE AOS ELEMENTOS DA STRING PREORDEM, APENAS ATE O INDICE DE J

                   for(int b=j;b<x.Length;b++){
                       aux3+=x[b];                  //VARIAVEIS AUXILIARES QUE IRÃO CONTER O EQUIVALENTE A PARTE DIREITA DA ARVORE
                       aux4+=y[b];
                   }
                   
                   inserirpre(aux1,aux2);           //CHAMADA RECURSIVA QUE IRA PREENCHER TODA A PORÇÃO A ESQUERDA DA RAIZ
                   inserirpre(aux3,aux4);           //CHAMADA RECURSIVA QUE IRA PREENCHER TODA A PORÇÃO A DIREITA DA RAIZ
               }
            }
        }
        
    public class program
    {
       static void Main(string[] args)
		  {
            ativ arvoreBinaria = new ativ();
            
            string x="ASTQED";
            string y="TSQAED";
           
            arvoreBinaria.inserirpre(x,y);
            arvoreBinaria.Exibir();
          }
    }
}