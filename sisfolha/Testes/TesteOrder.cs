using System;
using sisfolha.Entidades;
using sisfolha.Entidades.enums;

namespace sisfolha.Testes {
    class TesteOrder {
        public static void testeOrder() {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrdemStatus.PagamentoPendente
            };
            Console.WriteLine(order);

            string txt = OrdemStatus.PagamentoPendente.ToString();
            Console.WriteLine("Conversão dados string: " + txt);

            OrdemStatus os = Enum.Parse<OrdemStatus>("Entregue");
            Console.WriteLine(os);
        }
    }
}
