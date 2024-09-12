namespace CalcularBhaskara
{
    public static class Bhaskara
    {
        public static (double?, double?) CalcularRaizes(double n1, double n2, double n3)
        {
            double delta = (n2 * n2) - (4 * n1 * n3);

            if (delta < 0)
            {
                return (null, null); // Não há raízes reais
            }

            double raizDelta = Math.Sqrt(delta);
            double x1 = (-n2 + raizDelta) / (2 * n1);
            double x2 = (-n2 - raizDelta) / (2 * n1);

            return (x1, x2); // Retorna as duas raízes
        }
    }
}
