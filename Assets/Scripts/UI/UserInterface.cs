using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UserInterface : MonoBehaviour
{
    public TMP_Text playerNameText;
    public string playerName;

    public Image appleImage;
    public Sprite goblineSprite;

    // Start is called before the first frame update
    void Start()
    {
        playerNameText.text =  "Player Name: " + playerName;
        playerNameText.color = Color.green;

        appleImage.sprite = goblineSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        print("Clicked!!");
    }
}
