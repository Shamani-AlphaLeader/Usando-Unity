using UnityEngine;

public class atividade05 : MonoBehaviour
{
    [SerializeField] int dificuldade = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int fase = 1; fase <=6; fase++) 
        {
        dificuldade +=5;
            print("fase" + fase + "dificuldade" + dificuldade);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
