using UnityEngine;

public class Exercicio07 : MonoBehaviour
{
    [SerializeField] int faces;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (faces == 0)
        {
            print("O numero de faces do dado nao pode ser:" + faces);
        }
        else
        { 
        print(Random.Range(1, faces));
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
