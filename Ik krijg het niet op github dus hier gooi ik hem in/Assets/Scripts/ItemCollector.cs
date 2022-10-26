using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int leg = 0;
    private int table = 0;
    private int bolt = 0;
    private int allLeg = 0;
    private int allTable = 0;
    private int allBolt = 0;
    public static bool canEnd = false;

    [SerializeField] private Text cherriesText;

    [SerializeField] private AudioSource collectionSoundEffect;

    private void Awake()
    {
        allTable = GameObject.FindGameObjectsWithTag("table").Length;
        allLeg = GameObject.FindGameObjectsWithTag("leg").Length;
        allBolt = GameObject.FindGameObjectsWithTag("bolt").Length;
        cherriesText.text = table + "\n /\n " + allTable + "\n" + leg + "\n /\n " + allLeg + "\n" + bolt + "\n /\n  " + allBolt;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("leg"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            leg++;
            cherriesText.text = table + "\n /\n " + allTable + "\n" + leg + "\n /\n " + allLeg + "\n" + bolt + "\n /\n  " + allBolt;
        }

        if (collision.gameObject.CompareTag("table"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            table++;
            cherriesText.text = table + "\n /\n " + allTable + "\n" + leg + "\n /\n " + allLeg + "\n" + bolt + "\n /\n  " + allBolt;
        }

        if (collision.gameObject.CompareTag("bolt"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            bolt++;
            cherriesText.text = table + "\n /\n " + allTable + "\n" + leg + "\n /\n " + allLeg + "\n" + bolt + "\n /\n  " + allBolt;
        }

        if (collision.gameObject.CompareTag("Cherry"))
        {
            collectionSoundEffect.Play();
            Destroy(collision.gameObject);
            //timeValue = timeValue + 10;
        }

        if (allLeg == leg && allTable == table && allBolt == bolt)
        {
            canEnd = true;
        }
    }
}
