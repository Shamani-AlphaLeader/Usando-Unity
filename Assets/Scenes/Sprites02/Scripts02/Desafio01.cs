using UnityEngine;

public class Desafio01 : MonoBehaviour
{
    [SerializeField] string texto = "Jogos Digitais";
    [SerializeField] int contadorConsoantes;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < texto.Length; i ++) 
        {
        char letra = texto[i];

            if ("bcdfghjklmnpqrstvwxyz".Contains(char.ToLower (letra))) 
            {
            contadorConsoantes ++;
            }
        }
        print("numero total de consoantes:" + contadorConsoantes);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
