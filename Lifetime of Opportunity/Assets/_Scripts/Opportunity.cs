using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Opportunity : MonoBehaviour
{
    private int currentEvent = -1;

    public GameObject eventParent;
    public Path path;

    [Header("Top Border Display")]
    public Text yearDisplay;

    [Header("Event Display")]
    public GameObject imagePanel;
    public GameObject descPanel;

    public Image eventImage;
    public Text eventTitle;
    public Text eventDescription;

    private void Awake()
    {
        ClearEventData();
    }

    public void SetCurrentEvent(int newInt)
    {
        currentEvent = newInt;
    }

    public void DisplayEventData(int id)
    {
        currentEvent = id;
        Event thisEvent = eventParent.transform.GetChild(id).GetComponent<Event>();

        eventImage.sprite = thisEvent.sprite;
        imagePanel.SetActive(true);

        descPanel.SetActive(true);
        eventTitle.text = thisEvent.eventTitle;
        eventDescription.text = thisEvent.description;

        path.PathUntilEvent(id);
    }

    public void ClearEventData()
    {
        descPanel.SetActive(false);
        eventTitle.text = null;
        eventDescription.text = null;

        imagePanel.SetActive(false);
        eventImage.sprite = null;
    }

    public void NextEvent()
    {
        currentEvent++;
        if (currentEvent >= 15) currentEvent = 14;
        DisplayEventData(currentEvent);
    }
    public void PreviousEvent()
    {
        currentEvent--;
        if (currentEvent < 0) currentEvent = 0;
        DisplayEventData(currentEvent);
    }

    public void SetYearDisplay(string year)
    {
        yearDisplay.text = year;
    }
}
