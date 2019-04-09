using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public float tempoS = 0;
    public float tempoPerm = 0;
    public int pos = 0;

    float timeToSpawn = 0f;
    float timer = 0f;

    public string musicChart = "3000 = N 1 0\n7200 = S 3 0";
    string[] linhas = new string[5];
    string[,] nota = new string[10,10];

	void Start () {

        musicChart = musicChart.Replace('=', ' ');

        linhas = musicChart.Split('.');
        for (int i = 0; i < linhas.Length; i++)
        {
            string[] temp = new string[5];
            temp = linhas[i].Split(' ');
            for(int j = 0; j < 6; j++)
            {
                nota[i, j] = temp[j];
                Debug.Log("Nota em " + i + " x " + j + ": " + nota[i, j]);
            }
        }
    }

    void Update () {

        timer += (Time.deltaTime * 1000) % 1000;
        Debug.Log(timer);

	}
}
