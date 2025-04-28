using UnityEngine;

public class depositBehaviour : MonoBehaviour
{
    public GameObject WinScreen;

    private void OnTriggerEnter(Collider other){
        playerCollection playerCollection = other.GetComponent<playerCollection>();

        if (playerCollection != null && playerCollection.acornCount==10){
            WinScreen.SetActive(true);
        }
    }
}
