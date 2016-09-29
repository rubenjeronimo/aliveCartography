using UnityEngine;
using System.Collections;

public class Conceptual : MonoBehaviour {
    public Canvas LeyendaCanvas;
    public Canvas ConceptualCanvas;
    public GameObject ConceptualObjeto;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void ConceptualON()
    {
        ConceptualObjeto.gameObject.SetActive(true);
        LeyendaCanvas.gameObject.SetActive(false);
        ConceptualCanvas.gameObject.SetActive(false);
    }
    public void ConceptualOFF()
    {
        ConceptualObjeto.gameObject.SetActive(false);
        LeyendaCanvas.gameObject.SetActive(false);
        ConceptualCanvas.gameObject.SetActive(false);
    }
}
