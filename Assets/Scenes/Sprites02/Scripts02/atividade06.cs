using UnityEngine;

public class atividade06 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            if (i % 3 != 0 && i % 5 != 0) 
            {
                print("Fizz Buzz");
            }
            else if (i % 5 == 0)
            {
                print("Buzz");
            }
            else if (i % 3 == 0)
            {
                print("Fizz");
            }
            else 
            { 
            print(i);
            }
        }
        

        // Update is called once per frame
        void Update()
        {

        }
    }
}
