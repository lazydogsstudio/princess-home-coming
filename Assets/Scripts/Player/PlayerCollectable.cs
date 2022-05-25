using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerCollectable : MonoBehaviour
{

    private int totalCoin = 0;
    private int totalGem = 0;
    public Text coinText;
    public Text gemText;

    private CollectableSoundFx collectableSoundFx;
    // Start is called before the first frame update
    void Start()
    {
        coinText.text = totalCoin.ToString();
        gemText.text = totalGem.ToString();

        collectableSoundFx = GameObject.Find("Sound Manager").GetComponent<CollectableSoundFx>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject tempGameObj = other.gameObject;
        print(tempGameObj.name);

        switch (tempGameObj.tag)
        {
            case "Coin":
                /// Increment Coin; 
                totalCoin += 5;
                coinText.text = totalCoin.ToString();
                collectableSoundFx.PlayCoinSound();
                break;
            case "Gem":
                // Increment Gem;
                totalGem += 1;
                gemText.text = totalGem.ToString();
                collectableSoundFx.PlayGemSound();
                break;
            case "Helath":
                //Incremet HElath;
                break;
            case "Star":
                //Incremnt Star;
                break;
            default:
                break;
        }

        Destroy(tempGameObj);
    }
}
