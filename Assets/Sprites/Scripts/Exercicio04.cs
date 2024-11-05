using UnityEngine;

public class Exercicio04 : MonoBehaviour
{
    [SerializeField] bool pocaoVida;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (pocaoVida == false)
        {
            print("nao existem pocoes de vida disponiveis, soldado!");
        }
        else
        {
            print("voce esta usando a pocao de vida, soldado!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
