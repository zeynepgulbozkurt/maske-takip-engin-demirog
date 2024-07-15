using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    //nu kısıma sadece imzaları yani aşağıya ekleyeceğim kısmı yazarız
    public interface IApplicantService

    {
          void ApplyForMask(person person)
       
        {
 }
           List<person> GetList();


        bool CheckPerson(person person);
        
    }
}
