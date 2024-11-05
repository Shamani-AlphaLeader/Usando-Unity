using UnityEngine;

public class Exercicio08 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField]int hora;
    [SerializeField]int dia;
    [SerializeField] float segundos;
    void Start()
    {
        segundos += Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
