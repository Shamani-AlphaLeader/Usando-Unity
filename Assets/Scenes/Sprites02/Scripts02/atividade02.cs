using UnityEngine;

public class atividade02 : MonoBehaviour
{
    [SerializeField] int dano = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 5; i++)
        {
            print("ataque" + i + ": dano" + dano);
            dano += 2;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
