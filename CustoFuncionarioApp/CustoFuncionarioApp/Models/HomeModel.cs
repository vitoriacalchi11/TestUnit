namespace CustoFuncionarioApp.Models
{
    public class HomeModel
    {
        public string Nome { get; set; }
        public decimal SalarioBase { get; set; }
        public decimal Desconto { get; set; }
        public decimal Beneficio { get; set; }

        public decimal CalcularCustoTotal()
        {
            return (SalarioBase + Beneficio) - Desconto;
        }
    }
}
