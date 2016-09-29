using UnityEngine;
using System.Collections;

public class BotonConceptual : MonoBehaviour {
    public Canvas ConceptualCanvas;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        ConceptualCanvas.gameObject.SetActive(true);
    }
    public void MuestraMenu()
    {
        ConceptualCanvas.gameObject.SetActive(true);
    }
}
