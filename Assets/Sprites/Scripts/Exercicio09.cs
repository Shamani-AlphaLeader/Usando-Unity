using UnityEngine;

public class Exercicio09 : MonoBehaviour
{
    [SerializeField] int placarTimeA;
        [SerializeField] int placarTimeB;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        placarTimeA = UnityEngine.Random.Range(1, 5);
        placarTimeB = UnityEngine.Random.Range(1, 5);

        if (placarTimeA > placarTimeB)
        {
            print("time A venceu");
        }
        else if (placarTimeB > placarTimeA)
        {
            print("time B venceu");
        }
        else
        {
            if (placarTimeA > 3 && placarTimeB > 3)
            {
                print("empate cabuloso!!!");
            }
            else
            {
                print("so deu empate,mano!");
            }

            // Update is called once per frame
            void Update()
            {

            }
        }
    }
}
