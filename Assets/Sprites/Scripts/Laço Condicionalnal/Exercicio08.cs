using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] int horas;
    [SerializeField] int dias;
    [SerializeField] float segundos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        segundos += Time.deltaTime;

        if (segundos >= 10f)
        {
            horas++;
            segundos = 0;
            if (horas == 24)
            {
                dias++;
                horas = 0;
                print(dias);
            }

        }
    }
}

