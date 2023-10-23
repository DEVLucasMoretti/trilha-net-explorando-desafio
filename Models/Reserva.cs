namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
           
                // TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido

                 try{
                    if (Suite.Capacidade >= hospedes.Count)
                    {
                        Hospedes = hospedes;
                    }
                    else
                    {
                        throw new Exception("O número de hóspedes excede a capacidade da suíte");
                    }
                    }catch (Exception e){Console.WriteLine("Erro: " + e.Message);throw;}

            }
        

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            // TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            // TODO: Retorna o valor da diária
            // Cálculo: DiasReservados X Suite.ValorDiaria
            
            decimal valor = 0;

            // Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            if (DiasReservados >= 10)
            {
                valor = ((DiasReservados * Suite.ValorDiaria) * 0.9M);
            }
            else{valor = ((DiasReservados * Suite.ValorDiaria));}

            return valor;
        }
    }
}