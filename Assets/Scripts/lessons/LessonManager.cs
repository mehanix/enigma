﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LessonManager : MonoBehaviour
{
    LessonContent[] content;
    // Start is called before the first frame update
    LessonContent[] array;

    public Text title_text;
    public Text content_text;
    public int index=-1;
    void Start()
    {
        content = new LessonContent[6];
   /*      array = new LessonContent[6];

        array[0] = new LessonContent();
        array[0].content="Uh oh... ai apasat pe un link creat de o persoana cu intentii rele!\nCa sa te intorci in realitate, va trebui sa rezolvi niste provocari si sa inveti despre utilizarea in siguranta a calculatorului.\n\nHai sa vorbim despre retelele de socializare!\nNu toti oamenii au intentii bune. Este foarte important ca atunci cand folosesti retele de socializare sa nu oferi date personale necunoscutilor.\n\nOamenii se pot da drept cine nu sunt pe internet, deci e foarte important sa ai grija sa nu comunici cu persoanele straine!";
        array[0].title="Introducere";

        array[1] = new LessonContent();
        array[1].content="Cyberbullying este un alt fenomen pe care este posibil sa il intalnesti in timpul utilizarii internetului.\n\nCyberbullying se refera la hartuirea pe internet. Daca primesti mesaje rautacioase in privat, sau public, pe o retea de socializare, esti o victima a cyberbullying-ului! Foloseste functia de blocare a persoanei si spune-i unui parinte despre asta.\n\nO alta metoda de cyberbully-ing este postarea pe profilul tau, sau al prietenilor, a unor poze in ipostaze neplacute. Pentru a te proteja, ai grija pe cine ai la prieteni si ce poze postezi online!";
        array[1].title="Cyberbullying";

        array[2] = new LessonContent();
        array[2].content="Ca sa fii protejat de posibilele pericole online, precum virusii sau accesul neautorizat, exista doua precautii foarte importante pe care trebuie sa le iei:\n\n1. Instaleaza un Firewall!\n\nUn Firewall este un program ce filtreaza accesul la calculatorul tau, lasand doar aplicatiile alese de tine sa aiba acces la internet.\nAvand un firewall instalat, esti protejat impotriva unor tipuri de atacuri informatice!\n\nIn cazul in care nu vrei sa instalezi un firewall separat, ai grija sa activezi macar Windows Firewall, pe care il gasesti in setari.\n\nDa click pe jos pentru a construi un firewall si a te proteja de atacurile serverelor!";
        array[2].title="Firewall";

        array[3] = new LessonContent();
        array[3].content="2. Instaleaza un Antivirus!\n\nAntivirusul este, dupa cum sugereaza si numele, un program care te ajuta sa te protejezi de programele rau intentionate numite virusi./nUn antivirus poate fi setat sa iti scaneze calculatorul periodic, astfel incat datele tale sa fie in siguranta, sau poate rula in fundal si verifica orice fisier care ajunge in calculatorul tau, astfel incat sa previna infectarea.\n\nTotodata, un calculator functioneaza mai bine cand nu este virusat, asa cum si tu te simti mai bine atunci cand esti sanatos, nu racit.\n\nE momentul sa fii tu antivirus! Sari pe virusii ce au infectat calculatorul pentru a-i distruge.";
        array[3].title="Antivirus";

        array[4] = new LessonContent();
        array[4].content="Phishing?\n\nPhishing este o metoda de furt de identitate! Atacatorii creaza pagini web care seamana cu alte site-uri populare, incercand astfel sa induca in eroare oamenii neatenti care, pacaliti, isi introduc datele personale, precum adresa, conturi bancare etc.\n\nAceste date fiind furate, ele sunt folosite in scopuri rele.\n\nEvita sa fii victima phishingului fiind atent la urmatoarele detalii:\n1. Asigura-te ca pagina pe care esti este securizata HTTPS, si ca linkul nu are greseli, de ex gmeil in loc de gmail, yohoo in loc de yahoo etc.\n2. Nu da click pe linkurile de la care nu cunosti sursa!";
        array[4].title="Phishing";

        array[5] = new LessonContent();
        array[5].content="O alta forma de phishing este cea prin email, unde in loc de site-uri, primesti prin mail un email ce pare real, dar nu este.\nE bine sa nu deschizi niciun email al carei adresa nu o cunosti sau la care nu te astepti.";
        array[5].title="E-mailuri false";

      
string playerToJason = JsonHelper.ToJson(array, true);
File.WriteAllText("lessons.json",playerToJason);
Debug.Log(playerToJason);
*/
  content = JsonHelper.FromJson<LessonContent>(File.ReadAllText("lessons.json"));
Debug.Log(content[0].content);

    nextLesson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void nextLesson() {

        index++;
        if (index == content.Length) index = 0;

         title_text.text = content[index].title;
         content_text.text = content[index].content;
    }

     public void prevLesson() {

        index--;
        if (index == -1) index = content.Length-1;

         title_text.text = content[index].title;
         content_text.text = content[index].content;
    }

    public  void Exit() {
        SceneManager.LoadScene("menu");
    }
}
