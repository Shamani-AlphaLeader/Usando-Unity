using UnityEngine;

public class Exercicio10 : MonoBehaviour
{
    [SerializeField] string tipoItem;
    [SerializeField] int moeda = 10;
    [SerializeField] bool escudo = false;
    [SerializeField] bool pocaoVida = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        switch (tipoItem) 
        {
            case "Moeda":
                moeda++;
                print("Moeda Coletada" + moeda);
                break;

            case "Escudo":
                escudo = true;
                print("escudo ativado");
                break;

            case "Pocao":
                pocaoVida= true;
                print("Pocao de vida coletada");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
