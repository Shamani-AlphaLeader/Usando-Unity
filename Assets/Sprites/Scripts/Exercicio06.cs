using UnityEngine;

public class Exercicio06 : MonoBehaviour
{
    [SerializeField] bool Mago;
    [SerializeField] bool Guerreiro;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (Mago == true && Guerreiro == false)
        {
            print("O mago foi escolhido.");
        }
        else if (Mago == false && Guerreiro == true)
        {
            print("O Guerreiro foi escolhido");
        }
        else if (Mago == true && Guerreiro == true)
        { 
            print("apenas um, bro.");
        }
            else 
        {
            print("so lamento entao, parceiro.");
    }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
