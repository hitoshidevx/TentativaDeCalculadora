using System;
namespace Calculadora
{
    public class Cientifica : Calculadora
    {
        public float numeros;
        public float media;

        public float FazerMedia(float media){
            return media / numeros;
        }

    }
}