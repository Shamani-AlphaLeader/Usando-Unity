using UnityEngine;

public class Exercicio01 : MonoBehaviour
{
    [SerializeField] int vidaHeroi = 100;

    void Start()
    {
        if (vidaHeroi <= 0)
        {
            print("Game Over");
        }
        else
        {
            print("ta Vivo");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
