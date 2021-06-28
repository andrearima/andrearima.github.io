using Arima;

namespace GitHub.Profile.Central
{
    public static class InformacoesPessoais
    {
        private static readonly CurriculoArima _curriculoArima = new();
        public static CurriculoArima Info => _curriculoArima;
    }
}
