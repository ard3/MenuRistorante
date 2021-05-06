# MenuRistorante
Esame della Regione Toscana

Questo repo contiene il codice sorgente dell'esercitazione svolta per il voto finale dell esame da parte della Regione Toscana

## Descrizione progetto

Il progetto prevede la realizzazione di una single page application che implementi un CRUD per la creazione, gestione del sistema centralizzato di consegne a
domicilio per un ristorante e la conservazione degli stessi in un database. 


## Struttura del progetto

Di seguito è illustrata la suddivisione in cartelle del progetto.

### Data

Contiene classi e strutture dati, nonché il database:
* `Reperto.cs` rappresenta la struttura dati di un `Reperto`;
* `Periodo.cs` rappresenta la struttura dati di un `Periodo`;
* `Tipologia.cs` rappresenta la struttura dati di una `Tipologia`;
* `DbReperti.cs` rappresenta il `DbContext` e quindi la connessione al database;
* `reperti.db` è il database dei reperti.


### Pages

Il contenuto di `Pages` descrive gli end point del progetto:
* `Index.razor` descrive la pagina home, dalla quale è possibile accedere al gestore del sistema centralizzato di consegne a
domicilio del ristorante;
* `GestionePiatti.razor` descrive la pagina di gestione del menu del ristorante.


## User flow

La home dell'applicazione permette l'accesso al gestore del di consegne a
domicilio per il ristorante ed eventualmente ad altre pagine dell'applicazione.


![Homepage](Docs_src/homepage.png)
__________

La pagina di gestione sistema centralizzato di consegne a
domicilio per un ristorante permette la visualizzazione di una tabella collegata al database, con pulsanti che permettono operazioni di crud e permettono di andare ad un form per modificare un ordine.


![Gestione reperti](Docs_src/view.png)


![Modifica reperto](Docs_src/form.png)
