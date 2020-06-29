using System;
using System.Collections.Generic;
using System.Text;

namespace exVeiculos
{
    class Carro : veiculo
    {
        public int capacidadePortaMala { get; set; }
        public bool bagageiro { get; set; }
        public bool correiaDentada { get; set; }//atributo especifico da classe

        public Carro()
           : base()
        {
            this.capacidadePortaMala = 0;
            this.bagageiro = false;
            this.correiaDentada = false;
        }
        public Carro(String modelo, String fabricante, int ano, String cor, int numero_portas, String placa, int capacidadePortaMala, bool bagageiro,bool correiaDentada)
            : base(modelo,fabricante,ano,cor,numero_portas,placa)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.correiaDentada = correiaDentada;
        }
       
        public String CarroCadastrados()
        {
           return (String.Format("Modelo: {0}\nFabricante: {1}\nAno: {2}\nCor: {3}\nQuantidade de portas: {4}\nPlaca: {5}\nCapacidade do porta mala: {6}\nBagageiro: {7}\nCorreia Dentada: {8}\n",
           modelo, fabricante, ano, cor, numero_portas, placa, capacidadePortaMala, bagageiro, correiaDentada));
        }
        

    }
}
