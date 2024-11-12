using UnityEngine;

public class atividade04 : MonoBehaviour
{
    [SerializeField] int score = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for(int combo = 1; combo <= 7; combo++) 
        {
            score += 10;
        }
        print("Score Atual:" + score);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
