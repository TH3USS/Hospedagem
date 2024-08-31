using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Hospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Quarto { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() {}

        public Reserva(int diasReservados){
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes){
            Suite s = new Suite();
            bool cheio = false;

            if (s.Capacidade < hospedes.Count) {
                cheio = true;                
            }
            

            if (cheio == true)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new ArgumentException("Quartos cheios!");
            }
        }

        public void CadastrarSuite(Suite suite){
            Quarto = suite;
        }

        public int ObterQuantHospedes() => Hospedes.Count();

        public decimal CalValorDiaria(){
            decimal valor = DiasReservados * Quarto.ValorDiaria;
            if(DiasReservados >= 10){
                decimal desconto = (valor * 10) / 100;
                valor = valor - desconto;
            }
            return valor;
        }


    }
}