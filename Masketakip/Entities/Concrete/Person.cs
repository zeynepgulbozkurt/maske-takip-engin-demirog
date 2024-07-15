using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    // internal yapıldığı zaman diğer katmanlarda çağıramıyoruz ama public yapılırsa ağer gelir
    //internal class Person
    public class person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long NationalIdentity { get; set; }
        public int  DateOfBirhYear { get; set; }
        // person classı maske takibindeki vatandaşları temsil edecek
}
}
