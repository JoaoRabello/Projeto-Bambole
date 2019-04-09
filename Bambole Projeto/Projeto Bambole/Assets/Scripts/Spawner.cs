using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float tempoS = 0;
    public float tempoPerm = 0;
    public int pos = 0;
    public int linha = 0;

    float timer = 0f;

    string musicChart = "3072 = N 2 0.3264 = N 2 0.3264 = N 3 0.4800 = N 4 0.4800 = N 0 0.4800 = N 3 0.6336 = N 1 0.6336 = N 2 06624 = N 1 0.6624 = N 2 0.6912 = N 1 0.6912 = N 2 0.7200 = N 1 0.7200 = N 2 0.7680 = N 1 0.7680 = N 3 0.7968 = N 1 0.7968 = N 3 0.8256 = N 1 0";
    string[] linhas = new string[100];
    string[,] nota = new string[100,100];
    [SerializeField] GameObject[] notas = new GameObject[5];

	void Start () {

        musicChart = musicChart.Replace('=', ' ');

        linhas = musicChart.Split('.');
        for (int i = 0; i < linhas.Length; i++)
        {
            string[] temp = new string[6];
            temp = linhas[i].Split(' ');
            for(int j = 0; j < 6; j++)
            {
                nota[i, j] = temp[j];
                Debug.Log("Nota em " + i + " x " + j + ": " + nota[i, j]);
            }
        }

        tempoS = float.Parse(nota[linha, 0]);
    }

    void Update () {

        timer += Time.deltaTime * 1000;
        if(tempoS <= timer && linha < linhas.Length)
        {
            Instantiate(notas[int.Parse(nota[linha, 4])]);
            linha++;
            Debug.Log(linha);
            if(linha < linhas.Length)
            {
                tempoS = float.Parse(nota[linha, 0]);
            }
        }

	}
}
