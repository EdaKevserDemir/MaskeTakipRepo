using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        //Interface içinde sadece metod imzaları barındırabilirsin.
        //bu yapı oluşturulmasa yabancı uyruklular için bir manager yazılamazdı.
        //Birbirinin alternatifi olan systemlerin farklı implementasyon yapmalını sağlarlar.
        
        void AppyforMask(Person person);


        List<Person> GetList();



        bool CheckPerson(Person person);


    }
}
