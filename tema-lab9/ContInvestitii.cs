using System;

namespace tema_lab9
{
    class ContInvestitii : ContEconomii
    {
        public readonly (int Min, int Max)  ZI_EXTRAGERE_RANGE = (Min: 1, Max: 31);
        public int ZiExtragere { get; private set; }

        public ContInvestitii(
            Guid id,
            int sold,
            decimal rataDobanzii,
            int ziExtragere) : base(id, sold, rataDobanzii)
            => ZiExtragere = ZI_EXTRAGERE_RANGE.Min <= ziExtragere && ZI_EXTRAGERE_RANGE.Max >= ziExtragere 
                    ? ziExtragere
                    : throw new Exception($"Ziua de extragere trebuie sa se afle in intervalul [{ZI_EXTRAGERE_RANGE.Min}-{ZI_EXTRAGERE_RANGE.Max}]");

        public override void ExtragereNumerar(decimal suma)
        {
            var daysInCurrentMonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            if (DateTime.Now.Day < Math.Min(ZiExtragere, daysInCurrentMonth))
                throw new Exception("Nu puteti extrage inainte de termen");

            base.ExtragereNumerar(suma);
        }
    }
}
