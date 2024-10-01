using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEstacionamento.Models
{
    

    public class Estacionamento
    {

        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        
         public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public Estacionamento()
        {
        }

        public void AdicionarVeiculo(){
            string NovoVeiculo;
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            NovoVeiculo = Console.ReadLine();
            veiculos.Add(NovoVeiculo);
            Console.WriteLine($"Veículo {NovoVeiculo} adicionado com sucesso!");

        }
        public void RemoverVeiculo(){
            string PlacaVeiculo;
            Console.WriteLine("Digite a placa do veículo para remover:");
            PlacaVeiculo = Console.ReadLine();
            if(veiculos.Contains(PlacaVeiculo)){
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                decimal QntHrs = decimal.Parse(Console.ReadLine());
                veiculos.Remove(PlacaVeiculo);
                Console.WriteLine($"Veículo  {PlacaVeiculo} removido e o preço total foi de {precoInicial+precoPorHora*QntHrs}R$!");
            }else{
                Console.WriteLine("Veículo não encontrado!");
            }
            
        }
        public void ListarVeiculos(){
            Console.WriteLine("Carros Estacionados:");
            foreach(string valor in veiculos){
                Console.WriteLine(valor);
            }

        }
    }
}