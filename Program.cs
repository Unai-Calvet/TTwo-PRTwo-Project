using System;
using TTwoPRTwoLibrary;
namespace TTwoPRTwo {
    class Program {
        static void Main() {
            const string AskWidthFromRectagle = "Introdueix l'amplada del rectangle: ";
            const string AskHeightFromRectagle = "Introdueix l'altura del rectangle: ";
            const string AskRadiusFromCercle = "Introdueix el radi del cercle: ";
            const string RectangleAreaIs = "L'àrea del rectangle és: ";
            const string CercleCircumferenceIs = "La circumferència del cercle és: ";
            const string AreaIsGreater = "L'àrea és més gran de ";
            const string AreaIsBetween = "L'area es entre {0} i {1}";
            const string AreaIsLower = "L'àrea és menor o igual a ";
            const int HigherComparingNumber = 50;
            const int LowerComparingNumber = 20;
            double width, height, area, radius, circumference;

            width = Utils.AskValue(AskWidthFromRectagle);
            height = Utils.AskValue(AskHeightFromRectagle);
            area = Utils.CalculateRectangleArea(height, width);
            Console.WriteLine("{0}{1}", RectangleAreaIs, area);

            radius = Utils.AskValue(AskRadiusFromCercle);
            circumference = Utils.CalculateCircumference(radius);
            Console.WriteLine("{0}{1}", CercleCircumferenceIs, circumference);

            if (Utils.IsValueHigherThan(area, HigherComparingNumber)) {
                Console.WriteLine("{0}{1}", AreaIsGreater, HigherComparingNumber);
            }
            else {
                if (Utils.IsValueHigherThan(area, LowerComparingNumber)) {
                    Console.WriteLine(AreaIsBetween, LowerComparingNumber, HigherComparingNumber);
                }
                else {
                    Console.WriteLine($"{AreaIsLower}{LowerComparingNumber}");
                }
            }
        }
    } 
}