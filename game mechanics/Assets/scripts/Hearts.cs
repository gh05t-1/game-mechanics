using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hearts : MonoBehaviour
{
    private Image[] images;
    private Image[] hearts;
    private int lives;
    private int maxLives;
    // Start is called before the first frame update
    void Start()
    {
        images = GetComponentsInChildren<Image>();
        int count = 0;
        foreach (Image img in images)
        {
            if (img.name == "Heart")
            {
                count++;
            }
        }
        hearts = new Image[count];
        count = 0;
        foreach (Image img in images)
        {
            if (img.name == "Heart")
            {
                hearts[count] = img;
                count++;
            }
        }
        lives = hearts.Length;
        maxLives = hearts.Length;
    }

    public int Lives
    {
        get { return lives; }
        set
        {
            if (value <= maxLives && value >= 0)
            {
                lives = value;
                for (int i = 0; i < hearts.Length; i++)
                {
                    if (i < lives)
                    {
                        hearts[i].enabled = true;
                    }
                    else
                    {
                        hearts[i].enabled = false;
                    }
                }
                if (lives == 0) PauseGame();
            }

        }
    }
    private void PauseGame() 
    {
        Time.timeScale = 0;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
