using System;
using System.Reflection;
using System.Text;

namespace tema_lab9
{
    public abstract class ContBancar
    {
        public Guid Id { get; private set; }
        public decimal Sold { get; protected set; }
        public Type Tip => GetType();

        protected ContBancar(Guid id, int sold)
        {
            Id = id;
            Sold = sold;
        }

        public virtual void DepunereNumerar(decimal suma) => Sold += suma;

        public virtual void ExtragereNumerar(decimal suma) => Sold -= suma;

        public override string ToString() {
            var strBuilder = new StringBuilder();

            var properties = GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            strBuilder.AppendLine("{");
            foreach (var property in properties) 
                strBuilder.AppendLine($"\"{property.Name}\": \"{property.GetValue(this)}\",");
 
            strBuilder.AppendLine("}");

            return strBuilder.ToString();
        }
    }
}
