using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MelonPickUp : MonoBehaviour
{
    public int melonCount;
    public int melonCountOverall;
    public TextMeshProUGUI melonText;
    public TextMeshProUGUI melonsOverallText;

    private void Awake()
    {
        melonCount = 0;
        melonCountOverall = 0;

        SetCountText();
    }

    void SetCountText()
    {
        melonText.text = "Melons: " + melonCount.ToString();
        melonsOverallText.text = "Melons: " + melonCountOverall.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("PickUps"))
        {
            melonCount = melonCount + 1;
            melonCountOverall = melonCountOverall + 1;

            SetCountText();
        }
    }

    private void Update()
    {
        SetCountText();
    }
}
