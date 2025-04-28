using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI acornText;

    // Start is called before the first frame update
    void Start()
    {
        acornText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateAcornText(playerCollection playerCollection)
    {
        acornText.text =  "Acorns Collected " + playerCollection.acornCount.ToString()  + "/10";
    }
}

    // void UpdateAcornText(playerCollection playerCollection)
    // {
    //     acornText.text = "Acorns Collected " + playerCollection.acornCount.ToString() + "/10";
    // }

