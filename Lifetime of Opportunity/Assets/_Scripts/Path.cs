using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{
    private Opportunity opportunity;

    public List<GameObject> years;
    private int cursor;

    private List<GameObject> sec2004;
    private List<GameObject> sec2005;
    private List<GameObject> sec2006;
    private List<GameObject> sec2007;
    private List<GameObject> sec2008;
    private List<GameObject> sec2009;
    private List<GameObject> sec2010;
    private List<GameObject> sec2011;
    private List<GameObject> sec2012;
    private List<GameObject> sec2013;
    private List<GameObject> sec2014;
    private List<GameObject> sec2015;
    private List<GameObject> sec2016;
    private List<GameObject> sec2017;
    private List<GameObject> sec2018;

    private void Awake()
    {
        opportunity = Camera.main.GetComponent<Opportunity>();
        cursor = -1;
        years = new List<GameObject>();
        for (int i = 0; i < this.transform.childCount; i++)
        {
            years.Add(this.transform.GetChild(i).gameObject);
            this.transform.GetChild(i).gameObject.SetActive(false);
        }

        sec2004 = new List<GameObject>();
        for (int i = 0; i < years[0].transform.childCount; i++)
        {
            sec2004.Add(years[0].transform.GetChild(i).gameObject);
        }

        sec2005 = new List<GameObject>();
        for (int i = 0; i < years[1].transform.childCount; i++)
        {
            sec2005.Add(years[1].transform.GetChild(i).gameObject);
        }

        sec2006 = new List<GameObject>();
        for (int i = 0; i < years[2].transform.childCount; i++)
        {
            sec2006.Add(years[2].transform.GetChild(i).gameObject);
        }

        sec2007 = new List<GameObject>();
        for (int i = 0; i < years[3].transform.childCount; i++)
        {
            sec2007.Add(years[3].transform.GetChild(i).gameObject);
        }

        sec2008 = new List<GameObject>();
        for (int i = 0; i < years[4].transform.childCount; i++)
        {
            sec2008.Add(years[4].transform.GetChild(i).gameObject);
        }

        sec2009 = new List<GameObject>();
        for (int i = 0; i < years[5].transform.childCount; i++)
        {
            sec2009.Add(years[5].transform.GetChild(i).gameObject);
        }

        sec2010 = new List<GameObject>();
        for (int i = 0; i < years[6].transform.childCount; i++)
        {
            sec2010.Add(years[6].transform.GetChild(i).gameObject);
        }

        sec2011 = new List<GameObject>();
        for (int i = 0; i < years[7].transform.childCount; i++)
        {
            sec2011.Add(years[7].transform.GetChild(i).gameObject);
        }

        sec2012 = new List<GameObject>();
        for (int i = 0; i < years[8].transform.childCount; i++)
        {
            sec2012.Add(years[8].transform.GetChild(i).gameObject);
        }

        sec2013 = new List<GameObject>();
        for (int i = 0; i < years[9].transform.childCount; i++)
        {
            sec2013.Add(years[9].transform.GetChild(i).gameObject);
        }

        sec2014 = new List<GameObject>();
        for (int i = 0; i < years[10].transform.childCount; i++)
        {
            sec2014.Add(years[10].transform.GetChild(i).gameObject);
        }

        sec2015 = new List<GameObject>();
        for (int i = 0; i < years[11].transform.childCount; i++)
        {
            sec2015.Add(years[11].transform.GetChild(i).gameObject);
        }

        sec2016 = new List<GameObject>();
        for (int i = 0; i < years[12].transform.childCount; i++)
        {
            sec2016.Add(years[12].transform.GetChild(i).gameObject);
        }

        sec2017 = new List<GameObject>();
        for (int i = 0; i < years[13].transform.childCount; i++)
        {
            sec2017.Add(years[13].transform.GetChild(i).gameObject);
        }

        sec2018 = new List<GameObject>();
        for (int i = 0; i < years[14].transform.childCount; i++)
        {
            sec2018.Add(years[14].transform.GetChild(i).gameObject);
        }
        opportunity.SetYearDisplay((cursor + 2004).ToString());
    }

    public void SetCursor(int newCursor)
    {
        cursor = newCursor;
    }
    
    public void PathUntilEvent(int id)
    {
        bool eventFound = false;

        foreach(GameObject go in years)
        {
            go.SetActive(false);
        }

        if (!eventFound)
        {
            years[0].SetActive(!eventFound);
            foreach (GameObject go in sec2004)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[1].SetActive(!eventFound);
            foreach (GameObject go in sec2005)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[2].SetActive(!eventFound);
            foreach (GameObject go in sec2006)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[3].SetActive(!eventFound);
            foreach (GameObject go in sec2007)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[4].SetActive(!eventFound);
            foreach (GameObject go in sec2008)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[5].SetActive(!eventFound);
            foreach (GameObject go in sec2009)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[6].SetActive(!eventFound);
            foreach (GameObject go in sec2010)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[7].SetActive(!eventFound);
            foreach (GameObject go in sec2011)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[8].SetActive(!eventFound);
            foreach (GameObject go in sec2012)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[9].SetActive(!eventFound);
            foreach (GameObject go in sec2013)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[10].SetActive(!eventFound);
            foreach (GameObject go in sec2014)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[11].SetActive(!eventFound);
            foreach (GameObject go in sec2015)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[12].SetActive(!eventFound);
            foreach (GameObject go in sec2016)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[13].SetActive(!eventFound);
            foreach (GameObject go in sec2017)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }

        if (!eventFound)
        {
            years[14].SetActive(!eventFound);
            foreach (GameObject go in sec2018)
            {
                go.SetActive(!eventFound);
                if (go.GetComponent<EventMarker>() != null)
                {
                    if (go.GetComponent<EventMarker>().eventID == id)
                    {
                        eventFound = HitMarker(go);
                    }
                }
            }
        }
    }

    public bool HitMarker(GameObject go)
    {
        opportunity.SetYearDisplay(go.GetComponent<EventMarker>().eventYear.ToString());
        cursor = go.GetComponent<EventMarker>().eventYear - 2004;
        return true;
    }

    public void NextYear()
    {
        opportunity.ClearEventData();
        if (cursor < years.Count - 1)
        {
            EnableAllSections();
            if(cursor >= 0) years[cursor].SetActive(true);
            cursor++;
            years[cursor].SetActive(true);
            EnableAllSections();
            if(years[cursor].GetComponent<Year>() != null) opportunity.SetCurrentEvent(years[cursor].GetComponent<Year>().firstEvent);
            else if (years[cursor + 1].GetComponent<Year>() != null) opportunity.SetCurrentEvent(years[cursor+1].GetComponent<Year>().firstEvent);
            opportunity.SetYearDisplay((cursor + 2004).ToString());
        }
        
    }

    public void PreviousYear()
    {
        opportunity.ClearEventData();
        if (cursor >= 0)
        {
            years[cursor].SetActive(false);
            if(cursor != 0) cursor--;
            if (years[cursor].GetComponent<Year>() != null) opportunity.SetCurrentEvent(years[cursor].GetComponent<Year>().lastEvent);
            else if (years[cursor-1].GetComponent<Year>() != null) opportunity.SetCurrentEvent(years[cursor - 1].GetComponent<Year>().firstEvent);
            opportunity.SetYearDisplay((cursor + 2004).ToString());
        }        
    }

    private void EnableAllSections()
    {
        if(cursor == 0)
        {
            foreach(GameObject go in sec2004)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 1)
        {
            foreach (GameObject go in sec2005)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 2)
        {
            foreach (GameObject go in sec2006)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 3)
        {
            foreach (GameObject go in sec2007)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 4)
        {
            foreach (GameObject go in sec2008)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 5)
        {
            foreach (GameObject go in sec2009)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 6)
        {
            foreach (GameObject go in sec2010)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 7)
        {
            foreach (GameObject go in sec2011)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 8)
        {
            foreach (GameObject go in sec2012)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 9)
        {
            foreach (GameObject go in sec2013)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 10)
        {
            foreach (GameObject go in sec2014)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 11)
        {
            foreach (GameObject go in sec2015)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 12)
        {
            foreach (GameObject go in sec2016)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 13)
        {
            foreach (GameObject go in sec2017)
            {
                go.SetActive(true);
            }
        }
        else if (cursor == 14)
        {
            foreach (GameObject go in sec2018)
            {
                go.SetActive(true);
            }
        }
    }
}
