using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class Ayuda : MonoBehaviour {
    public GameObject AyudaCanvas;
    public Text AyudaTexto1;
    public Text AyudaTexto2;
    public Text AyudaTexto3;
    public Text AyudaTexto4;
    // Use this for initialization
    void Start () {
        AyudaTexto1.gameObject.SetActive(true);
        AyudaTexto2.gameObject.SetActive(false);
        AyudaTexto3.gameObject.SetActive(false);
        AyudaTexto4.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void MuestraMenu()
    {
        AyudaCanvas.gameObject.SetActive(true);
    }
}
