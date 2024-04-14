using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static MonsterGeneration;

public class GameManager : MonoBehaviour
{
    public GameObject HeadsPanel;
    public GameObject EyesPanel;
    public GameObject BodysPanel;
    public GameObject ArmsPanel;
    public GameObject LegsPanel;
    public GameObject[] drops;
    public GameObject Summon;
    public GameObject Cauldron;
    public GameObject DropPoint;
    public GameObject SummonPoint;
    public GameObject IngredientsText;
    //Buttons

    public GameObject retryButton;

    public Button[] ButtonPrefab;
    public Transform[] ButtonPosition;
    public Button[] buttonsOnScene;



    //text
    public GameObject[] captureButtons;
    public TMP_InputField MonsterName;

    public GameObject Courtain;

    public AudioSource audioSource;
    public AudioClip splash;

    private void Start()
    {
        generateButtons();
    }


    public enum parts
    {
        Head,
        Eyes,
        Body,
        Arms,
        Legs,
    }

    public parts CurrentPart;

    public static GameManager gm;
    private void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }





    public void drop(string part)
    {
        setPart(part);
        blockButtons();
        switch (part)
        {
            case "Skeleton":
                Instantiate(drops[0], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Snake":
                Instantiate(drops[1], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Demon":
                Instantiate(drops[2], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Wolf":
                Instantiate(drops[3], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Fly":
                Instantiate(drops[4], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Arachne":
                Instantiate(drops[5], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Human":
                Instantiate(drops[6], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            case "Harpy":
                Instantiate(drops[7], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
            
            case "Ghost":
                Instantiate(drops[8], DropPoint.transform.position, DropPoint.transform.rotation);
                break;
        }


    }



    public void changeState(string part)
    {

        switch (CurrentPart.ToString())
        {
            case "Head":
                IngredientsText.GetComponent<TMP_Text>().text = "Select the ingredientes for: Eyes";
                DestroyButtons();
                generateButtons();
                CurrentPart++;
                break;
            case "Eyes":
                IngredientsText.GetComponent<TMP_Text>().text = "Select the ingredientes for: Body";
                DestroyButtons();
                generateButtons();
                CurrentPart++;
                break;
            case "Body":
                IngredientsText.GetComponent<TMP_Text>().text = "Select the ingredientes for: Arms";
                DestroyButtons();
                generateButtons();

                CurrentPart++;
                break;
            case "Arms":
                IngredientsText.GetComponent<TMP_Text>().text = "Select the ingredientes for: Legs";

                DestroyButtons();
                generateButtons();
                CurrentPart++;
                break;
            case "Legs":
                IngredientsText.GetComponent<TMP_Text>().text = "Here is the demon you have summoned";
                DestroyButtons();


                Cauldron.SetActive(false);

                Instantiate(Summon, SummonPoint.transform.position, SummonPoint.transform.rotation);
                foreach (var item in captureButtons)
                {
                    item.SetActive(true);
                }
                break;
        }
        audioSource.PlayOneShot(splash);
    }
    public void generateButtons()
    {
        Button[] newButtons = ButtonPrefab;
        
          for (int i = 0; i < 5; i++)
          {
            int random = Random.Range(0, newButtons.Length);
              buttonsOnScene[i] = Instantiate(newButtons[random], ButtonPosition[i]);

            Button[] tempArray = new Button[newButtons.Length - 1];
            int index = 0;
            for (int j = 0; j < newButtons.Length; j++)
            {
                if (j != random)
                {
                    tempArray[index] = newButtons[j];
                    index++;
                }
            }
            newButtons = tempArray;
        }

       
    }

    void blockButtons()
    {

        foreach (var item in buttonsOnScene)
        {
            item.interactable = false;
        }
    }
    void DestroyButtons()
    {

        foreach (var item in buttonsOnScene)
        {
            Destroy(item.gameObject);
        }
    }


    public void setPart(string part)
    {

        switch (CurrentPart.ToString())
        {
            case "Head":
                PlayerPrefs.SetString("Head", part);

                break;
            case "Eyes":
                PlayerPrefs.SetString("Eye", part);

                break;
            case "Body":
                PlayerPrefs.SetString("Body", part);

                break;
            case "Arms":
                PlayerPrefs.SetString("Arm", part);

                break;
            case "Legs":
                PlayerPrefs.SetString("Legs", part);

                break;
        }
    }


    public void screenCapture()
    {
        foreach (var item in captureButtons)
        {
            item.SetActive(false);
        }
        IngredientsText.SetActive(false);
        string route = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop);


        string fileName = "Demon " + MonsterName.text + ".png";


        string fullRoute = Path.Combine(route, fileName);


        ScreenCapture.CaptureScreenshot(fullRoute);

        startAnimation();



    }


    public void startAnimation()
    {
        Courtain.GetComponent<Animator>().Play("skullIn");
    }




}
