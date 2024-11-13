using System;
using UnityEngine;

public class Desafio02 : MonoBehaviour
{
    [SerializeField] int diaNascimento;
    [SerializeField] int mesNascimento;
    [SerializeField] int anoNascimento;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int diaAtual = DateTime.Now.Day;
        int mesAtual = DateTime.Now.Month;
        int anoAtual = DateTime.Now.Year;

        int anosVividos = anoAtual - anoNascimento;
        int mesesVividos = mesAtual - anoNascimento;
        if(mesesVividos <0) 
        {
            anosVividos--;
            mesesVividos += 12;
        }
        int diasVividos = diaAtual - diaNascimento;
        if (diasVividos <0) 
        {
            mesesVividos--;
            diasVividos += 30;
            if (mesesVividos < 0) 
            {
                anosVividos--;
                mesesVividos += 12;
            }
        }
        print("Voce viveu: " + diasVividos + "dias," + mesesVividos + "meses," + anosVividos + "anos.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
