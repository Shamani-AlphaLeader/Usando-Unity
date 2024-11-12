using UnityEngine;

public class atividade03 : MonoBehaviour
{
    [SerializeField] int dinheiroTotal = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int fase = 1; fase <= 10; fase ++) 
        {
        dinheiroTotal += 3;
            print("Dinheiro no total coletado atualmente entre as fases:" + dinheiroTotal);
        }
        print("Dinheiro no Total:" + dinheiroTotal);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
