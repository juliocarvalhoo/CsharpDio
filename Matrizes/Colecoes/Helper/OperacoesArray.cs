using System;
namespace MatrizTridimensional.Helper
{
    public class OperacoesArray
    {
        public void OrdenarBubbleSorte(ref int[] array)
        {
            int temporaria = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {   
                        temporaria = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temporaria;
                    } 
                }   
            }
        }

        public void ImprimirArray(int[] array)
        {
            string linha = string.Join(", ",array);
            System.Console.WriteLine(linha);

        // foreach (int i in ArrayInteiros)
        // {
        //  WriteLine(i);
        //   }
 
        }

        
    }
}