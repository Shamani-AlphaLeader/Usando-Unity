using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class Exercicio03 : MonoBehaviour
{
    /*
     Operadores Logicos
    &&(E / AND)
    ||OU / OR)
    !(NÁO / NOT)
     */

    [SerializeField] bool playerVivo;//true
    [SerializeField] bool powerUp;//true
    double vidaPlayer = 100;

    void Start()
    {


        if (playerVivo == false && powerUp == true)
        {
            vidaPlayer = vidaPlayer * 0.5;
            print("Ainda Nao, vida atual" + vidaPlayer);
        }
        else 
        {
            print("Game Over");
        }

}

    // Update is called once per frame
    void Update()
    {
        
    }
}
