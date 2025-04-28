using UnityEngine;

public class acornBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) {
        playerCollection playerCollection = other.GetComponent<playerCollection>();

        if (playerCollection != null){
            playerCollection.acornCollected();
            gameObject.SetActive(false);
        }
    }
}
