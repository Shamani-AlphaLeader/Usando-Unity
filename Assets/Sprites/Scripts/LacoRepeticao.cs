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
            int[] num = { 10, 20, 30, 30, 40, 50, 60, 70, 80 };

            print(num[3]);

            num[0]++;

            print(num[0]);

            string[] nomes;
            
            nomes = new string[5];

            nomes[0] = "Shamani&Hayasaki";

            print(nomes[0]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
