using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{

public class dataTarget : MonoBehaviour {

	public Transform TextTargetName;
	public Transform ScrollView;
	public Transform ButtonAction;
	public Transform Button2Action;
	public Transform ContentText;
	public AudioSource soundTarget;
	public AudioClip clipTarget;

	// Use this for initialization
	void Start()
	{			
		soundTarget = (AudioSource)gameObject.AddComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update()
	{
		StateManager sm = TrackerManager.Instance.GetStateManager();
		IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

		foreach (TrackableBehaviour tb in tbs)
		{
			string name = tb.TrackableName;
			ImageTarget it = tb.Trackable as ImageTarget;
			Vector2 size = it.GetSize();

			Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);

			TextTargetName.GetComponent<Text>().text = name;
			ButtonAction.gameObject.SetActive(true);
			Button2Action.gameObject.SetActive(true);
			ScrollView.gameObject.SetActive(true);
			ContentText.gameObject.SetActive(true);
			
				if(name == "IzmitSaatKulesi" || name == "IzmitSaatKulesi1" || name == "IzmitSaatKulesi2" || name == "IzmitSaatKulesi3")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sounds/saatkulesi");
					});
					ContentText.GetComponent<Text>().text = "1900-1901 yıllarında İzmit Mutasarrıfı Musa Kazım Bey denetiminde İzmit Belediyesi tarafından yaptırılmıştır, mimar Vedat Tek’in eseridir.Neoklasik üslupta Hereke ve Tavşancıldan getirilen traverten taşlardan yaptırılan saat kulesi 3,65x3,65 metre ölçülerinde kare planlı olup 4 bölümden oluşmaktadır." +
						"Saat kulesi 16.40 m yüksekliğindedir.Kulenin kuzey cephesinde giriş kısmı bulunmaktadır.1. katın kenarlarında mermer sütunlara, üç kenarında ise  (doğu, batı, güney) çeşmelere yer verilmiştir.Çeşme aynalığında yay içerisinde ay yıldız, ay yıldızın altında da çelenk bulunmaktadır.Çeşmelerin üst kısmındaki bordürlerde kitabe kuşakları yer almaktadır.Kulenin 2. 3. ve 4. katları oldukça hareketli bir şekilde inşa edilmişlerdir." +
						"2. katta köşelerde sütunlara yer verilmiş, her cepheye kaş kemerli açıklıklar konulmuştur.2. katta dökme demir korkuluklardan bir gezinti alanı oluşturulmuştur. Son derece zarif bir yapıda olan korkuluklar döneminin üslup özelliklerini yansıtmaktadır." +
						"Kulenin 3. katında da her cephe yüzeyinde kaş kemerli pencerelere yer verilmiştir. Pencerelerin alt kısımlarında, mermer madalyonlar içerisinde II. Abdülhamid'in tuğrası bulunmaktadır. Ayrıca 3. katın köşelerinde silindirik ve elips şeklindeki düz madalyonlar vardır.Kulenin 4. katında Saat odası yer alır. Dört cephesin de 80 cm çapında saat kadranı bulunmaktadır." +
						"Ünlü Saat Ustası Mustafa Şem-i Pek tarafından yapılan bu saat aktif olarak çalışan son saatlerden biridir. Saatlerin üst kısımlarında üçer pencere kuşağı bulunmaktadır.Saat kulesinin üç tarafında bulunan sebillerin alınlığında ve kapısının üzerinde kitabeler bulunmaktadır.";
					
				}

				//If the target name was “camii” then add listener to ButtonAction with location of the unitychan sound (locate in Resources/sounds folder) and set text on TextDescription a description of the unitychan / robot
				if (name == "YeniCumaCamii" || name == "YeniCumaCamii1" || name == "YeniCumaCamii2")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate {
						 playSound("Sounds/yenicumacamii"); });
					ContentText.GetComponent<Text>().text = "Pertev Mehmet Paşa Külliyesi, Pertev Mehmet Paşa'nın vefatı ardından vasiyeti gereği Kethüda Sinan Ağa tarafından Mimar Sinan'a yaptırılmıştır." +
						"Padişah II. Selim'in 2. veziri Pertev Mehmet Paşa adına, ölümünden sonra vasiyeti üzerine kethüdası Sinan ağa tarafından yaptırılmış ve cami kitabesine göre miladi 1579(Hicri: 987) yılında tamamlanmıştır." +
						"Camii ile birlikte sübyan mektebi ve hamam kalıntısı ayakta durmaktadır.Külliyeden yalnızca cami ve çeşme özelliklerini koruyarak günümüze gelmiştir." +
						"Süryan mektebi onarımlar sonucu özgün şeklini tamamen yitirmiş,hamam ise harabe halinde temel kalıntıları ve sıcaklığının bir kısmı korunmaktadır.";
				}

				if (name == "GayretGemiMuzesi")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate { 
						playSound("Sounds/gayretgemi"); });
					ContentText.GetComponent<Text>().text = "10 Mayıs 1946 yılında ABD tarafından yapılan gemiye USA Everson adı verildi." +
						"1973 yılında USA Everson Gemisi Türk Donanma Komutanlığı'na geçişi yapılarak TCG Gayret adı verildi." +
						"20 yılı aşkın süre içinde bir çok önemli görevi başarıyla yerine getirdi. 1995 yılında hizmet dışına ayrılan TCG Gayret Müze Gemi Projesi kapsamında Kocaeli Valiliği, Kocaeli Büyükşehir Belediyesi ve Donanma Komutanlığı'nın müşterek girişimleri ile modern müzecilik anlayışına göre dekore edilerek," +
						"1997 yılında TCG Gayret Müzesi olarak İzmit sahilinde yeni görevine başlamıştır.";
				}
				if (name == "OsmanHamdiBeyMuzesi")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sounds/osmanhamdibey"); });
					ContentText.GetComponent<Text>().text = "Büyük Türk Müzecisi ve ressamı Osman Hamdi Bey (1842-1910) tarafından Gebze-Eskihisar Köyü'nde," +
						"1884 yılında Köşk, resimhane, kayıkhane ve müştemilat olarak yaptırılmıştır.Planları kendisi tarafından çizilen ve Fransız Mimarisinden etkilenen köşkün yapı malzemelerinin bir çoğu yurtdışından getirilmiştir." +
						"Giriş katındaki ahşap kapıların tablalarına yaptığı çiçek resimlerinin her biri tabloları değerindedir.Osman Hamdi Bey 26 yıl boyunca yaz aylarını geçirdiği köşkte en ünlü tablolarını çizmiştir. ";
				}
				if (name == "SelimSirriPasaKonagi" || name == "SelimSirriPasaKonagi1" || name == "SelimSirriPasaKonagi2")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate { 
						playSound("Sounds/sırrıpasakonagi"); });
				
					ContentText.GetComponent<Text>().text = "Osmanlı'nın ilk yol ve köprü gezici mühendisi unvanına sahip, 1888-1894 yılında İzmit'te Mutasarrıf(Valisi) olan Selim Sırrı Paşa'nın,çizimini bizzat kendisinin yaptığı Selim Sırrı Paşa Konağı 1892 yılında inşa edilmiştir. " +
						"19. yüzyıl sivil mimarlık örneği olan Sırrı Paşa Konağı, 2 katlı ve ahşaptan yapılmış olup konağın iç duvarları antik heykel ve mimari parçaları ile süslenmiştir." +
						"Konağın müştemilatı, Fransa'dan özel olarak getirilen tuğlalarla örülmüştür. Sırrı Paşa Konağı’nın iç mekân duvar bezemelerinin," +
						"Dolmabahçe Sarayı’nın restorasyonunu yapan ressamlar tarafından tezyin edildiği rivayet edilir. Mutasarrıf Sırrı Paşa tarafından yaptırılan zarif mimarisi ve zengin kalemişi süslemeleriyle dikkat çekmektedir.";
				}
				if (name == "KaiserWilhelmKosku")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate { 
						playSound("Sounds/wilhelm"); });
					ContentText.GetComponent<Text>().text = "Eski Sümerbank Dokuma ve halı fabrikası sınırları içerisindeki bu köşk Alman İmparatoru II.Wilhelm’in İstanbul-İzmit demiryolunun açılışında İzmit’e geldiğinde kalabilmesi amacı ile yaptırılmıştır. " +
						"İtalyan Mimar Raimondo d’Aranco tarafından yaptırılmıştır.Köşkün mimari parçaları ve detayları Yıldız Sarayı’nda hazırlanmış ve bu parçalar Hereke’de daha önce hazırlanmış taş temeller üzerine oturtularak monte edilmiştir." +
						"Tek katlı olan köşk, geniş bir salon ve bunun çevresindeki odalardan meydana gelmiştir. İzmit Körfezi’ne yönelik cephesine dikdörtgen pencereler sıralanmıştır." +
						"Köşkün üzeri ahşap kiremitli bir çatı ile örtülmüştür.";
				}
				if (name == "KasriHumayun" || name == "KasriHumayun1" || name == "KasriHumayun2")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate {
						playSound("Sounds/kasrihumayun"); });
					ContentText.GetComponent<Text>().text = "İlk kez IV. Murat döneminde ahşap temeller üzerinde inşa edilmiştir." +
						"Ancak yangın ve deprem nedeni ile yıkıldığı anlaşılmıştır.Günümüze ulaşan yapı; Sultan Abdülaziz döneminde (1861-1876) yapılan saraydır." +
						"Neo–Klasik üslupta, Avrupa-Barok stilinde, iki katlı olup cephesi mermer kaplıdır." +
						"Binanın tavan süslemeleri Fransız ressam SASON’un eseridir. Süslemelerde, Osmanlı arması,Abdülaziz’in tuğrası, bayrak, mızrak, balta ve kılıçtan oluşan grup motifleri, çiçek ve meyve bezemeleri bulunmaktadır." +
						"Sarayın namaz kılınmayan serbest bölgesini içine alan alt kat salon tavanında, geyik ve aslan motifleri bulunur. " +
						"Sarayın alt kat zemini mermer,üst kat ahşap mermer parke döşemelidir." +
						"Mimarı Balyan kardeşlerden Amira Karabat BALYAN’dır. Kasr-ı Hümayun’un en önemli özelliği İstanbul dışında yapılan tek saray olmasıdır.";
				}
				if (name == "SaatciAliEfendiKonagi")
				{
					Button2Action.GetComponent<Button>().onClick.AddListener(delegate { 
						playSound("Sounds/saatcialiefendi"); });
					ContentText.GetComponent<Text>().text = "1776 yılında 1. Abdulhamit zamanında inşa edilmiştir. İzmit’in denize hakim eğimli bir yamacı üzerine inşa edilmiş olan konak ahşap kepenkli ve lokmalı, parmaklıklı pencereleri, dış ve iç duvarlarındaki kalem işi süslemeleriyle dönemini en iyi yansıtan sivil mimarlık örneklerimizdendir.";
				}

		}
	}
	//function to play sound
	 public void playSound(string ss){
		clipTarget = (AudioClip)Resources.Load(ss);
		AudioListener.pause = false;
		soundTarget.clip = clipTarget;
		soundTarget.loop = false;
		soundTarget.playOnAwake = false;
		soundTarget.Play();
		}
}
}