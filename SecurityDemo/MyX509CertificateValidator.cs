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

            if(certificate.Thumbprint.ToLower() != "bbd4c939a77100ab5dcafa505bbc5b11736e78de")
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
