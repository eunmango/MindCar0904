using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger_com : MonoBehaviour {

	public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

	public GameObject MinuteDisplay;
	public GameObject SecondDisplay;
	public GameObject MilliDisplay;

	public GameObject LapTimeBox;

	public GameObject FinishText;

	// public GameObject MilliDisplay;
	// public GameObject MilliDisplay;

	void OnTriggerEnter(Collider Car1)
	{

		if (Car1.gameObject.tag == "Car1")
		{
			if (LapTimeManager_com.SecondCount <= 9)
			{
				SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager_com.SecondCount + ".";
			}
			else
			{
				SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager_com.SecondCount + ".";
			}

			if (LapTimeManager_com.MinuteCount <= 9)
			{
				MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager_com.MinuteCount + ":";
			}
			else
			{
				MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager_com.MinuteCount + ":";
			}

			MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager_com.MilliDisplay;

			LapTimeManager_com.MinuteCount = 0;
			LapTimeManager_com.SecondCount = 0;
			LapTimeManager_com.MilliCount = 0;

			HalfLapTrig.SetActive(true);
			LapCompleteTrig.SetActive(false);


			FinishText.GetComponent<Text>().text = "FINISH";
			FinishText.SetActive(true);

		}


	}

}
