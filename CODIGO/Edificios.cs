using UnityEngine;
using System.Collections;

public class Edificios : MonoBehaviour {
    public Canvas LeyendaCanvas;
    public Canvas EdificiosCanvas;
    public GameObject EdificiosObjeto;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void edificiosON()
    {
        EdificiosObjeto.gameObject.SetActive(true);
        LeyendaCanvas.gameObject.SetActive(false);
        EdificiosCanvas.gameObject.SetActive(false);
    }
    public void edificiosOFF()
    {
        EdificiosObjeto.gameObject.SetActive(false);
        LeyendaCanvas.gameObject.SetActive(false);
        EdificiosCanvas.gameObject.SetActive(false);
    }
}
