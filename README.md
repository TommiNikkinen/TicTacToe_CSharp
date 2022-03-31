# TicTacToe_CSharp
# 1 Yleiskuvaus
Ohjelma perustuu perinteiseen ristinolla peliin. Käyttöliittymästä löytyvät pääikkuna, jossa näkyvät lisätyt pelaajat ja näiden tilastot. Lisää pelaaja - ikkuna, jossa käyttäjä voi lisätä uuden pelaajan ja pelilauta ikkuna, jossa itse peli toteutuu.


# 2 Käyttöliittymä ja toiminta
2.1 Pääikkuna

⦁	Pääikkunassa pelaaja tai pelaajat voivat valita jo ennakkoon luodun pelaajan tai lisätä uudet pelaajan tiedot painamalla Add Player-nappia. Vain Player 2 voi olla Cpu(Tietokonepelaaja). Pääikkunassa näkyvät pelaajan tietojen lisäksi näiden voitot, häviöt ja tasapelit. Menu valikosta käyttäjä voi sulkea sovelluksen Exit-napilla. Pelaajien tiedot haetaan players.json tiedostosta.

 
2.2 Lisää pelaaja - ikkuna

⦁	Ikkunassa käyttäjä voi lisätä uuden pelaajan. Etu -ja sukunimessä on validointi joissa käyttäjän pitää syöttää vähintään kaksi kirjainta. Tekstikenttiin voi syöttää vain kirjaimia. Syntymäpäiväksi tulee valita nykyinen tai mennyt päivämäärä. Tiedot tallennetaan players.json-tiedostoon, joka sijaitsee kansiossa “C:/Temp”


2.3 Pelilauta ikkuna

⦁	3x3 pelilauta piirtyy ruudulle. Pelaaja yksi aloittaa oletuksena pelin. Ruutuun klikatessa sovellus piirtää ruutuun pelaajan merkin ja vuoro vaihtuu. Peliä pelataan niin pitkään kunnes voittaja löytyy tai tulee tasapeli. Pelin päättyessä ohjelma ilmoittaa voittajan ja sulkee peli-ikkunan


# 3 Tiedostot
3.1 Form3.cs(Pääikkuna)

⦁	Pääikkunan tiedosto. Tiedot haetaan players.json tiedostosta ja näytetään datagridview-näkymissä, jos tiedostoa ei löydy se luodaan ja lisätään cpu-pelaaja ensimmäiseksi pelaajaksi(id = 1). Add player - nappia painamalla aukeaa lisää pelaaja ikkuna, jos pelaajaa ollaan jo lisäämässä estetään uuden ikkunan aukaiseminen. Päivitetään datagridview-näkymät, jos uusi pelaaja lisätään. Start Game - nappia painamalla aukeaa peli-ikkuna, jonne viedään parametrina pelaajien tiedot. Ennen pelin aukeamista tarkistetaan että valittuna on kaksi eri pelaajaa ja vain “player 2” voi olla valittuna tietokone pelaajaksi. Pelin päätyttyä päivitetään datagridview-näkymät.

3.2 AddPlayerForm.cs(Lisää pelaaja)

⦁	Tässä tiedostossa haetaan pelaajien tiedot players.json tiedostosta ja validoidaan käyttäjän syötteet. Nimi kenttiin voidaan syöttää vain kirjaimia ja nimen tulee sisältää vähintään kaksi kirjainta. Syntymäpäiväksi täytyy valita joko nykyinen tai mennyt päivämäärä. Validoinnin täytyttyä lisätään pelaaja players.json tiedostoon ja suljetaan ikkuna.

3.3 Form2.cs(Pelilauta)

⦁	Peliruutu piirtyy näytölle ja  pelaajien tiedot tuodaan pääikkunasta, alakentän status kenttään päivitetään pelaajien etunimet. Pelaaja 1 aloittaa pelin ja klikkaa hiirellä yhteen ruuduista. Ohjelma tarkistaa mihin ruutuun pelaaja klikkasi MouseUp-funktiossa. Samalla tarkistetaan oliko klikattu ruutu tyhjä, jos oli piirretään siihen pelaajan merkki ja vuoro vaihtuu. 

⦁	Mikäli toinen pelaaja on tietokonepelaaja käynnistetään tietokonepelaajan ajastin ja kutsutaan cpu_Play-funktiota. Funktiossa käydään läpi ruudut ja pelataan merkki vapaana olevaan ruutuun. Kolmannen vuoron jälkeen ohjelma alkaa tarkistamaan täyttyvätkö voitto kriteerit. Peli päättyy jos voitto kriteerit täyttyvät tai peli päättyy tasapeliin. 

⦁	Pelin tiedot kirjoitetaan pelaajien tilastoihin players.json tiedostoon. Id-kenttää hyväksi käyttäen varmistutaan että tilastot päivittyvät oikein. Ilmoitetaan voittaja tai tasapeli, iIkkuna sulkeutuu ja pääikkuna päivittyy.

⦁	Koodissa estetään tietokoneen vuoron aikana ruutuihin klikkaaminen ja pelin sekoittaminen.

3.4 Player.cs(Peaja)

⦁	Pelaaja luokka

