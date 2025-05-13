# Labo 9 - LINQ

In dit labo staat LINQ centraal. Door middel van LINQ kunnen een query uitvoeren op data in het geheugen, dus zonder database. Daarom vertrekken we in de ```StudentStore.cs``` van een bestaande lijst studenten. **Deze lijst wordt op geen enkel moment aangepast, we gaan de enkel gebruiken als basis voor onze queries!**

> [!IMPORTANT]
> Maak tijdens het initialiseren van het MainWindow een nieuwe instantie aan van de StudentStore

## 1. Alle studenten

- Maak een **property** in de StudentStore ```AllStudents``` die een **Array** retourneert van alle studenten.
- Gebruik de code ```resultListBox.ItemsSource = _store.AllStudents;``` om het resultaat te tonen.

## 2. Geslaagd

- Maak een **property** in de StudentStore ```PassedStudents```. Gebruik 'lazy evaluation' om een lijst van studenten te retourneren met een score (grade) groter of gelijk aan 10.
- Toon het resultaat in de resultListBox

## 3. Gesorteerd

- Maak een **functie-methode** in de StudentStore die een lijst van studenten retourneert gesorteerd op voornaam.
- Toon het resultaat in de resultListBox
- Breidt de functie uit zodat eerst op voornaam en daarna op achternaam wordt gesorteerd.

## 4. Aantal studenten per departement

- Maak een functie die een lijst van alle studenten retourneert, gegroepeerd per departement met het aantal studenten per departement.
- Zoek een manier om het resultaat correct weer te geven in de resultListBox
- Breidt de functie uit zodat ook de maximumscore per departement wordt weergegeven

## 5. Samenvatting

- Maak een functie die een object met 4 waardes retourneert:
    - het totaal aantal studenten
    - de minimum score
    - de maximum score
    - de gemiddelde score
- Toon deze waardes via een MessageBox

## 6. Departementen

- Maak een functie die het aantal departementen retourneert
- Toon het resultaat via een MessageBox

## Extra:

> [!TIP]
> Werk verder op dezelfde manier en maak voor elke vereiste een aparte property of functie in de StudentStore

1. Toon de studenten met een onderscheiding (score groter of gelijk aan 14) gesorteerd op score, achternaam en voornaam
2. Vraag door middel van een InputBox de gebruiker om een departement in te geven, toon de studenten van het gevraagde departement
3. Toon de student met de hoogste score per departement, sorteer op departement
4. Toon de top 3 van alle studenten
5. Toon de top 3 studenten per departement, gesorteerd op score
6. Toon het aantal studenten, de gemiddelde-, minimum- en maximumscore per departement. Sorteer de departementen op de gemiddelde score van laag naar hoog
7. Vraag door middel van een InputBox de gebruiker om een naam in te geven, toon de studenten waarbij de ingegeven naam overeenkomt met de voor- en/of achternaam van de student
