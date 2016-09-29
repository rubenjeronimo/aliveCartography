using UnityEngine;
using System.Collections;

public class botonMateriales : MonoBehaviour {
    public Canvas MaterialCanvas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void MuestraMenu()
    {
        MaterialCanvas.gameObject.SetActive(true);
    }
}
