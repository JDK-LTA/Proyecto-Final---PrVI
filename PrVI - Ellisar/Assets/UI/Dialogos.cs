using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    public GameObject panel;


    public string[] SdialogoInicial;
    public string[] SdialogoPelea;
    public string[] SdialogoFinal;

    public Text txtDialogo;
    public bool isDialogActive;

    Coroutine auxCoroutine;

    


    public void AbrirCajaDialogo(int valor)
    {
        if (!isDialogActive)
        {

            auxCoroutine = StartCoroutine(mostrarDialogo(valor));
        }
       
    }


    IEnumerator mostrarDialogo(int valor, float time =0.1f)
    {
        panel.SetActive(true);
        string[] dialogo;
        if (valor == 0) dialogo = SdialogoInicial;
        else if (valor == 1) dialogo = SdialogoPelea;
        else dialogo = SdialogoFinal;

        int total = dialogo.Length;
        string res = "";
        isDialogActive = true;
        yield return null;
        for (int i = 0; i< total; i++)
        {
            res = "";
            if (isDialogActive)
            {
                for (int s = 0; s < dialogo[i].Length; s++)
                {
                    if (isDialogActive)
                    {
                        res = string.Concat(res, dialogo[i][s]);
                        txtDialogo.text = res;
                        yield return new WaitForSeconds(time);
                    }
                    else yield break;
                }
                yield return new WaitForSeconds(3f);
            }
            else yield break;
        }
        yield return new WaitForSeconds(3f);
        Debug.Log("Cerramos MSORAR");

        CerrarDialogo();

    }

    IEnumerator esperaSolapacionDialogo(int valor)
    {
        yield return new WaitForEndOfFrame();
        auxCoroutine = StartCoroutine(mostrarDialogo(valor));
    }

    public void CerrarDialogo()
    {
        
        isDialogActive = false;
        if(auxCoroutine !=null)
        {
            Debug.Log("Detenida");
            StopCoroutine(auxCoroutine);
            auxCoroutine = null;
        }
        txtDialogo.text = "";
        panel.SetActive(false);
    }

    
}
