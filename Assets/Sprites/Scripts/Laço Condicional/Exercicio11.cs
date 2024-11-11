using UnityEngine;

public class Exercicio11 : MonoBehaviour
{
    [SerializeField] int estado;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (estado) 
        {
            case 1:
                print("Oque eu faco agora, poha?");
                break;

                case 2:
                print("Vishi, mano!");
                break;

                case 3:
                    print("Seloko, fi!"); 
                break;

        default:
                print("Nada a declarar, man!");
                break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
