using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class cambiarMaterial : MonoBehaviour {
    public Texture colorMaterial;
    public Texture blancoMaterial;
    public Canvas MaterialCanvas;
    public Button botonBlancoMaterial;
    public Button botonColorMaterial;

    public GameObject Terreno;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
  
	}

    public void CambiaABlanco()
    {
        //  Terreno.GetComponent<Material>().shader = blancoMaterial;
        Terreno.GetComponent<Renderer>().material.mainTexture = blancoMaterial;
        MaterialCanvas.gameObject.SetActive(false);
        Debug.Log("blanco");
    }

    public void CambiaAColor()
    {
        Terreno.GetComponent<Renderer>().material.mainTexture = colorMaterial;
        MaterialCanvas.gameObject.SetActive(false);
        Debug.Log("color");
    }
}
