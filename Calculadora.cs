namespace Calculadora
{
    public class Calculadora
    {
        public string conta;
        public float valor;
        public float soma { get; set; }
        public float sub { get; set; }
        public float div { get; set; }
        public float mult { get; set; }

        /// <summary>
        /// Faz soma.
        /// <returns>Retorna a soma.</returns>
        public float FazerSoma(float soma){
            return valor + valor;
        }
        /// <summary>
        /// Faz subtração.
        /// <returns>Retorna a subtração.</returns>
        public float FazerSub(float sub){
            return valor - valor;
        }
        /// <summary>
        /// Faz divisão.
        /// </summary>
        /// <param name="div"></param>
        /// <returns>Retorna a divisão</returns>
        public float FazerDiv(float div){
            return valor / valor;
        }
        /// <summary>
        /// Faz a multiplicação.
        /// <returns>Retorna a multiplicação.</returns>
        public float FazerMult(float mult){
            return valor * valor;
        }
    }
}