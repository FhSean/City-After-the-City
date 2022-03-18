using UnityEngine;
using UnityEngine.UI;

public class ButtonSelector : MonoBehaviour
{
    public Button selectButton;

    private void OnEnable()
    {
        if (selectButton != null)
        {
            selectButton.Select();
            //print("selected button");
        }
        else
            Debug.Log("SelectButton was null");
    }
}