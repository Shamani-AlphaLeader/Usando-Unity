using UnityEngine;

public class atividade01 : MonoBehaviour
{
    [SerializeField] private int regressivaInicio = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(CountdownRoutine());
    }

    // Coroutine para realizar a contagem regressiva
    private System.Collections.IEnumerator CountdownRoutine()
    {
        for (int i = regressivaInicio; i >= 1; i--)
        {
            Debug.Log(i); // Exibe o número no Console da Unity
            yield return new WaitForSeconds(1); // Aguarda 1 segundo
        }

        Debug.Log("Início da partida!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
