using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ContinuarAyuda : MonoBehaviour {
    public Canvas AyudaCanvas;
    public Text AyudaTexto1;
    public Text AyudaTexto2;
    public Text AyudaTexto3;
    public Text AyudaTexto4;
    public Button AyudaBoton;
    public int i = 0;
      

	
	public void Continua(){
            i++;
       // Debug.Log(i);
        if (i == 0)
        {
            AyudaTexto1.gameObject.SetActive(true);
            AyudaTexto2.gameObject.SetActive(false);
            AyudaTexto3.gameObject.SetActive(false);
            AyudaTexto4.gameObject.SetActive(false);
        }
        else  if (i == 1)
            {
            AyudaTexto1.gameObject.SetActive(false);
            AyudaTexto2.gameObject.SetActive(true);
            AyudaTexto3.gameObject.SetActive(false);
            AyudaTexto4.gameObject.SetActive(false);
        }
       else if (i == 2)
        {
            AyudaTexto1.gameObject.SetActive(false);
            AyudaTexto2.gameObject.SetActive(false);
            AyudaTexto3.gameObject.SetActive(true);
            AyudaTexto4.gameObject.SetActive(false);
        }
        else if (i == 3)
        {
            AyudaTexto1.gameObject.SetActive(false);
            AyudaTexto2.gameObject.SetActive(false);
            AyudaTexto3.gameObject.SetActive(false);
            AyudaTexto4.gameObject.SetActive(true);
        }
        else if (i == 4)
        {
            AyudaCanvas.gameObject.SetActive(false);
            AyudaTexto1.gameObject.SetActive(true);
            AyudaTexto4.gameObject.SetActive(false);
            i = 0;
        }

    }

	
}
