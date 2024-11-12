using UnityEngine;

public class atividade08 : MonoBehaviour
{
    string palavra = "Ao Vento";
    string invertida = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = palavra.Length -1; i >= 0; i--) 
        {
        invertida += palavra[i];
        }
        print("String foi Invertida" +invertida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
