using UnityEngine;
using System.Collections;

public class botonEdificios : MonoBehaviour {
    public Canvas EdificiosCanvas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       
    }
    public void MuestraMenu()
    {
        EdificiosCanvas.gameObject.SetActive(true);
    }
}
