namespace RIGProjeck.Class
{
    
    public class Nepremičnina
    {
        NepremicninaDB nepremicnineDb = new NepremicninaDB();
		public int NepremičninaID { get; set; }
        public string lokacija { get; set; }
        public int cena { get; set; }
        public DateOnly dan_izgradnje { get; set; }
        public int stevilo_kopalnic { get; set; }
        public int stevilo_prostorov { get; set; }
        public int velikost { get; set; }
        public int stevilo_balkonov { get; set; }
        public int stevilo_spalnic { get; set; }
        public int uporabnikov_id {  get; set; }
        public List<int> Ocena { get; set; }
        public List<string> Komentarji { get; set; }
        public List<Nepremičnina> BoostedAds {get;set;}
		public List<Nepremičnina> UporabnikoveObjave { get; set; }
        public List<Nepremičnina> VseObjave { get; set; }
        public Nepremičnina()
        { }
        public Nepremičnina(string lokacija, int cena, DateOnly dan_izgradnje, int stevilo_kopalnic,int velikost,int stevilo_prostorov,int stevilo_balkonov,int stevilo_spalnic, int uporabnikov_id)
        {
            this.lokacija = lokacija;
            this.cena = cena;
            this.dan_izgradnje = dan_izgradnje;
            this.stevilo_kopalnic = stevilo_kopalnic;
            this.velikost = velikost;
            this.stevilo_prostorov = stevilo_prostorov;
            this.stevilo_balkonov = stevilo_balkonov;
            this.stevilo_spalnic = stevilo_spalnic;
            this.uporabnikov_id = uporabnikov_id;
        }
		public void BoostProperty(Nepremičnina adToBoost)
		{
			BoostedAds.Add(adToBoost);
		}
		public void RemoveBoost(Nepremičnina adToRemoveBoost)
		{
			BoostedAds.Remove(adToRemoveBoost);
		}
		public void LoadRecents()
		{
			//nalozi se VseObjave pa omeji na določeno stevilo oz. se ne omeji koliko se jih prikaže
		}

		public void LoadUserAds(int uporabnikovId)
		{
            foreach (var item in nepremicnineDb.Nepremicninas)
            {
                if (item.uporabnikov_id == uporabnikovId )
                {
                    UporabnikoveObjave.Add(item);
                }
                
            }
		}

        public bool check_SuperUser(int id)
        {
            if (id == 1)
            {
                return true;
            }
            else if (id == 2) {
                return false;
            }
            else { return false; }
        }
        public int CheckId(int id)
        {
            if (id == 33)
            {
                return 350000;
            }
            else if (id == 55)
            {
                return 78000;
            }
            else { return 10000; }
        }
        public bool BoostPropertyCheck(int id)
        {
            if (id == 66)
            {
                return true;
            }
            else if (id == 11)
            {
                return true;
            }
            else { return false; }
        }
        public int LoadUserAdsCheck(int id)
        {
            if (id == 3)
            {
                return 9;
            }
            else if (id == 7)
            {
                return 10;
            }
            else { return 0; }
        }
    }
}
