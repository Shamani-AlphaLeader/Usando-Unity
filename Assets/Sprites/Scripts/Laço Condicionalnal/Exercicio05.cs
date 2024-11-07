using UnityEngine;

public class Exercicio05 : MonoBehaviour
{
    public int scoreJogador;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (scoreJogador >= 50)

        {
            print("Missao cumprida, muito bom!!!");
        }
        else
        {
            print("A missao falhou, poha!");
        }



        // Update is called once per frame
        void Update()
        {

        }

    }
}
