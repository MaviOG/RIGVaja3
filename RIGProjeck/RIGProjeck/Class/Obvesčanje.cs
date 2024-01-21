namespace RIGProjeck.Class
{
    public class Obvesčanje
    {
        public List<string> enaslov = new List<string>();  

        public void Obvesti(string Sporočilo)
        {
            foreach (var item in enaslov)
            {
                // enaslov.sporoci(Sporočilo); #Dodaj razred za posiljanje

            }
        }
        public bool IsUserOnList(int index)
        {
            if(index == 1)
            {
                return true;
            }
            else return false;
        }
        

    }
}
