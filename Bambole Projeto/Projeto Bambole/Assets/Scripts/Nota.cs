using UnityEngine;

public class Nota : MonoBehaviour {

    [SerializeField] private float speed;
	
	void Update ()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
	}
}
