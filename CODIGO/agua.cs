using UnityEngine;
using System.Collections;

public class agua : MonoBehaviour {
    public Canvas LeyendaCanvas;
    public Canvas AguaCanvas;
    public GameObject aguaObjeto;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void aguaON()
    {
        aguaObjeto.gameObject.SetActive(true);
        LeyendaCanvas.gameObject.SetActive(false);
        AguaCanvas.gameObject.SetActive(false);
    }
    public void aguaOFF()
    {
        aguaObjeto.gameObject.SetActive(false);
        LeyendaCanvas.gameObject.SetActive(false);
        AguaCanvas.gameObject.SetActive(false);
    }
}

