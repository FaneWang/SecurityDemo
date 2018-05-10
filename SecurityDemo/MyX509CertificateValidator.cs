using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;

namespace SecurityDemo
{
    class MyX509CertificateValidator : X509CertificateValidator
    {
        public override void Validate(X509Certificate2 certificate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Certificate Subject is {0}", certificate.Subject);
            Console.WriteLine("Certificate Thumbprint is {0}", certificate.Thumbprint);

            if(certificate.Thumbprint.ToLower() != "b6fdedb685089e37a56cc49406933709df9edde2")
            {
                Console.WriteLine("Certificate Validation is failed,{0}", certificate.Subject);
                throw new SecurityTokenException("Unknown certificate");
            }
            else
            {
                Console.WriteLine("Certificate Validation is success,{0}", certificate.Subject);
            }
        }
    }
}
