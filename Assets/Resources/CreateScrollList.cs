using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]
public class item{
	public string name;
	public string address;
	public Sprite image;
	public Sprite mapimage;
	public Button.ButtonClickedEvent click;
}
public class CreateScrollList : MonoBehaviour {
	float width=800f;
	float height=1280f;
	public GameObject sampleButton;
	public Transform contentPanel;
	public List<item> itemList;

	void Start()
	{
		PopulateList ();
		gameObject.GetComponent<Camera> ().aspect = (width / height) * (Screen.width / Screen.height);
	}

	void PopulateList()
	{
		foreach (var item in itemList) {
			GameObject newButton = Instantiate (sampleButton) as GameObject;
			SampleButton buttonScript = newButton.GetComponent < SampleButton>();
			buttonScript.icon.sprite = item.image;
			buttonScript.namelabel.text = item.name;
			buttonScript.addresslabel.text = item.address;
			buttonScript.mapicon.sprite = item.mapimage;
			buttonScript.button.onClick = item.click;
			newButton.transform.SetParent (contentPanel);
		}
	}

	public void Address_tower()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Kemalpa%C5%9Fa+Mahallesi,+%C4%B0zmit+Saat+Kulesi,+41200+%C4%B0zmit%2FKocaeli/@40.76283,29.9174113,17z/data=!3m1!4b1!4m5!3m4!1s0x14cb458436f135d9:0x9c7d1205fce25cf7!8m2!3d40.76283!4d29.9196?hl=tr");
	}
	public void Address_yenicuma()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Yeni+Cuma+Cami/@40.7627312,29.928894,17z/data=!3m1!4b1!4m5!3m4!1s0x14cb457fabaa1a2f:0x2e8789473312e92e!8m2!3d40.7627312!4d29.9310827?hl=tr");
	}
	public void Address_aliefendi()
	{
		Application.OpenURL("https://www.google.com.tr/maps/search/saat%C3%A7i+%C5%9Eirinsulhiye+Mahallesi,+Ali+Efendi+Sokak,+Kartepe%2FKocaeli/@40.7668902,29.92446,16z/data=!3m1!4b1?hl=tr");
	}
	public void Address_osman()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Osman+Hamdi+Bey+Evi+ve+M%C3%BCzesi/@40.769375,29.4271268,15z/data=!4m2!3m1!1s0x0:0xb8320b5bebc2a90a?sa=X&ved=0ahUKEwjMoqyeh9fTAhVIkRQKHTDGBOMQ_BIIeTAO");
	}
	public void Address_selim()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Selim+S%C4%B1rr%C4%B1+Pa%C5%9Fa+Kona%C4%9F%C4%B1/@40.76541,29.920675,15z/data=!4m5!3m4!1s0x0:0x379d7eaeb07b0f3!8m2!3d40.76541!4d29.920675");
	}
	public void Address_kaiser()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Ka%C4%B1ser+2.+W%C4%B1lhelm+K%C3%B6%C5%9Fk%C3%BC+Ve+Tarihi+Misafirhanesi/@40.783201,29.6156542,15z/data=!4m5!3m4!1s0x0:0x69ef212edeb1ef4b!8m2!3d40.783201!4d29.6156542");
	}
	public void Address_kasrı()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Kasr-%C4%B1+H%C3%BCmayun+Saray+M%C3%BCzesi/@40.763342,29.919692,15z/data=!4m5!3m4!1s0x0:0xc380db20a532ee20!8m2!3d40.763342!4d29.919692");
	}
	public void Address_gemi()
	{
		Application.OpenURL("https://www.google.com.tr/maps/place/Gayret+Gemi+M%C3%BCzesi/@40.761134,29.916501,15z/data=!4m2!3m1!1s0x0:0xd7986babbca35b0b?sa=X&ved=0ahUKEwi10py0idfTAhWGaRQKHbeJC6AQ_BIIhwEwDg");
	}

}
