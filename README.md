# MenuRistorante
Esame della Regione Toscana

Questo repo contiene il codice sorgente dell'esercitazione svolta per il voto finale dell esame da parte della Regione Toscana

## Descrizione progetto

Il progetto prevede la realizzazione di una single page application che implementi un CRUD per la creazione, gestione del sistema centralizzato di consegne a
domicilio per un ristorante e la conservazione degli stessi in un database. 


## Struttura del progetto

Di seguito è illustrata la suddivisione in cartelle del progetto.

### Data

Contiene classi, strutture dati e il database:
* `PiattiRistorante.cs` rappresenta la struttura dati di un `Ordine per la consegna al domicilio`;
* `PiattiDatabase.cs` rappresenta il `DbContext` che sarebbe la connessione al database;
* `Databasepiatti.sqlite` è il database degli ordini.


### Pages

Il contenuto di `Pages` descrive gli end point del progetto:
* `Index.razor` descrive la pagina home, dalla quale è possibile accedere al gestore del sistema centralizzato di consegne a
domicilio del ristorante;
* `GestionePiatti.razor` descrive la pagina di gestione degli ordni e consultazione del menu del ristorante.


## User flow

La home dell'applicazione permette l'accesso agli ordini di consegne a
domicilio per il ristorante ed eventualmente ad altre pagine dell'applicazione.


![Homepage](https://user-images.githubusercontent.com/73218491/117290072-a94d0f00-ae6d-11eb-80a7-6e4f55fb21d4.png)

__________

La pagina di gestione sistema centralizzato di consegne a
domicilio per un ristorante permette la visualizzazione di una tabella collegata al database, con pulsanti che permettono operazioni di crud e permettono di andare ad un form per modificare un ordine.
![GestioneOrdini](https://user-images.githubusercontent.com/73218491/117292946-13b37e80-ae71-11eb-941c-295d869ffe5f.png)
![aggiungiModificaordine](https://user-images.githubusercontent.com/73218491/117293969-5f1a5c80-ae72-11eb-9876-5477f817911c.JPG)






