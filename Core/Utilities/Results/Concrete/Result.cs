using System;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {
        public Result()
        {
        }

        //c# da this demek class ın kendisi demek yeni Result demek.
        //: this(success) : result ın tek parametreli constructor una bu parametreyi gönder demektir.
        //constructor un baseler ile çalışması ya da kendi içinde farklı yapılar ile çalışmasının bir örneğidir!
        public Result(bool success, string message) : this(success)
        {
            //hani set edilemiyordu diyorsak haklıyız ama constructorları set edilebilir!
            Message = message;
            //Success = success;
        }

        //constructor ı overloading yaptık : aşırı yükleme.
        //biz sonucu dönsün ama mesaj vermesin istiyorsak bu constructor çalışır
        public Result(bool success)
        {
            Success = success;
        }

        //yeni nesil implemention
        //public bool Success => throw new NotImplementedException();
        public bool Success { get; }

        //public string Message => throw new NotImplementedException();
        public string Message { get; }
    }
}
