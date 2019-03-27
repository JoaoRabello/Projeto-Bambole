using UnityEngine;

public class Botao : MonoBehaviour {

    public bool temNota = false;
    private GameObject nota;
    public char botao;

    [SerializeField] private GameManager gm;

	void Update ()
    {
		if(getBotao())
        {
            if (temNota)
            {
                gm.Placar("Acertou");
                Destroy(nota);
            }
            else
            {
                gm.Placar("Errou");
            }
        }
	}

    bool getBotao()
    {
        switch (botao)
        {
            case 'Q':
                if (Input.GetKeyDown(KeyCode.Q))
                    return true;
                break;
            case 'W':
                if (Input.GetKeyDown(KeyCode.W))
                    return true;
                break;
            case 'E':
                if (Input.GetKeyDown(KeyCode.E))
                    return true;
                break;
            case 'R':
                if (Input.GetKeyDown(KeyCode.R))
                    return true;
                break;
        }
        return false;
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.CompareTag("Nota"))
        {
            nota = c.gameObject;
            temNota = true;
        }
    }

    private void OnTriggerExit2D(Collider2D c)
    {
        if (c.gameObject.CompareTag("Nota"))
        {
            nota = null;
            temNota = false;
        }
    }
}
