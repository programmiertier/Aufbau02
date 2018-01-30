# Aufbau02

Die Biene
Jede Biene ist gelb-schwarz gestreift. Des Weiteren hat jede Biene ein Geschlecht (männlich
oder weiblich), ein Gewicht und ein Alter.

Geschlecht, Alter als auch Gewicht stehen mit Erschaffung einer Biene fest. Das Gleiche gilt
für die Farbe.

Geschlecht, Alter und Gewicht können aber im Laufe des Programms verändert werden. So kann
eine Biene Geburtstag feiern, dann wird sie ein Jahr älter.

Sise kann sich einer Geschlechtsumwandlung unterziehen, dann hat sie das andere Geschlecht.

Und sie kann zu viel fressen, dann wird sie dicker. Sie kann aber auch durch fliegen abnehmen.

Eine Biene kann eine bestimmte Strecke, zu einer Blume, fliegen. Das Bestäuben einer Blume
übernimmt nur eine Biene. Das kann nicht jede.

Eine Blume hat eine Farbe und eine Art.

Im Programmverlauf soll eine Biene erzeugt werden. Die Beine ist etwas dicker. Nun soll sie
fliegen. Dadurch nimmt sie ab. Am Geburtstag fliegt sie zu einer Blume.
Den Honig, den sie beim Bestäuben nimmt, frisst sie und wird dicker.
Deswegen ist sie deprimiert und ändert daraufhin das Geschlecht.


Der Frosche und die Fliege

-	Erstellen Sie eine Klassenbibliothek mit dem Namen „Bibo_Teich“ hinzu.
-	Fügen Sie dieser Klassenbibliothek laut nachfolgender Anwendungsbeschreibung die Klassen Frosch und Fliege hinzu. Definieren Sie Eigenschaften als auch Verhalten der beiden Tiere. Erstellen Sie einen dazu passenden Entwurf.
-	 (UML – Klassendiagramm)
-	Implementieren Sie die Methoden der Oberklasse objekt im Frosch. (3 Stück, siehe Biene)
-	Testen Sie Ihre Klassen auf Funktionalität, indem Sie eine Konsolenanwendung schreiben, in welcher Sie die Klassen der dll verwenden. 

Anwendungsbeschreibung 
Jeder Frosch hat einen Namen, hat zwei Beine, ein maximales Lebensalter sowie ein momentanes Alter und ist entweder hungrig oder satt.
Ein Frosch kann springen – man muss ihm nur sagen wie hoch. Und ein Frosch gibt Geräusche von sich: er macht „Quak" (das machen alle Frösche)
Ein Frosch hat eine individuelle Lebenserwartung. Diese bestimmt sein maximales Alter. Jedes Jahr feiert er Geburtstag  und wird somit ein Jahr älter. Hat er sein maximales Alter erreicht, ist er tot.

Eine Fliege hat Beine und Flügel. 
Kommt ein hungriger Frosch angesprungen und frisst die Fliege, so ist sie tot. Und nur der Frosch darf die Fliege töten.


Erweiterung „Frosch und Fliege“

Schreiben Sie eine Konsolenanwendung, in welcher Sie die Teich_Bibo verwenden und implementieren Sie für folgende Beschreibung einen Ablauf:

Im Programm gibt es drei Frösche. Sie haben unterschiedliche Namen, ein unterschiedliches max Alter und sind alle noch sehr jung (1-2Jahre).

Des Weiteren gibt es im Programm 3 Fliegen – für jeden Frosch eine. 

Der Nutzer gibt ein, welcher der drei Frösche Geburtstag feiern soll. Wenn der entsprechende Frosch beim Feiern nicht stirbt, erhält er eine Fliege (sofern er noch keine bekommen hat). Die Fliege ist anschließend tot (wird dereferenziert, kann kein anderer Frosch mehr fressen).
Das Programm wird solange wiederholt, bis alle drei Fliegen verfüttert wurden oder die Frösche tot sind. 


Bücherliste

Die Klasse
Ein Buch definiert sich über den Autor, den Titel, die Auflage und den Preis. Diese Eigenschaften werden mit Instanziierung eines Buches festgelegt und nicht mehr verändert.
Zwei Bücher sind identisch, wenn diese den gleichen Autor und den gleichen Titel haben.


Bücherliste
In einem Programm gibt es eine Bücherliste mit vielen Büchern.
-	Lassen Sie sich die Liste aller Bücher ausgeben. Verwenden Sie einmal die for-Schleife und zum zweiten die foreach-Schleife.
-	Entfernen Sie das Buch, welches eine Auflage kleiner 10000 hat. Verwenden Sie einmal eine for-Schleife, eine foreach-Schleife und lambda-Expressions.
-	Lassen Sie sich die Bücherliste sortiert ausgeben.
o	Sortiert nach Autor aufsteigend
o	Sortiert nach Preis absteigend
-	Lassen Sie sich alle Bücher ausgeben, deren Preis größer 35.99 ist.  Verwenden Sie eine for-Schleife, eine foreach-Schleife und lambda-Expressions.
-	Suchen Sie nach einem Buch mit dem Titel „Titel 1“. Verwenden Sie die binäre Suche.



