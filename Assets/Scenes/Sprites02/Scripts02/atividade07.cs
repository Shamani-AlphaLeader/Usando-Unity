using UnityEngine;

public class atividade07 : MonoBehaviour
{
        int[] numeros = { 3, 5, 7, 10, 68, 23, 71, 18, 97, 1};
    int maior = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        foreach (var item in numeros) 
        {
        if (item > maior)
            {
                maior = item;
            }
        }
        print("O maior numero:" + maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
