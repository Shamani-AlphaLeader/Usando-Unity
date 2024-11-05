using UnityEngine;

public class TestandoBem : MonoBehaviour
{
    /*
     Operadores relacionais
    
    ==(igual)
    !+(diferente)
    >(maior que)
    <(menor que)
    <=(menor igual)
    >=(maior igual)

    */

    [SerializeField] int vidaHeroi = 100;
    [SerializeField] int vidaVilao = 300;
    string Resultado;

    public string variavelPublica;

    //[SerializeField]private int vidaJogador = 10;

    //float velocidadeCarro = 125.5f;

    //string nomeJogador = "AlphaLeaderJubileus";

    //char apelido = 'A';

    //bool vivo = true;

    //int vida_jogador;

    public int vidaJogador;


    void Start()
    {
        string tutorial = "AlphaLeaderJubileus";

        print(vidaVilao == vidaHeroi);//false
        print(vidaHeroi <= vidaVilao);//true
        print(vidaVilao != vidaHeroi);//true

        //Operador Ternario
        //Condição ? valor a ser atribuido caso verdadeiro : caso falso
        //Resultado = vidaHeroi < vidaVilao ? "Vida Heroi Menor" : "Vida Heroi Maior";
        //print(Resultado);

        if (vidaHeroi < vidaVilao)
        {
            Resultado = ("Vida Heroi Menor");
            print(Resultado);
        }
        else if (vidaHeroi == vidaVilao)
        {
            Resultado = "vida Heroi igual a vida Vilao";
            print(Resultado);

        }
        else
        {
            Resultado = "Vida Heroi Maior";
            print(Resultado);
        }

        void Update()
        {

        }
    }
}
