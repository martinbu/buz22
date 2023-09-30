/*
 * Rechteck Definition
 * -------------------
 * Im Beispiel Program_03-TimeForfunctions.cs konnten wir das Problem nicht lösen
 * mehrere Werte aus einer Funktion zurückzugeben, da man bei Funktionen nur einen
 * RückgabeType angeben kann.
 * 
 * C# definiert "Build-In" Datentypen wie int, double, string, etc. die wir schon oft verwendet haben.
 * Die Entwickler von C# können aber nicht alle möglichen Datentypen
 * vorhersehen bzw. implementieren die ein Programmierer evtl. für seine Zwecke benötigt.
 * Das wären unendlich viele. Deshalb gibt es in C# die Möglichkeit eigene Datentypen zu
 * definieren. Ein eigener Datentyp kann mit dem Schlüsselwort "class" definiert werden
 * und ist im einfachsten Fall nichts anderes, als eine Zusammenfassung von mehreren Variablen
 * die jeweils aus "Build-In" Datentypen bestehen. Also ein Container aus Variablen Definitionen.
 * 
 * Für unseren Fall definieren wir also einen neuen Datentyp der, da wir mit einem Rechteck arbeiten,
 * wenig überaschend Rectangle genannt wird. Dieser beinhaltet jene 4 Eigenschaften die für die
 * Definition eines Rechteckes notwendig sind. posX, posY, width und height.
 * 
 * Klassen Definition
 * ------------------
 * 
 * <Sichtbarkeit> class <ClassName>
 * {
 *     <Sichtbarkeit> <DatenType> <EigenschaftsName1>
 *     <Sichtbarkeit> <DatenType> <EigenschaftsName2>
 *     ...
 * }
 * 
 * Beispiel
 * --------
 * public class Rectangle
 * {
 *     public double PosX;
 *     public double PosY;
 *     public double Width;
 *     public double Height;
 * }
 * 
 * Zusätzlich haben die Eigenschaften einer Klasse die Möglichkeit eine Sichtbarkeit zu definiert. Wir
 * werden die verschiedenen Möglichkeiten später kennen lernen. Für dieses Beispiel verwenden wir immer
 * die Sichtbarkeit "public". Jeder "sieht" also diese Eigenschaft und darf darauf zugreifen.
 * 
 */

/* ***********************************************************************************
 * Wir haben nun unseren eigenen Datentype "Rectangle" (siehe ganz Unten) definiert.
 * Dieser beschreibt ein Rechteck. Nun möchten wir aus der Beschreibung ein Rechteck erstellen
 * dem wir dann die Werte zuweisen können. Diesen Vorgang nennt man instanzieren, d.h. wir erstellen
 * aus der Beschreibung eine Instanz/Objekt mit der wir arbeiten können. Dazu wird das Schlüsselwort "new"
 * verwendet. Mit dem Punkt Operator können wir anschließend auf die Eigenschaften Zugreifen.
 */

Rectangle rect1 = new Rectangle();
rect1.PosX = 4;
rect1.PosY = 8;
rect1.Width = 10;
rect1.Height = 20;

Rectangle rect2 = new Rectangle();
rect2.PosX = 6;
rect2.PosY = 10;
rect2.Width = 12;
rect2.Height = 22;

Rectangle rect3 = new Rectangle();
rect3.PosX = 8;
rect3.PosY = 12;
rect3.Width = 14;
rect3.Height = 24;

// -----------------------------------------------
// Rechteck Flächenberechnung
// -----------------------------------------------

// Da unser Datentyp Rectangle auch ein Datentyp ist wie double oder int
// können wir eine Instanz davon auch an eine Funktion übergeben. Die
// Definition und die Übergabe wird dadurch vereinfacht
double rect1_area = Rectangle_CalculateArea(rect1);
double rect2_area = Rectangle_CalculateArea(rect2);
double rect3_area = Rectangle_CalculateArea(rect3);

Console.WriteLine("Rect1 Area: {0}", rect1_area);
Console.WriteLine("Rect2 Area: {0}", rect2_area);
Console.WriteLine("Rect3 Area: {0}", rect3_area);


// -----------------------------------------------
// Rechteck Überschneidungsflächenberechnung
// -----------------------------------------------

// vorallem wo es vorher notwendig war viele Parameter zu übergeben,
// reicht es jetzt aus den Container davon zu übergeben. Wir konnten
// hier somit die Anzahl von 8 Parametern auf 2 verringern. Das erspart
// nicht nur Tipparbeit, sondern verringert auch die Fehleranfälligkeit,
// da bei 8 Parametern schnell ein Wert vertauscht werden kann.

double intersectionArea_r1_r2 = Rectangle_CalculateIntersectionArea(rect1, rect2);
double intersectionArea_r1_r3 = Rectangle_CalculateIntersectionArea(rect1, rect3);
double intersectionArea_r2_r3 = Rectangle_CalculateIntersectionArea(rect2, rect3);

Console.WriteLine("Intersection Area of rect1 and rect2: {0}", intersectionArea_r1_r2);
Console.WriteLine("Intersection Area of rect1 and rect3: {0}", intersectionArea_r1_r3);
Console.WriteLine("Intersection Area of rect2 and rect3: {0}", intersectionArea_r2_r3);


// -----------------------------------------------
// Rechteck Funktionalitäten
// -----------------------------------------------

double Rectangle_CalculateArea(Rectangle rect)
{
    // Mit dem Punktoperator kann auf die Eigenschaften zugegriffen werden
    double rectArea = rect.Width * rect.Height;
    return rectArea;
}

// Vorallem hier wird die Definition wesentlich einfacher. Anstatt
// 8 Parameter definieren zu müssen, benötigen wir nur noch 2.
// Das ist nicht nur einfacher sondern auch wesentlich leserlicher!
double Rectangle_CalculateIntersectionArea(Rectangle r1, Rectangle r2)
{
    var intersectionRect = Rectangle_GetIntersectionRectangle(r1, r2);
    var intersectionRectArea = Rectangle_CalculateArea(intersectionRect);

    return intersectionRectArea;
}


/*
 * Mit dem Wissen von Klassen können wir jetzt auch unser Problem lösen
 * ein ganzes Rechteck von einer Funktion zurückzugeben. Wir können nun
 * das resultierende Rechteck erstellen und zurückgeben.
 */

Rectangle Rectangle_GetIntersectionRectangle(Rectangle r1, Rectangle r2)
{
    double left = Math.Max(r1.PosX, r2.PosX);
    double right = Math.Min(r1.PosX + r1.Width, r2.PosX + r2.Width);
    double bottom = Math.Max(r1.PosY, r2.PosY);
    double top = Math.Min(r1.PosY + r1.Height, r2.PosY + r2.Height);

    bool hasIntersection = left < right && bottom < top;

    Rectangle intersectionRectangle = new Rectangle();
    if (hasIntersection == false)
    {
        intersectionRectangle.PosX = 0;
        intersectionRectangle.PosY = 0;
        intersectionRectangle.Width = 0;
        intersectionRectangle.Height = 0;
    }
    else
    {
        intersectionRectangle.PosX = left;
        intersectionRectangle.PosY = bottom;
        intersectionRectangle.Width = right - left;
        intersectionRectangle.Height = top - bottom;
    }

    return intersectionRectangle;
}

/*
 * Wir erstellen einen eigenen Datentype mit dem Namen Rectangle. Dieser
 * besteht aus den 4 Eigenschaften die wir benötigen.
 */
public class Rectangle
{
    public double PosX;
    public double PosY;
    public double Width;
    public double Height;
}
