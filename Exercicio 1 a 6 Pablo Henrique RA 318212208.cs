using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_6_exercicios_praticas_de_programação
{
    class Cliente_N2
    {
        
        private int saldo;
        private int conta;
        private int totalCobrancas;
        private int totalCredito;
        private int limiteCredito;

       
        public Cliente_N2()
        {
           

         saldo = 0;
         conta = 0;
         totalCobrancas = 0;
         totalCredito = 0;
         limiteCredito = 0;


        }

     
        public Cliente_N2(int saldo, int conta, int totalCobrancas, int totalCredito, int limiteCredito)
        {
            this.saldo = saldo;
            this.conta = conta;
            this.totalCobrancas = totalCobrancas;
            this.totalCredito = totalCredito;
            this.limiteCredito = limiteCredito;
        }

        
        public int calcular_novo_saldo()    
        {
            return this.saldo + this.totalCobrancas - this.totalCredito;
        }


       
        public void atualizar_saldo()
        {
            this.saldo = calcular_novo_saldo();
        }


        
        public bool verificar_limite()
        {
            return this.saldo > this.limiteCredito;
        }





    }

}
