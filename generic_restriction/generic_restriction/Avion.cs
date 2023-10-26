namespace generic_restriction
{
    public class Avion : Ivolant
    {
        private string model;
        private int num;
        public void DeplierLesAiles()
        {
            Console.WriteLine("Je déplie mes ailes mécaniques");
        }

        public void Voler()
        {
            Console.WriteLine("J'allume le moteur");
        }
    }
}
