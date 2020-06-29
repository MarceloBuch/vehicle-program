using System;
using System.Collections.Generic;
using System.Text;

namespace exVeiculos
{
    abstract class veiculo
    {
        public String modelo { get; set; }
        public String fabricante { get; set; }
        public int ano { get; set; }
        public String cor { get; set; }
        public int numero_portas { get; set; }
        public String placa { get; set; }

        public veiculo()
        {
            this.modelo = null;
            this.fabricante = null;
            this.ano = 0;
            this.cor = null;
            this.numero_portas = 0;
            this.placa = null;
        }
        public veiculo(String modelo,String fabricante, int ano, String cor, int numero_portas, String placa)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
            this.placa = placa;
        }
    }
}
