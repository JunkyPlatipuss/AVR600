using UnityEngine;

public class TutorialScript : MonoBehaviour
{

    public GameObject playerCharacter;
    private PlayerController PlayerController;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PlayerController = playerCharacter.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerController.hasMoved){
            gameObject.SetActive(false);
        }
    }
}
