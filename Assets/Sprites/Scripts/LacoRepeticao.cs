using System.Collections.Generic;
using UnityEngine;

public class LacoRepeticao : MonoBehaviour
{
    //For -> utilizado quando se sabe a qtde. de repeticoes.

    //While ou DoWhile -> utilizado quando nao se sabe a qtde. de repeticoes.

    //foreach -> utilizado quando se tem uma lista ou array em que para cada elemento da lista se deve fazer uma operacao.

    //Array -> Lista.

    //int x = 0; //While
    //int y = 0; //DoWhile
    void Start()
    {

         //for(inicializador; condicao; incremento/decremento)
         //for (int i = 0; i <= 10; i++)
        {
            //if(i == 5)
            // break;

            // if(i == 6) 
            //{
            //continue;
            //}
            //print(i);

            //While
            //while (x <= 10) 
            //{
            //    print(x);
            //    x++;
            //}

            //do 
            //{  
            //print(y);
            //    y--;
            //}
            //while (y >= 0);

            //int[] num = { 10, 20, 30, 30, 40, 50, 60, 70, 80 };

            //print(num[3]);

            //num[0]++;

            //print(num[0]);

            //string[] nomes;

            //nomes = new string[5];

            //nomes[0] = "Shamani&Hayasaki";

            //print(nomes[0]);

            //    for (int i = 0; i < 8; i++) 
            //    {
            //        print(num[i]);
            //}
            //foreach (var item in num)
            //    {
            //        print(item);
            //    }


            //Criando uma lista de inteiros chamanda 'nums'
        List<int> nums = new List<int>();
            //Adiciona elementos a lista de nums
            nums.Add(1);// Indice 0
            nums.Add(2);// Indice 1
            nums.Add(3);//------------
            nums.Add(4);//------------
            nums.Add(5);//------------
            nums.Add(6);//------------
            nums.Add(7);//------------
            nums.Add(8);// Indice 7

            //Remove o primeiro valor '4' encontrado na lista (indice 3)
            nums.Remove(4);

            //Ordena os elementos da lista em ordem crescente
            nums.Sort();

            nums.Reverse();

            nums.IndexOf(1);

            
    }

    // Update is called once per frame
    void Update()
    {
        
    }
        }
}
