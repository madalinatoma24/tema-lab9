using System;

namespace tema_lab9
{
    class ContEconomii : ContBancar
    {
        public decimal RataDobanzii { get; private set; }

        public ContEconomii(Guid id, int sold, decimal rataDobanzii) : base(id, sold)
        {
            RataDobanzii = rataDobanzii;
        }

        public override void DepunereNumerar(decimal suma)
        {
            base.DepunereNumerar(suma);
            Sold *= (1+RataDobanzii);
        }
    }
}
