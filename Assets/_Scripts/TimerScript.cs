using UnityEngine;
using TMPro;

public class TimerScript : MonoBehaviour
{
    public GameObject playerCharacter;
    public GameObject WinScreen;
    public GameObject LoseScreen;
    private TextMeshProUGUI timerText;
    private PlayerController PlayerController;
    private float timeRemaining;
    void Start()
    {
        timerText = GetComponent<TextMeshProUGUI>();
        timerText.text = "90.00";
        timeRemaining = 90f;
        PlayerController = playerCharacter.GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if(PlayerController.hasMoved){
            timeRemaining -= Time.deltaTime;
            timerText.text = timeRemaining.ToString();
        }

        if (timeRemaining <= 0 && !WinScreen.activeSelf){
            LoseScreen.SetActive(true);
        }
    }
}
