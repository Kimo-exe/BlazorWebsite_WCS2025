[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/ESt2DTRN)
# Blazor project - IT Challenges 1

## Wat is Blazor?
Blazor is een webframework ontwikkeld door Microsoft waarmee je webapplicaties kunt bouwen in C# in plaats van de traditionele talen zoals JavaScript. 

Er zijn twee varianten van Blazor: Blazor WebAssembly Stand-alone en Blazor WebApp. Voor dit project maak je een Blazor WebAssembly Standalone project.

In Blazor zit bootstrap standaard geïntegreerd. Een Blazor-applicatie bestaat uit razor-pages waarop je html en C# kunt combineren. Je kunt op die manier voor je output en input gebruik maken van html-elementen. 

## Setup van het project
In dit project vind je volgende mappen:
1. **Layout**: In `NavMenu` bevinden zich de links naar de pagina's.
2. **Pages**: Hier vind je de homepage en 3 voorbeeldpages.
3. **wwwroot**: Hier vind je de css en de bootstrap-bestanden. Als je afbeeldingen wil gebruiken, plaats je ze hier, in een map **Images**. **Index.html** is de pagina die je pagina gaat weergeven in de browser.

Voor je aan de opdracht begint, is het aangeraden de voorbeelden goed te bestuderen om te weten hoe je C# integreert in je html-pagina's.

Om je webapplicatie te starten, selecteer je net zoals bij PRE en OO *Program.cs* en klik je op *run project*.

## Opdracht
Voeg aan het project pagina's toe over een zelfgekozen onderwerp. Kies een onderwerp dat jou interesseert. Dit kan alles zijn van muziekalbums, games, historische gebeurtenissen, sport... Pas het menu aan zodat enkel jouw pagina's worden weergegeven.

## Vereiste functionaliteiten
Volgende onderdelen moeten in de website zitten.
- Homepagina: Een introductie over jouw onderwerp. Voeg dynamische elementen toe, zoals een begroeting gebaseerd op het tijdstip.
- Overzichtspagina: Toon een lijst van minstens vijf items (bijvoorbeeld 5 muziekalbums, 5 dieren, 5 sporters, enzovoort). Maak gebruik van iteraties om deze lijst dynamisch weer te geven.
- Detailpagina: Voor elk item op de overzichtspagina, maak je een detailpagina met extra informatie. Zorg voor interactie door bijvoorbeeld random weetjes te tonen of gebruikers keuzes te laten maken.
- Quiz of Spel: Maak een simpele quiz of een ander interactief element over jouw onderwerp. Gebruik selecties en methoden om gebruikersvragen te verwerken en feedback te geven.

## Vereiste technieken
- Methodes: Zorg dat je minstens drie methodes aanmaakt die specifieke taken uitvoeren (bijv. berekeningen, keuzes verwerken, willekeurige items tonen).
- Iteraties: Gebruik for- of foreach-loops om lijsten dynamisch te genereren.
- Selecties: Voeg if-else of switch-statements toe voor keuzes en interacties.
- Stringmethoden: Pas stringmethoden toe, zoals het formatteren van tekst of dynamische begroetingen.
- Event Handling: Verwerk gebruikersinput met knoppen en interactieve elementen
- Classes: integreer op minstens één pagina classes.

## Layout
Pas de standaard lay-out van het project aan en voeg een persoonlijke touch toe. Je kunt gebruik maken van CSS, Bootstrap-klassen of je eigen stijlen. Volg deze stappen:
- Kies een kleurenschema dat past bij het onderwerp van jouw website. Pas de kleuren aan in de wwwroot/css/app.css of via een aangepaste Bootstrap-stylesheet. 
- Voeg een header en footer toe aan je applicatie. Zorg dat de header jouw onderwerp benadrukt (bijvoorbeeld met een afbeelding of opvallende titel) en dat de footer contactinformatie, auteursinformatie of links bevat.
- Pas de indeling van de pagina's aan. Maak bijvoorbeeld gebruik van meerdere kolommen (row en col in Bootstrap), afbeeldingen als achtergrond of decoratie, kaarten (card in Bootstrap) om inhoud te tonen
- Verander de navigatiebalk: 
    - Gebruik iconen naast de menuteksten
    - Pas de positie aan (bijvoorbeeld verticaal in plaats van horizontaal)
    - Voeg een dropdown-menu toe als je veel pagina's hebt
- Voeg animaties of overgangseffecten toe, zoals:
    - Hover-effecten voor knoppen en links
    - Animaties bij het laden van de pagina of bij gebruikersinteractie (bijvoorbeeld met CSS of JavaScript)
- Responsief Design: Zorg dat jouw website er goed uitziet op zowel desktop als mobiele apparaten. Test dit met behulp van verschillende schermformaten in de browser.
- Gebruik afbeeldingen of illustraties om je website uniek te maken. Plaats deze in de map wwwroot/Images.

## Indienen
Indienen doe je door alle code in deze repository te plaatsen. Gebruik hiervoor de nodige git-commandos.
