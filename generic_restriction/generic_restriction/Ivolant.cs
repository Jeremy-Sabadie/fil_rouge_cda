namespace generic_restriction
{
    public interface Ivolant
    {
        void DeplierLesAiles()
        {
            Console.WriteLine("Je déplie mes ailes ");
        }
        void Voler()
        {
            Console.WriteLine("J'allume le moteur");
        }
        public static T Creer<T>() where T : Ivolant, new()
        {
            {
                T t = new T();
                t.DeplierLesAiles();
                t.Voler();
                return t;
            }

        }


    }
}

