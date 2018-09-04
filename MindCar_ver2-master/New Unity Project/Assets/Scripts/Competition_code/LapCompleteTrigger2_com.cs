using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger2_com : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	public GameObject FinishText;

	// public GameObject MilliDisplay;
	// public GameObject MilliDisplay;

	void OnTriggerEnter(Collider Car2)
	{

		if (Car2.gameObject.tag == "Car2")
		{
			if (LapTimeManager2_com.SecondCount <= 9)
			{
				SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager2_com.SecondCount + ".";
			}
			else
			{
				SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager2_com.SecondCount + ".";
			}

			if (LapTimeManager2_com.MinuteCount <= 9)
			{
				MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager2_com.MinuteCount + ":";
			}
			else
			{
				MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager2_com.MinuteCount + ":";
			}

			MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager2_com.MilliDisplay;

			LapTimeManager2_com.MinuteCount = 0;
			LapTimeManager2_com.SecondCount = 0;
			LapTimeManager2_com.MilliCount = 0;

			HalfLapTrig.SetActive(true);
			LapCompleteTrig.SetActive(false);


			FinishText.GetComponent<Text>().text = "FINISH";
			FinishText.SetActive(true);
		}


	}
}
