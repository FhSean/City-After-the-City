using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera CarRearView;
    public Camera CarFrontView;
    public TMPro.TextMeshPro dialogueText;

    // Start is called before the first frame update

    private void Start()
    {
        if (dialogueText == null)
        {
            dialogueText = TMPro.TextMeshPro.FindObjectOfType<TMPro.TextMeshPro>();
            //Debug.Log(dialogueText);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (CarFrontView.enabled == true)
        {
            RearView();

            dialogueText.rectTransform.localScale = new Vector3(-1, 1, 1);
            //Debug.Log("chouhai");
        }
        else
        {
            FrontView();
            dialogueText.rectTransform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void RearView()
    {
        CarFrontView.enabled = false;
        CarRearView.enabled = true;
    }

    public void FrontView()
    {
        //Debug.Log("sbhyx*2");
        CarFrontView.enabled = true;
        CarRearView.enabled = false;
    }
}