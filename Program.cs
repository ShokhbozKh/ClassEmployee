namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quyidagi fieldlardan iborat Employee klassini encapsulation
            //prinsipi asosida yarating: identifikasiya raqami, ismi, familiyasi va oyligi.
            //
            Employee person1 = new("Shokirov Shoxrux");
            person1.Oylik = 123;
            person1.IdentifikasiyaRaqami = 123456;

            person1.GetInfo();
        }
    }
    class Employee
    {
        private int identifikasiyaRaqami;
        public decimal oylik { get; private set; }
        private string isimFamilya;

        public decimal Oylik
        {
            get { return oylik; }
            set
            {
                if (value >= 0)
                {
                    oylik = value;
                }
                else
                {
                    return;
                }
            }
        }
        public int IdentifikasiyaRaqami
        {
            get
            {
                return identifikasiyaRaqami;
            }
            set
            {
                if(value>0 && value.ToString().Length>=6)
                {
                    identifikasiyaRaqami = value;
                }
                else
                {
                    return;
                }
            }
        }

        public Employee(string isimFamilya)
        {
            this.isimFamilya = isimFamilya;
        }
        public void GetInfo()
        {
            Console.WriteLine($"IdentifikasiyaRaqami:{identifikasiyaRaqami}\nIsim familyasi:{isimFamilya}\nOyligi:{Oylik}");
        }

    }
}