using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public TextMeshProUGUI textoPontos;
    public int pontuacao = 0;

    public void Placar(string status)
    {
        if(status == "Acertou")
        {
            pontuacao++;
            textoPontos.text = pontuacao.ToString();
        }
        else
        {
            pontuacao--;
            textoPontos.text = pontuacao.ToString();
        }
    }
}
