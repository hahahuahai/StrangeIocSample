using strange.extensions.mediation.impl;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Demo2
{

    public class GuessNumberView : View
    {
        GameObject GuessNumberGO;
        GameObject Card1GO;
        GameObject Card2GO;
        GameObject Card3GO;


        internal void init()
        {
            GuessNumberGO = Instantiate(Resources.Load("GuessMaxNumberCanvas")) as GameObject;



            Card1GO = GuessNumberGO.transform.Find("Card1").gameObject;
            Card2GO = GuessNumberGO.transform.Find("Card2").gameObject;
            Card3GO = GuessNumberGO.transform.Find("Card3").gameObject;



            Card1GO.GetComponent<Button>().onClick.AddListener(Card1Click);
            Card2GO.GetComponent<Button>().onClick.AddListener(Card2Click);
            Card3GO.GetComponent<Button>().onClick.AddListener(Card3Click);

            GuessNumberGO.transform.parent = gameObject.transform;
        }

        private void Card1Click()
        {
            Debug.Log("卡片1被点击！");
            Card1GO.transform.Find("Text").gameObject.SetActive(true);
            Card2GO.transform.Find("Text").gameObject.SetActive(true);
            Card3GO.transform.Find("Text").gameObject.SetActive(true);

            int Card1GONumber = Convert.ToInt32(Card1GO.transform.Find("Text").GetComponent<Text>().text);
            int Card2GONumber = Convert.ToInt32(Card2GO.transform.Find("Text").GetComponent<Text>().text);
            int Card3GONumber = Convert.ToInt32(Card3GO.transform.Find("Text").GetComponent<Text>().text);


            GameObject ResultTxt = GuessNumberGO.transform.Find("ResultTxt").gameObject;
            if (Card1GONumber > Card2GONumber && Card1GONumber > Card3GONumber)
            {
                ResultTxt.GetComponent<Text>().text = "赢!";
                ResultTxt.SetActive(true);
            }
            else
            {
                ResultTxt.GetComponent<Text>().text = "输!";
                ResultTxt.SetActive(true);
            }

        }
        private void Card2Click()
        {
            Debug.Log("卡片2被点击！");

            Card1GO.transform.Find("Text").gameObject.SetActive(true);
            Card2GO.transform.Find("Text").gameObject.SetActive(true);
            Card3GO.transform.Find("Text").gameObject.SetActive(true);

            int Card1GONumber = Convert.ToInt32(Card1GO.transform.Find("Text").GetComponent<Text>().text);
            int Card2GONumber = Convert.ToInt32(Card2GO.transform.Find("Text").GetComponent<Text>().text);
            int Card3GONumber = Convert.ToInt32(Card3GO.transform.Find("Text").GetComponent<Text>().text);


            GameObject ResultTxt = GuessNumberGO.transform.Find("ResultTxt").gameObject;
            if (Card2GONumber > Card1GONumber && Card2GONumber > Card3GONumber)
            {
                ResultTxt.GetComponent<Text>().text = "赢!";
                ResultTxt.SetActive(true);
            }
            else
            {
                ResultTxt.GetComponent<Text>().text = "输!";
                ResultTxt.SetActive(true);
            }
        }
        private void Card3Click()
        {
            Debug.Log("卡片3被点击！");

            Card1GO.transform.Find("Text").gameObject.SetActive(true);
            Card2GO.transform.Find("Text").gameObject.SetActive(true);
            Card3GO.transform.Find("Text").gameObject.SetActive(true);

            int Card1GONumber = Convert.ToInt32(Card1GO.transform.Find("Text").GetComponent<Text>().text);
            int Card2GONumber = Convert.ToInt32(Card2GO.transform.Find("Text").GetComponent<Text>().text);
            int Card3GONumber = Convert.ToInt32(Card3GO.transform.Find("Text").GetComponent<Text>().text);


            GameObject ResultTxt = GuessNumberGO.transform.Find("ResultTxt").gameObject;
            if (Card3GONumber > Card1GONumber && Card3GONumber > Card2GONumber)
            {
                ResultTxt.GetComponent<Text>().text = "赢!";
                ResultTxt.SetActive(true);
            }
            else
            {
                ResultTxt.GetComponent<Text>().text = "输!";
                ResultTxt.SetActive(true);
            }
        }

        internal void initCardsNumber(int Card1Number, int Card2Number, int Card3Number)
        {
            Card1GO.transform.Find("Text").GetComponent<Text>().text = Card1Number.ToString();
            Card2GO.transform.Find("Text").GetComponent<Text>().text = Card2Number.ToString();
            Card3GO.transform.Find("Text").GetComponent<Text>().text = Card3Number.ToString();
        }

    }
}
