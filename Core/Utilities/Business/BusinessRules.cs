using System;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public BusinessRules()
        {
        }

        //parametre ile gönderdiğimiz iş kurallarını eğer başarısız ise business a bilgilendirme yapıyoruz şu logic hatalı diye.
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }

            //başarılı ise hiçbir şey döndürmesine gerek yok yani null dedik
            return null;
        }
    }
}
