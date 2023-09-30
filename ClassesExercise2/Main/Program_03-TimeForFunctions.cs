/*
 * Rechteck Definition
 * -------------------
 * Im Beispiel Program_02-RectIntersection.cs funktionieren die Berechnungen korrekt.
 * Jedoch wurde sehr viel Code kopiert (redunanter Code). Um die implementierten
 * Funktionalitäten wie Flächenberechnung und Überschneidungsflächenberechnung
 * wiederverwenden zu können lagern wir diese Berechnungen in Funktionen aus.
 *
 * Daraus ergeben sich folgende Vorteile:
 *   1) Doppelter Code wird vermieden
 *   2) Der Code ist wesentlich einfacher lesbar, da der Funktionname beschreibt
 *      was in dieser Funktion passiert.
 * 
 * Funktionen
 * ----------
 * Eine Funktionsdefinition besteht immer aus Rückgabetype, Funktionsname und Funktionsparameter.
 * Mit dem Schlüsselwort "return" kann ein Wert an den Funktionsaufrufer zurückgegeben werden.
 * Möchte man keinen Wert von einer Funktion zurückgeben, ist der Rückgabetype void anzuführen. In
 * diesem Fall muss/darf kein return Statement verwendet werden.
 * 
 * Funktions Definition:
 * <RückgabeType> <FunktionsName>(<ParameterType1> <ParameterName1>, <ParameterType2> <ParameterName2>, ...)
 * 
 * Beispiele
 * ---------
 * 
 * int Add(int value1, int value2)
 * {
 *     int sum = value1 + value2;
 *     return sum;
 * }
 * 
 * void PrintSumOf(int value1, int value2)
 * {
 *     int sum = value1 + value2;
 *     Console.WriteLine("{0} + {1} = {2}", value1, value2, sum);
 * }
 * 
 * void SayHello()
 * {
 *     Console.WriteLine("Hello!");
 * }
 * 
 */

double rect1_PosX = 4;
double rect1_PosY = 8;
double rect1_Width = 10;
double rect1_Height = 20;

double rect2_PosX = 6;
double rect2_PosY = 10;
double rect2_Width = 12;
double rect2_Height = 22;

double rect3_PosX = 8;
double rect3_PosY = 12;
double rect3_Width = 14;
double rect3_Height = 24;

// -----------------------------------------------
// Rechteck Flächenberechnung
// -----------------------------------------------

double rect1_area = Rectangle_CalculateArea(rect1_Width, rect1_Height);
double rect2_area = Rectangle_CalculateArea(rect2_Width, rect2_Height);
double rect3_area = Rectangle_CalculateArea(rect3_Width, rect3_Height);

Console.WriteLine("Rect1 Area: {0}", rect1_area);
Console.WriteLine("Rect2 Area: {0}", rect2_area);
Console.WriteLine("Rect3 Area: {0}", rect3_area);


// -----------------------------------------------
// Rechteck Überschneidungsflächenberechnung
// -----------------------------------------------

double intersectionArea_r1_r2 = Rectangle_CalculateIntersectionArea(
    rect1_PosX, rect1_PosY, rect1_Width, rect1_Height,
    rect2_PosX, rect2_PosY, rect2_Width, rect2_Height
);

double intersectionArea_r1_r3 = Rectangle_CalculateIntersectionArea(
    rect1_PosX, rect1_PosY, rect1_Width, rect1_Height,
    rect3_PosX, rect3_PosY, rect3_Width, rect3_Height
);

double intersectionArea_r2_r3 = Rectangle_CalculateIntersectionArea(
    rect2_PosX, rect2_PosY, rect2_Width, rect2_Height,
    rect3_PosX, rect3_PosY, rect3_Width, rect3_Height
);

Console.WriteLine("Intersection Area of rect1 and rect2: {0}", intersectionArea_r1_r2);
Console.WriteLine("Intersection Area of rect1 and rect3: {0}", intersectionArea_r1_r3);
Console.WriteLine("Intersection Area of rect2 and rect3: {0}", intersectionArea_r2_r3);


// -----------------------------------------------
// Rechteck Funktionalitäten
// -----------------------------------------------

double Rectangle_CalculateArea(double width, double height)
{
    double rectArea = width * height;
    return rectArea;
}

double Rectangle_CalculateIntersectionArea(
    double r1_PosX, double r1_PosY, double r1_Width, double r1_Height,
    double r2_PosX, double r2_PosY, double r2_Width, double r2_Height)
{
    double left = Math.Max(r1_PosX, r2_PosX);
    double right = Math.Min(r1_PosX + r1_Width, r2_PosX + r2_Width);
    double bottom = Math.Max(r1_PosY, r2_PosY);
    double top = Math.Min(r1_PosY + r1_Height, r2_PosY + r2_Height);

    bool hasIntersection = left < right && bottom < top;

    if (hasIntersection == false)
    {
        return 0;
    }

    double intersectionWidth = right - left;
    double intersectionHeight = top - bottom;

    double intersectionArea = intersectionWidth * intersectionHeight;

    return intersectionArea;
}

/* **************************************************************************************
 * Der Code schaut nun wesentlich besser aus als in Program_02.
 * Wir können die Funktionalitäten der Flächen- und Überschneidungsflächenberechnung
 * wiederverwenden.
 * 
 * Nun möchten wir aber eine weitere Funktionalität hinzufügen. Es soll nicht nur die
 * Fläche der sich überschneidenden Rechtecke berechnet werden, sondern wir möchten das
 * Rechteck (die Definition davon, also posX, posY, width und height) berechnen und
 * an den Aufrufer zurückgegeben werden.
 * 
 * Einziges Problem, was sollen wir aus RückgabeType angeben? Als Rückgabewert kann, wie oben
 * beschrieben, nur ein Datentype angegeben werden.
 */

// welchen Rückgabe wert sollen wir angeben --> ? Rectangle_GetIntersectionRectangle(
//    double r1_PosX, double r1_PosY, double r1_Width, double r1_Height,
//    double r2_PosX, double r2_PosY, double r2_Width, double r2_Height)
//{
//    double left = Math.Max(r1_PosX, r2_PosX);
//    double right = Math.Min(r1_PosX + r1_Width, r2_PosX + r2_Width);
//    double bottom = Math.Max(r1_PosY, r2_PosY);
//    double top = Math.Min(r1_PosY + r1_Height, r2_PosY + r2_Height);

//    bool hasIntersection = left < right && bottom < top;

//    double intersectionRect_PosX = 0;
//    double intersectionRect_PosY = 0;
//    double intersectionRect_Width = 0;
//    double intersectionRect_Height = 0;

//    if (hasIntersection == false)
//    {
//        intersectionRect_PosX = 0;
//        intersectionRect_PosY = 0;
//        intersectionRect_Width = 0;
//        intersectionRect_Height = 0;
//    }
//    else
//    {
//        intersectionRect_PosX = left;
//        intersectionRect_PosY = bottom;
//        intersectionRect_Width = right - left;
//        intersectionRect_Height = top - bottom;
//    }

//    return ?; <-- Was sollen wir hier zurück geben?
//}