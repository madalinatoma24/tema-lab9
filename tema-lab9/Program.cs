using System;

namespace tema_lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            var contCurent = new ContCurent(Guid.NewGuid(),0);
            var contInvestitii = new ContInvestitii(Guid.NewGuid(), 0, 0.5m, 1);
            var contEconomii = new ContEconomii(Guid.NewGuid(), 0, 0.5m);

            contCurent.DepunereNumerar(1000);
            contInvestitii.DepunereNumerar(1000);
            contInvestitii.DepunereNumerar(700);
            contEconomii.DepunereNumerar(1000);
            contEconomii.DepunereNumerar(1000);
            contEconomii.DepunereNumerar(1000);
            contEconomii.DepunereNumerar(1000);

            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }
            try { contCurent.ExtragereNumerar(1000); } catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.WriteLine(contCurent);
            Console.WriteLine(contInvestitii);
            Console.WriteLine(contEconomii);
        }
    }
}
