using System;

namespace tema_lab9
{
    public class ContCurent : ContBancar
    {
        public static readonly decimal PLAFON = 5000;

        public ContCurent(Guid id, int sold) : base(id, sold) {}

        public override void ExtragereNumerar(decimal suma)
        {
            decimal newSold = Sold - suma;
            Sold = (newSold < -PLAFON) 
                ? throw new Exception($"Suma ceruta ({suma}) depaseste plafonul descoperitului de cont") 
                : newSold;
        }
    }
}
