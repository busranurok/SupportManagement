using System;
namespace Core.Utilities.Results.Concrete
{
    public class SuccessResult : Result
    {
        //aşağıdakiler gibi yapmayıp defaulşt değer verse idik web api çağırdığımızda adam bu değer nereden dönüyor diye kararsız kalabilirid.
        //ayrıca sürekli if şöyle ise if böyle ise diyerek kodlar yazmak zorunda kalırdı
        public SuccessResult(string message) : base(true, message)
        {
            
        }


        public SuccessResult() : base(true)
        {
        }
    }
}
