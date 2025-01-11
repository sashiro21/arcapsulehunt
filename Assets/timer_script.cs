using UnityEngine;
using UnityEngine.UI;

public class timer_script : MonoBehaviour
{
    public Text timerText;
    private float timeRemaining = 30f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
            timerText.text = $"Time: {Mathf.Ceil(timeRemaining)}";
        }
        else
        {
            EndGame();
        }
    }

    void EndGame()
    {
        // Handle game over logic
        Debug.Log("Game Over!");
    }
}
