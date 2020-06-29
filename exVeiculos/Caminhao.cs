using System;
using System.Collections.Generic;
using System.Text;

namespace exVeiculos
{
    class Caminhao : veiculo
    {
        public int numero_eixo { get; set; }
        public double peso_maximo_carga{ get; set; }
        public int numero_alavanca_cambio { get; set; }//atributo especifico da classe
        public Caminhao()
           : base()
        {
            this.numero_eixo = 0;
            this.peso_maximo_carga = 0.0;
            this.numero_alavanca_cambio = 0;
        }
        public Caminhao(String modelo, String fabricante, int ano, String cor, int numero_portas, String placa, int numero_eixo, double peso_maximo_carga, int numero_alavanca_cambio)
           : base(modelo,fabricante,ano,cor,numero_portas,placa)
        {
            this.numero_eixo = numero_eixo;
            this.peso_maximo_carga = peso_maximo_carga;
            this.numero_alavanca_cambio = numero_alavanca_cambio;
        }
        public String CaminhaoCadastrados()
        {
            return (String.Format("Modelo: {0}\nFabricante: {1}\nAno: {2}\nCor: {3}\nQuantidade de portas: {4}\nPlaca: {5}\nQuantidade de eixos: {6}\nPeso maximo de carga: {7}\nQuantidade de alavancas: {8}\n",
            modelo, fabricante, ano, cor, numero_portas, placa, numero_eixo, peso_maximo_carga, numero_alavanca_cambio));
        }
        
    }
}
