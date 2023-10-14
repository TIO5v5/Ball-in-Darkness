using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    public GameObject coinPrefab;
    public List<Coin> CoinList = new List<Coin>();
    public TMP_Text CoinText;
    public GameObject bloodMarkPrefab;

    public int initialCoin = 50;

    AudioControler audioControler;

    private void Start()
    {
        audioControler = FindObjectOfType<AudioControler>();
        for (int i = 0; i < initialCoin; i++)
        {
            Vector3 position = new Vector3(Random.Range(-20f, 20f), 0.5f, Random.Range(-20f, 20f));
            GameObject newCoin = Instantiate(coinPrefab, position, Quaternion.identity);
            CoinList.Add(newCoin.GetComponent<Coin>());
        }
        UpdateText();
        audioControler.PlayDeadSound();
    }

    public void CollectCoin(Coin coin)
    {
        CoinList.Remove(coin);
        Destroy(coin.gameObject);
        Vector3 bloodPosition = new Vector3(coin.transform.position.x, 0f, coin.transform.position.z);
        Instantiate(bloodMarkPrefab, coin.transform.position, coin.transform.rotation);



        UpdateText();
    }

    private void UpdateText()
    {
        CoinText.text = "Залишилося монеток:" + CoinList.Count.ToString();
    }

    public Coin GetClosest(Vector3 point)
    {
        float minDistanse = Mathf.Infinity;
        Coin closestCoin = null;

        for (int i = 0; i < CoinList.Count; i++)
        {
            float distance = Vector3.Distance(point,CoinList[i].transform.position);
            if(distance < minDistanse)
            {
                minDistanse = distance;
                closestCoin = CoinList[i];
            }
        }
        return closestCoin;
    } 

    void Update()
    {
        
    }
}
