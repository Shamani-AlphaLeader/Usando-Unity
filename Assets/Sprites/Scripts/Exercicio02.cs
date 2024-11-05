using UnityEngine;

public class Exercicio02 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] bool powerUp;//true
    void Start()
    {
        if (powerUp == true)
        {
            print("Power-Up adquirido");
        }
        else
        {
            print("Nenhum Power-Up foi localizado");
        }

        
        print(powerUp ? "Power-up adquirido" : "Power-Up algum foi encontrado");

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
